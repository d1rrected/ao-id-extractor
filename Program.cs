﻿using ao_id_extractor.Extractors;
using ao_id_extractor.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ao_id_extractor
{
  public static class ProcessExtensions
  {
    private static string FindIndexedProcessName(int pid)
    {
      var processName = Process.GetProcessById(pid).ProcessName;
      var processesByName = Process.GetProcessesByName(processName);
      string processIndexdName = null;

      for (var index = 0; index < processesByName.Length; index++)
      {
        processIndexdName = index == 0 ? processName : processName + "#" + index;
        var processId = new PerformanceCounter("Process", "ID Process", processIndexdName);
        if ((int)processId.NextValue() == pid)
        {
          return processIndexdName;
        }
      }

      return processIndexdName;
    }

    private static Process FindPidFromIndexedProcessName(string indexedProcessName)
    {
      var parentId = new PerformanceCounter("Process", "Creating Process ID", indexedProcessName);
      return Process.GetProcessById((int)parentId.NextValue());
    }

    public static Process Parent(this Process process)
    {
      return FindPidFromIndexedProcessName(FindIndexedProcessName(process.Id));
    }
  }

  public static class Program
  {
    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AllocConsole();

    public static string OutputFolderPath { get; set; }
    public static ExportType ExportType { get; set; }
    public static ExportMode ExportMode { get; set; }
    public static string MainGameFolder { get; set; }

    private static void PrintCmdHelp()
    {
      Console.WriteLine("How to use:\nao-id-extractor.exe modeID outFormat [outFolder]\n" +
          "modeID\t\t#Extraction 0=Item Extraction, 1=Location Extraction, 2=Resource Extraction, 3=Dump All, 4=Extract Items & Locations & Resource\n" +
          "outFormat\t#l=Text List, j=JSON b=Both\n" +
          "[outFolder]\t#OPTIONAL: Output folder path. Default: current directory\n" +
          "[gameFolder]\t#OPTIONAL: Location of the main AlbionOnline folder");
    }

    private static void ParseCommandline(string[] args)
    {
      if (args.Length >= 2)
      {
        var exportMode = int.Parse(args[0]);
        if (exportMode >= 0 && exportMode <= 3)
        {
          ExportMode = (ExportMode)exportMode;
        }
        else
        {
          PrintCmdHelp();
          return;
        }

        if (args[1] == "l" || args[1] == "j" || args[1] == "b")
        {
          ExportType = ExportType.Both;
          switch (args[1])
          {
            case "l":
              ExportType = ExportType.TextList;
              break;
            case "j":
              ExportType = ExportType.Json;
              break;
          }
        }
        else
        {
          PrintCmdHelp();
          return;
        }

        if (args.Length >= 3)
        {
          if (string.IsNullOrWhiteSpace(args[2]))
          {
            OutputFolderPath = Directory.GetCurrentDirectory();
          }
          else
          {
            OutputFolderPath = args[2];
          }
        }

        if (args.Length == 4)
        {
          MainGameFolder = args[3];
        }
      }
      else
      {
        PrintCmdHelp();
        return;
      }
    }

    [STAThread]
    private static void Main(string[] args)
    {
      OutputFolderPath = "";
      MainGameFolder = "";

      var parentName = Process.GetCurrentProcess().Parent().ProcessName;

      ParseCommandline(args);

      if (parentName != "cmd")
      {
        var mainWindow = new MainWindow();
        Application.EnableVisualStyles();
        Console.SetOut(new MultiTextWriter(new ControlWriter(mainWindow.ConsoleBox), Console.Out));
        Application.Run(mainWindow);
        return;
      }
      else
      {
        AllocConsole();

        RunExtractions();
      }

      Console.Out.WriteLine("\nPress Any Key to Quit");
      Console.ReadKey();
    }

    public static void RunExtractions()
    {
      Console.Out.WriteLine("#---- Starting Extraction Operation ----#");

      var exportTypeString = "";
      if (ExportType == ExportType.TextList)
        exportTypeString = "Text List";
      else if (ExportType == ExportType.Json)
        exportTypeString = "JSON";
      else
        exportTypeString = "Text List and JSON";

      switch (ExportMode)
      {
        case ExportMode.Item_Extraction:
          Console.Out.WriteLine("--- Starting Extraction of Items as " + exportTypeString + " ---");
          new ItemExtractor().Extract();
          Console.Out.WriteLine("--- Extraction Complete! ---");
          break;
        case ExportMode.Location_Extraction:
          Console.Out.WriteLine("--- Starting Extraction of Locations as " + exportTypeString + " ---");
          new LocationExtractor().Extract();
          Console.Out.WriteLine("--- Extraction Complete! ---");
          break;
        case ExportMode.Resource_Extraction:
          Console.Out.WriteLine("--- Starting Extraction of Resources as " + exportTypeString + " ---");
          new ResourceExtractor().Extract();
          Console.Out.WriteLine("--- Extraction Complete! ---");
          break;
        case ExportMode.Dump_All_XML:
          Console.Out.WriteLine("--- Starting Extraction of All Files as XML ---");
          new BinaryDumper().Extract();
          Console.Out.WriteLine("--- Extraction Complete! ---");
          break;
        case ExportMode.Extract_Items_Locations_Resource:
          Console.Out.WriteLine("--- Starting Extraction of Items as " + exportTypeString + " ---");
          new ItemExtractor().Extract();
          Console.Out.WriteLine("--- Extraction Complete! ---");

          Console.Out.WriteLine("--- Starting Extraction of Locations as " + exportTypeString + " ---");
          new LocationExtractor().Extract();
          Console.Out.WriteLine("--- Extraction Complete! ---");

          Console.Out.WriteLine("--- Starting Extraction of Resources as " + exportTypeString + " ---");
          new ResourceExtractor().Extract();
          Console.Out.WriteLine("--- Extraction Complete! ---");
          break;
      }
      Console.Out.WriteLine("#---- Finished Extraction Operation ----#");
    }
  }
}
