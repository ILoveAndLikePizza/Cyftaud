namespace Cyftaud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FolderBox = new System.Windows.Forms.GroupBox();
            this.TargetFolderBrowse = new System.Windows.Forms.Button();
            this.TargetFolderBox = new System.Windows.Forms.TextBox();
            this.DoZippedFolder = new System.Windows.Forms.RadioButton();
            this.DoNormalFolder = new System.Windows.Forms.RadioButton();
            this.DriveBox = new System.Windows.Forms.GroupBox();
            this.DoOverwrite = new System.Windows.Forms.CheckBox();
            this.CustomFolderName = new System.Windows.Forms.TextBox();
            this.DoFolderCopy = new System.Windows.Forms.RadioButton();
            this.CopyToLabel = new System.Windows.Forms.Label();
            this.DoRootCopy = new System.Windows.Forms.RadioButton();
            this.DrivesList = new System.Windows.Forms.ComboBox();
            this.TargetDriveLabel = new System.Windows.Forms.Label();
            this.FormatBox = new System.Windows.Forms.GroupBox();
            this.NewNameLabel = new System.Windows.Forms.Label();
            this.NewDeviceName = new System.Windows.Forms.TextBox();
            this.FormatFSLabel = new System.Windows.Forms.Label();
            this.DoQuickFormat = new System.Windows.Forms.CheckBox();
            this.FormatFileSystem = new System.Windows.Forms.ComboBox();
            this.DoDriveFormat = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.FolderBox.SuspendLayout();
            this.DriveBox.SuspendLayout();
            this.FormatBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.Location = new System.Drawing.Point(9, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(119, 37);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Cyftaud";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 54);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(298, 25);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Copy Your Folders To A USB Drive";
            // 
            // FolderBox
            // 
            this.FolderBox.Controls.Add(this.TargetFolderBrowse);
            this.FolderBox.Controls.Add(this.TargetFolderBox);
            this.FolderBox.Controls.Add(this.DoZippedFolder);
            this.FolderBox.Controls.Add(this.DoNormalFolder);
            this.FolderBox.Location = new System.Drawing.Point(17, 99);
            this.FolderBox.Name = "FolderBox";
            this.FolderBox.Size = new System.Drawing.Size(449, 99);
            this.FolderBox.TabIndex = 2;
            this.FolderBox.TabStop = false;
            this.FolderBox.Text = "Folder";
            // 
            // TargetFolderBrowse
            // 
            this.TargetFolderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TargetFolderBrowse.Location = new System.Drawing.Point(357, 55);
            this.TargetFolderBrowse.Name = "TargetFolderBrowse";
            this.TargetFolderBrowse.Size = new System.Drawing.Size(75, 25);
            this.TargetFolderBrowse.TabIndex = 3;
            this.TargetFolderBrowse.Text = "Browse...";
            this.TargetFolderBrowse.UseVisualStyleBackColor = true;
            this.TargetFolderBrowse.Click += new System.EventHandler(this.TargetFolderBrowse_Click);
            // 
            // TargetFolderBox
            // 
            this.TargetFolderBox.Location = new System.Drawing.Point(17, 56);
            this.TargetFolderBox.Name = "TargetFolderBox";
            this.TargetFolderBox.ReadOnly = true;
            this.TargetFolderBox.Size = new System.Drawing.Size(334, 23);
            this.TargetFolderBox.TabIndex = 2;
            // 
            // DoZippedFolder
            // 
            this.DoZippedFolder.AutoSize = true;
            this.DoZippedFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoZippedFolder.Location = new System.Drawing.Point(180, 22);
            this.DoZippedFolder.Name = "DoZippedFolder";
            this.DoZippedFolder.Size = new System.Drawing.Size(114, 20);
            this.DoZippedFolder.TabIndex = 1;
            this.DoZippedFolder.Text = "ZIP/CYFT folder";
            this.DoZippedFolder.UseVisualStyleBackColor = true;
            this.DoZippedFolder.CheckedChanged += new System.EventHandler(this.TypeOfFolder_CheckedChanged);
            // 
            // DoNormalFolder
            // 
            this.DoNormalFolder.AutoSize = true;
            this.DoNormalFolder.Checked = true;
            this.DoNormalFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoNormalFolder.Location = new System.Drawing.Point(17, 22);
            this.DoNormalFolder.Name = "DoNormalFolder";
            this.DoNormalFolder.Size = new System.Drawing.Size(105, 20);
            this.DoNormalFolder.TabIndex = 0;
            this.DoNormalFolder.TabStop = true;
            this.DoNormalFolder.Text = "Normal folder";
            this.DoNormalFolder.UseVisualStyleBackColor = true;
            this.DoNormalFolder.CheckedChanged += new System.EventHandler(this.TypeOfFolder_CheckedChanged);
            // 
            // DriveBox
            // 
            this.DriveBox.Controls.Add(this.DoOverwrite);
            this.DriveBox.Controls.Add(this.CustomFolderName);
            this.DriveBox.Controls.Add(this.DoFolderCopy);
            this.DriveBox.Controls.Add(this.CopyToLabel);
            this.DriveBox.Controls.Add(this.DoRootCopy);
            this.DriveBox.Controls.Add(this.DrivesList);
            this.DriveBox.Controls.Add(this.TargetDriveLabel);
            this.DriveBox.Location = new System.Drawing.Point(17, 214);
            this.DriveBox.Name = "DriveBox";
            this.DriveBox.Size = new System.Drawing.Size(449, 133);
            this.DriveBox.TabIndex = 3;
            this.DriveBox.TabStop = false;
            this.DriveBox.Text = "Drive";
            // 
            // DoOverwrite
            // 
            this.DoOverwrite.AutoSize = true;
            this.DoOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoOverwrite.Location = new System.Drawing.Point(20, 96);
            this.DoOverwrite.Name = "DoOverwrite";
            this.DoOverwrite.Size = new System.Drawing.Size(245, 20);
            this.DoOverwrite.TabIndex = 6;
            this.DoOverwrite.Text = "Overwrite files if they are already present";
            this.DoOverwrite.UseVisualStyleBackColor = true;
            // 
            // CustomFolderName
            // 
            this.CustomFolderName.Enabled = false;
            this.CustomFolderName.Location = new System.Drawing.Point(300, 61);
            this.CustomFolderName.Name = "CustomFolderName";
            this.CustomFolderName.Size = new System.Drawing.Size(132, 23);
            this.CustomFolderName.TabIndex = 5;
            // 
            // DoFolderCopy
            // 
            this.DoFolderCopy.AutoSize = true;
            this.DoFolderCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoFolderCopy.Location = new System.Drawing.Point(236, 63);
            this.DoFolderCopy.Name = "DoFolderCopy";
            this.DoFolderCopy.Size = new System.Drawing.Size(67, 20);
            this.DoFolderCopy.TabIndex = 4;
            this.DoFolderCopy.Text = "Folder:";
            this.DoFolderCopy.UseVisualStyleBackColor = true;
            this.DoFolderCopy.CheckedChanged += new System.EventHandler(this.CopyTarget_CheckedChanged);
            // 
            // CopyToLabel
            // 
            this.CopyToLabel.AutoSize = true;
            this.CopyToLabel.Location = new System.Drawing.Point(17, 65);
            this.CopyToLabel.Name = "CopyToLabel";
            this.CopyToLabel.Size = new System.Drawing.Size(52, 15);
            this.CopyToLabel.TabIndex = 3;
            this.CopyToLabel.Text = "Copy to:";
            // 
            // DoRootCopy
            // 
            this.DoRootCopy.AutoSize = true;
            this.DoRootCopy.Checked = true;
            this.DoRootCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoRootCopy.Location = new System.Drawing.Point(94, 63);
            this.DoRootCopy.Name = "DoRootCopy";
            this.DoRootCopy.Size = new System.Drawing.Size(123, 20);
            this.DoRootCopy.TabIndex = 2;
            this.DoRootCopy.TabStop = true;
            this.DoRootCopy.Text = "Root of USB drive";
            this.DoRootCopy.UseVisualStyleBackColor = true;
            this.DoRootCopy.CheckedChanged += new System.EventHandler(this.CopyTarget_CheckedChanged);
            // 
            // DrivesList
            // 
            this.DrivesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrivesList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DrivesList.FormattingEnabled = true;
            this.DrivesList.Location = new System.Drawing.Point(137, 26);
            this.DrivesList.Name = "DrivesList";
            this.DrivesList.Size = new System.Drawing.Size(295, 23);
            this.DrivesList.TabIndex = 1;
            this.DrivesList.SelectedIndexChanged += new System.EventHandler(this.DrivesList_SelectedIndexChanged);
            // 
            // TargetDriveLabel
            // 
            this.TargetDriveLabel.AutoSize = true;
            this.TargetDriveLabel.Location = new System.Drawing.Point(17, 29);
            this.TargetDriveLabel.Name = "TargetDriveLabel";
            this.TargetDriveLabel.Size = new System.Drawing.Size(95, 15);
            this.TargetDriveLabel.TabIndex = 0;
            this.TargetDriveLabel.Text = "Target USB drive:";
            // 
            // FormatBox
            // 
            this.FormatBox.Controls.Add(this.NewNameLabel);
            this.FormatBox.Controls.Add(this.NewDeviceName);
            this.FormatBox.Controls.Add(this.FormatFSLabel);
            this.FormatBox.Controls.Add(this.DoQuickFormat);
            this.FormatBox.Controls.Add(this.FormatFileSystem);
            this.FormatBox.Controls.Add(this.DoDriveFormat);
            this.FormatBox.Location = new System.Drawing.Point(17, 366);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(449, 118);
            this.FormatBox.TabIndex = 4;
            this.FormatBox.TabStop = false;
            this.FormatBox.Text = "Formatting";
            // 
            // NewNameLabel
            // 
            this.NewNameLabel.AutoSize = true;
            this.NewNameLabel.Enabled = false;
            this.NewNameLabel.Location = new System.Drawing.Point(155, 57);
            this.NewNameLabel.Name = "NewNameLabel";
            this.NewNameLabel.Size = new System.Drawing.Size(110, 15);
            this.NewNameLabel.TabIndex = 5;
            this.NewNameLabel.Text = "New volume name:";
            // 
            // NewDeviceName
            // 
            this.NewDeviceName.Enabled = false;
            this.NewDeviceName.Location = new System.Drawing.Point(158, 75);
            this.NewDeviceName.Name = "NewDeviceName";
            this.NewDeviceName.Size = new System.Drawing.Size(167, 23);
            this.NewDeviceName.TabIndex = 4;
            // 
            // FormatFSLabel
            // 
            this.FormatFSLabel.AutoSize = true;
            this.FormatFSLabel.Enabled = false;
            this.FormatFSLabel.Location = new System.Drawing.Point(14, 57);
            this.FormatFSLabel.Name = "FormatFSLabel";
            this.FormatFSLabel.Size = new System.Drawing.Size(68, 15);
            this.FormatFSLabel.TabIndex = 3;
            this.FormatFSLabel.Text = "File system:";
            // 
            // DoQuickFormat
            // 
            this.DoQuickFormat.AutoSize = true;
            this.DoQuickFormat.Checked = true;
            this.DoQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoQuickFormat.Enabled = false;
            this.DoQuickFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoQuickFormat.Location = new System.Drawing.Point(344, 77);
            this.DoQuickFormat.Name = "DoQuickFormat";
            this.DoQuickFormat.Size = new System.Drawing.Size(102, 20);
            this.DoQuickFormat.TabIndex = 2;
            this.DoQuickFormat.Text = "Quick format";
            this.DoQuickFormat.UseVisualStyleBackColor = true;
            // 
            // FormatFileSystem
            // 
            this.FormatFileSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatFileSystem.Enabled = false;
            this.FormatFileSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FormatFileSystem.FormattingEnabled = true;
            this.FormatFileSystem.Items.AddRange(new object[] {
            "(preserve)",
            "NTFS",
            "FAT32",
            "exFAT",
            "FAT"});
            this.FormatFileSystem.Location = new System.Drawing.Point(17, 75);
            this.FormatFileSystem.Name = "FormatFileSystem";
            this.FormatFileSystem.Size = new System.Drawing.Size(121, 23);
            this.FormatFileSystem.TabIndex = 1;
            // 
            // DoDriveFormat
            // 
            this.DoDriveFormat.AutoSize = true;
            this.DoDriveFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DoDriveFormat.Location = new System.Drawing.Point(17, 26);
            this.DoDriveFormat.Name = "DoDriveFormat";
            this.DoDriveFormat.Size = new System.Drawing.Size(226, 20);
            this.DoDriveFormat.TabIndex = 0;
            this.DoDriveFormat.Text = "Format the USB drive before copying";
            this.DoDriveFormat.UseVisualStyleBackColor = true;
            this.DoDriveFormat.CheckedChanged += new System.EventHandler(this.DoDriveFormat_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 502);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(364, 36);
            this.progressBar1.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(387, 501);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(79, 38);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 559);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.DriveBox);
            this.Controls.Add(this.FolderBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cyftaud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FolderBox.ResumeLayout(false);
            this.FolderBox.PerformLayout();
            this.DriveBox.ResumeLayout(false);
            this.DriveBox.PerformLayout();
            this.FormatBox.ResumeLayout(false);
            this.FormatBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MainLabel;
        private Label DescriptionLabel;
        private GroupBox FolderBox;
        private Button TargetFolderBrowse;
        private TextBox TargetFolderBox;
        private RadioButton DoZippedFolder;
        private RadioButton DoNormalFolder;
        private GroupBox DriveBox;
        private ComboBox DrivesList;
        private Label TargetDriveLabel;
        private TextBox CustomFolderName;
        private RadioButton DoFolderCopy;
        private Label CopyToLabel;
        private RadioButton DoRootCopy;
        private GroupBox FormatBox;
        private CheckBox DoDriveFormat;
        private ProgressBar progressBar1;
        private Button StartButton;
        private Label NewNameLabel;
        private TextBox NewDeviceName;
        private Label FormatFSLabel;
        private CheckBox DoQuickFormat;
        private ComboBox FormatFileSystem;
        private CheckBox DoOverwrite;
    }
}