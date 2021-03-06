﻿namespace ao_id_extractor
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.AOFolder = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.SelectFromRegistry = new System.Windows.Forms.Button();
      this.SelectAOFolder = new System.Windows.Forms.Button();
      this.SelectOutFolder = new System.Windows.Forms.Button();
      this.OutFolder = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.ExportType = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.ExtractionMode = new System.Windows.Forms.ComboBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.ConsoleBox = new System.Windows.Forms.TextBox();
      this.btnExtract = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // AOFolder
      // 
      this.AOFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.AOFolder.Location = new System.Drawing.Point(142, 71);
      this.AOFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.AOFolder.Name = "AOFolder";
      this.AOFolder.Size = new System.Drawing.Size(592, 26);
      this.AOFolder.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.SelectFromRegistry);
      this.groupBox1.Controls.Add(this.SelectAOFolder);
      this.groupBox1.Controls.Add(this.SelectOutFolder);
      this.groupBox1.Controls.Add(this.OutFolder);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.AOFolder);
      this.groupBox1.Location = new System.Drawing.Point(9, 2);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Size = new System.Drawing.Size(1010, 120);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Paths";
      // 
      // SelectFromRegistry
      // 
      this.SelectFromRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SelectFromRegistry.Location = new System.Drawing.Point(746, 68);
      this.SelectFromRegistry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.SelectFromRegistry.Name = "SelectFromRegistry";
      this.SelectFromRegistry.Size = new System.Drawing.Size(134, 35);
      this.SelectFromRegistry.TabIndex = 7;
      this.SelectFromRegistry.Text = "From Registry";
      this.SelectFromRegistry.UseVisualStyleBackColor = true;
      this.SelectFromRegistry.Click += new System.EventHandler(this.SelectFromRegistry_Click);
      // 
      // SelectAOFolder
      // 
      this.SelectAOFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SelectAOFolder.Location = new System.Drawing.Point(888, 68);
      this.SelectAOFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.SelectAOFolder.Name = "SelectAOFolder";
      this.SelectAOFolder.Size = new System.Drawing.Size(112, 35);
      this.SelectAOFolder.TabIndex = 6;
      this.SelectAOFolder.Text = "Select";
      this.SelectAOFolder.UseVisualStyleBackColor = true;
      this.SelectAOFolder.Click += new System.EventHandler(this.SelectAOFolder_Click);
      // 
      // SelectOutFolder
      // 
      this.SelectOutFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SelectOutFolder.Location = new System.Drawing.Point(888, 26);
      this.SelectOutFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.SelectOutFolder.Name = "SelectOutFolder";
      this.SelectOutFolder.Size = new System.Drawing.Size(112, 35);
      this.SelectOutFolder.TabIndex = 5;
      this.SelectOutFolder.Text = "Select";
      this.SelectOutFolder.UseVisualStyleBackColor = true;
      this.SelectOutFolder.Click += new System.EventHandler(this.SelectOutFolder_Click);
      // 
      // OutFolder
      // 
      this.OutFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.OutFolder.Location = new System.Drawing.Point(142, 29);
      this.OutFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.OutFolder.Name = "OutFolder";
      this.OutFolder.Size = new System.Drawing.Size(734, 26);
      this.OutFolder.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 75);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(123, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "AO Main Folder:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 34);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(111, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Output Folder:";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.ExportType);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.ExtractionMode);
      this.groupBox2.Location = new System.Drawing.Point(9, 131);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox2.Size = new System.Drawing.Size(1010, 86);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Settings";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(710, 34);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(97, 20);
      this.label4.TabIndex = 5;
      this.label4.Text = "Export Type:";
      // 
      // ExportType
      // 
      this.ExportType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ExportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ExportType.FormattingEnabled = true;
      this.ExportType.Items.AddRange(new object[] {
            "Text List",
            "JSON",
            "Both"});
      this.ExportType.Location = new System.Drawing.Point(819, 29);
      this.ExportType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.ExportType.Name = "ExportType";
      this.ExportType.Size = new System.Drawing.Size(180, 28);
      this.ExportType.TabIndex = 4;
      this.ExportType.SelectedIndexChanged += new System.EventHandler(this.ExportType_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 34);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(128, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Extraction Mode:";
      // 
      // ExtractionMode
      // 
      this.ExtractionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ExtractionMode.FormattingEnabled = true;
      this.ExtractionMode.Items.AddRange(new object[] {
            "Item Extraction",
            "Location Extraction",
            "Resource Extraction",
            "Dump All XML",
            "Extract Items & Locations & Resource"});
      this.ExtractionMode.Location = new System.Drawing.Point(148, 29);
      this.ExtractionMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.ExtractionMode.Name = "ExtractionMode";
      this.ExtractionMode.Size = new System.Drawing.Size(180, 28);
      this.ExtractionMode.TabIndex = 0;
      this.ExtractionMode.SelectedIndexChanged += new System.EventHandler(this.ExtractionMode_SelectedIndexChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.ConsoleBox);
      this.groupBox3.Location = new System.Drawing.Point(9, 226);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox3.Size = new System.Drawing.Size(1010, 486);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Console";
      // 
      // ConsoleBox
      // 
      this.ConsoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ConsoleBox.Location = new System.Drawing.Point(9, 31);
      this.ConsoleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.ConsoleBox.Multiline = true;
      this.ConsoleBox.Name = "ConsoleBox";
      this.ConsoleBox.ReadOnly = true;
      this.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.ConsoleBox.Size = new System.Drawing.Size(990, 444);
      this.ConsoleBox.TabIndex = 0;
      this.ConsoleBox.WordWrap = false;
      // 
      // btnExtract
      // 
      this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExtract.Location = new System.Drawing.Point(897, 725);
      this.btnExtract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnExtract.Name = "btnExtract";
      this.btnExtract.Size = new System.Drawing.Size(112, 35);
      this.btnExtract.TabIndex = 4;
      this.btnExtract.Text = "Extract";
      this.btnExtract.UseVisualStyleBackColor = true;
      this.btnExtract.Click += new System.EventHandler(this.Extract_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1028, 778);
      this.Controls.Add(this.btnExtract);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MinimumSize = new System.Drawing.Size(754, 590);
      this.Name = "MainWindow";
      this.Text = "AO Binary Extractor";
      this.Load += new System.EventHandler(this.MainWindow_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox AOFolder;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox OutFolder;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button SelectAOFolder;
    private System.Windows.Forms.Button SelectOutFolder;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox ExtractionMode;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox ExportType;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnExtract;
    private System.Windows.Forms.Button SelectFromRegistry;
    public System.Windows.Forms.TextBox ConsoleBox;
  }
}