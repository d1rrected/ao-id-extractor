﻿using ao_id_extractor.Helpers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ao_id_extractor.Extractors
{
  public class IDContainer
  {
    public string Index { get; set; }
    public string UniqueName { get; set; }
  }

  public class ItemContainer : IDContainer
  {
    public string LocalizationNameVariable { get; set; }
    public string LocalizationDescriptionVariable { get; set; }
    public KeyValuePair<string, string>[] LocalizedNames { get; set; }
    public KeyValuePair<string, string>[] LocalizedDescriptions { get; set; }
  }

  public enum ExportType
  {
    TextList,
    Json,
    Both
  }

  public enum ExportMode
  {
    Item_Extraction,
    Location_Extraction,
    Resource_Extraction,
    Dump_All_XML,
    Extract_Items_Locations_Resource
  }

  public abstract class BaseExtractor
  {
    protected BaseExtractor()
    {
      Program.OutputFolderPath = Program.OutputFolderPath?.Length == 0 ? Path.GetDirectoryName(Application.ExecutablePath) : Program.OutputFolderPath;

      if (string.IsNullOrWhiteSpace(Program.MainGameFolder))
      {
        var obj = (string)Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\SandboxAlbionOnline", false).GetValue("DisplayIcon");
        Program.MainGameFolder = Path.Combine(Path.GetDirectoryName(obj.Trim('\"')), "..");
      }
    }

    protected abstract string GetBinFilePath();
    protected abstract void ExtractFromXML(Stream inputXmlFile, MultiStream outputStream, Action<MultiStream, IDContainer> writeItem, bool withLocal = true);

    protected XmlElement FindElement(XmlNode node, string elementName)
    {
      foreach (XmlNode childNode in node.ChildNodes)
      {
        if (childNode is XmlElement ele && ele.Name == elementName)
        {
          return ele;
        }
      }

      return null;
    }

    public void Extract(bool withLocal = true)
    {
      var xmlPath = DecryptBinFile(GetBinFilePath());
      using (var inputFile = File.OpenRead(xmlPath))
      {
        var streamTypes = new List<StreamType>();
        if (Program.ExportType == ExportType.TextList || Program.ExportType == ExportType.Both)
        {
          const ExportType exportType = ExportType.TextList;
          streamTypes.Add(new StreamType
          {
            Stream = GetExportStream(exportType),
            ExportType = exportType
          });
        }
        if (Program.ExportType == ExportType.Json || Program.ExportType == ExportType.Both)
        {
          const ExportType exportType = ExportType.Json;
          streamTypes.Add(new StreamType
          {
            Stream = GetExportStream(exportType),
            ExportType = exportType
          });
        }
        var multiStream = new MultiStream(streamTypes.ToArray());

        ExtractFromXML(inputFile, multiStream, WriteItem, withLocal);

        foreach (var streamType in streamTypes)
        {
          CloseExportStream(streamType.Stream, streamType.ExportType);
          streamType.Stream.Close();
        }
      }
      File.Delete(xmlPath);
    }

    //public List<IDContainer> PureExtract(bool withLocal = true)
    //{
    //  using (var ms = new MemoryStream())
    //  {
    //    DecryptBinFile(GetBinFilePath(), ms);
    //    ms.Flush();
    //    ms.Position = 0;
    //    return ExtractFromXML(ms, withLocal);
    //  }
    //}

    public static string DecryptBinFile(string binFile)
    {
      var binFileWOE = Path.GetFileNameWithoutExtension(binFile);

      Console.Out.WriteLine("Extracting " + binFileWOE + ".bin...");

      var finalOutPath = Path.Combine(Program.OutputFolderPath, binFileWOE + ".xml");
      Directory.CreateDirectory(Path.GetDirectoryName(finalOutPath));

      using (var outputStream = File.OpenWrite(finalOutPath))
      {
        BinaryDecrypter.DecryptBinaryFile(binFile, outputStream);
      }

      return finalOutPath;
    }

    private Stream GetExportStream(ExportType exportType)
    {
      var filePathWithoutExtension = Path.Combine(Program.OutputFolderPath, Path.GetFileNameWithoutExtension(GetBinFilePath()));
      if (!Directory.Exists(Path.GetDirectoryName(filePathWithoutExtension)))
      {
        var di = Directory.CreateDirectory(Path.GetDirectoryName(filePathWithoutExtension));
      }

      if (exportType == ExportType.TextList)
      {
        return File.OpenWrite(filePathWithoutExtension + ".txt");
      }
      else if (exportType == ExportType.Json)
      {
        var stream = File.OpenWrite(filePathWithoutExtension + ".json");
        WriteString(stream, "[" + Environment.NewLine);
        return stream;
      }
      return File.OpenWrite(filePathWithoutExtension + ".txt");
    }

    private void CloseExportStream(Stream stream, ExportType exportType)
    {
      if (exportType == ExportType.Json)
      {
        WriteString(stream, "]");
      }
    }

    private void WriteItem(MultiStream multiStream, IDContainer item)
    {
      foreach (var streamType in multiStream.StreamTypes)
      {
        var output = new StringBuilder();
        if (streamType.ExportType == ExportType.TextList)
        {
          output.AppendFormat("{0}:{1}", item.Index, item.UniqueName).AppendLine();
        }
        else if (streamType.ExportType == ExportType.Json)
        {
          output.Append(JSONHelper.FormatJson(item.ToJSON())).AppendLine(",");
        }
        WriteString(streamType, output.ToString());
        output.Clear();
      }
    }

    private void WriteString(StreamType stream, string val)
    {
      var buffer = Encoding.UTF8.GetBytes(val);
      stream.Stream.Write(buffer, 0, buffer.Length);
    }

    private void WriteString(Stream stream, string val)
    {
      var buffer = Encoding.UTF8.GetBytes(val);
      stream.Write(buffer, 0, buffer.Length);
    }
  }
}
