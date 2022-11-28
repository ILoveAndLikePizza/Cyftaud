using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace Cyftaud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DriveInfo GetDriveLetter()
        {
            System.Text.RegularExpressions.Match match = Regex.Match(DrivesList.Text, @"\(([A-Z]{1}:)\)");
            string letter = (match.Success) ? match.Groups[1].ToString() : "";
            DriveInfo drive = new DriveInfo(letter);
            return drive;
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                DriveInfo drive = drives[i];
                try
                {
                    if (drive.DriveType != DriveType.Removable) continue;

                    string diskLetter = drive.Name.Substring(0, 2);
                    string label = (drive.VolumeLabel.Length == 0) ? "(untitled)" : drive.VolumeLabel;
                    string itemName = label + " (" + diskLetter + ") [" + Math.Round(drive.TotalSize / 1e9, 1) + " GB]";
                    DrivesList.Items.Add(itemName);
                } catch (System.IO.IOException) {}
            }
            DrivesList.SelectedIndex = FormatFileSystem.SelectedIndex = 0;
        }

        private void CopyTarget_CheckedChanged(object sender, EventArgs e)
        {
            CustomFolderName.Enabled = DoFolderCopy.Checked;
        }

        private void TargetFolderBrowse_Click(object sender, EventArgs e)
        {
            if (DoNormalFolder.Checked)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Select folder";
                dialog.UseDescriptionForTitle = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TargetFolderBox.Text = dialog.SelectedPath;
                }
            }
            else if (DoZippedFolder.Checked)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select zipped folder";
                dialog.Filter = "ZIP folder|*.zip|CYFT folder|*.cyft";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TargetFolderBox.Text = dialog.FileName;
                }
            }
        }

        private void TypeOfFolder_CheckedChanged(object sender, EventArgs e)
        {
            TargetFolderBox.Text = "";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void DrivesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoDriveFormat.Checked) NewDeviceName.Text = GetDriveLetter().VolumeLabel;
        }

        private void DoDriveFormat_CheckedChanged(object sender, EventArgs e)
        {
            DoOverwrite.Enabled = !DoDriveFormat.Checked;
            FormatFSLabel.Enabled = NewNameLabel.Enabled = FormatFileSystem.Enabled = NewDeviceName.Enabled = DoQuickFormat.Enabled
                = DoDriveFormat.Checked;

            NewDeviceName.Text = (NewDeviceName.Enabled) ? GetDriveLetter().VolumeLabel : "";
        }

    }
}