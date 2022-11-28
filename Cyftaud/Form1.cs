using System.Text.RegularExpressions;

namespace Cyftaud
{
    public partial class Form1 : Form
    {
        private bool running = false;
        private bool finished = false;

        public Form1()
        {
            InitializeComponent();
        }

        private string GetDriveLetter()
        {
            System.Text.RegularExpressions.Match match = Regex.Match(DrivesList.Text, @"\(([A-Z]{1}:)\)");
            string letter = (match.Success) ? match.Groups[1].ToString() : "";
            return letter;
        }

        private DriveInfo GetDriveInformation()
        {
            DriveInfo drive = new DriveInfo(GetDriveLetter());
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
            if (finished) Environment.Exit(1); else
            {

                string oldFS = GetDriveInformation().DriveFormat;
                if (DoDriveFormat.Checked)
                {
                    if (MessageBox.Show("WARNING: ALL DATA ON '" + GetDriveInformation().VolumeLabel + "'\nWILL BE DESTROYED AND CANNOT BE RECOVERED!\nPlease ensure if important files are backed up before proceeding!", "IMPORTANT WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                }
                else if (DoOverwrite.Checked)
                {
                    if (MessageBox.Show("WARNING: Files on '" + GetDriveInformation().VolumeLabel + "'\nmight be overwritten.\nPlease ensure if important files are backed up before proceeding!", "Important warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                }
                if (TargetFolderBox.Text.Length == 0)
                {
                    MessageBox.Show("You did not specify a folder path!", "Unable to start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CustomFolderName.Enabled)
                {
                    System.Text.RegularExpressions.Match match = Regex.Match(CustomFolderName.Text, @"^[A-Za-z0-9_]+$");
                    if (CustomFolderName.Text.Length == 0)
                    {
                        MessageBox.Show("Your folder name is empty!", "Unable to start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!match.Success)
                    {
                        MessageBox.Show("Your folder name is invalid!", "Unable to start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (NewDeviceName.Enabled)
                {
                    System.Text.RegularExpressions.Match match = Regex.Match(NewDeviceName.Text, @"^[A-Za-z0-9_]+$");
                    if (NewDeviceName.Text.Length == 0)
                    {
                        MessageBox.Show("Your new volume name is empty!", "Unable to start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!match.Success)
                    {
                        MessageBox.Show("Your new volume name is invalid!", "Unable to start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                FolderBox.Enabled = DriveBox.Enabled = FormatBox.Enabled = StartButton.Enabled = false;
                StatusLabel.Visible = running = true;
                if (DoDriveFormat.Checked)
                {
                    string newFS = (FormatFileSystem.Text == FormatFileSystem.Items[0].ToString()) ? oldFS : FormatFileSystem.Text;
                    string quickFormat = (DoQuickFormat.Checked) ? " /Q" : "";
                    //System.Diagnostics.Process.Start("format.com", GetDriveLetter() + " /FS:" + newFS + quickFormat + " /V:" + NewDeviceName);
                    MessageBox.Show(GetDriveLetter() + " /FS:" + newFS.ToUpper() + quickFormat + "/V:" + NewDeviceName);
                }
                if (DoFolderCopy.Checked && !Directory.Exists(GetDriveLetter() + "\\" + CustomFolderName.Text)) Directory.CreateDirectory(GetDriveLetter() + "\\" + CustomFolderName.Text);
                if (DoNormalFolder.Checked)
                {
                    string[] filenames = Directory.GetFiles(TargetFolderBox.Text);
                    string target = (DoFolderCopy.Checked) ? GetDriveLetter() + "\\" + CustomFolderName.Text + "\\": GetDriveLetter() + "\\";
                    for (int i = 0; i < filenames.Length; i++)
                    {
                        string[] fragments = filenames[i].Split('\\');
                        string filename = fragments[fragments.Length - 1];
                        StatusLabel.Text = "Copying " + filename + "...";
                        File.Copy(filenames[i], target + filename, DoOverwrite.Checked);
                        Progress.Value += (int)Math.Round(Progress.Maximum / (double)filenames.Length);
                    }
                }
                else if (DoZippedFolder.Checked)
                {

                }

                running = false;
                StatusLabel.Text = "Done!";
                StartButton.Text = "Quit";
                StartButton.Enabled = finished = true;
                Progress.Value = Progress.Maximum;
            }
        }

        private void DrivesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DoDriveFormat.Checked) NewDeviceName.Text = GetDriveInformation().VolumeLabel;
        }

        private void DoDriveFormat_CheckedChanged(object sender, EventArgs e)
        {
            DoOverwrite.Enabled = !DoDriveFormat.Checked;
            FormatFSLabel.Enabled = NewNameLabel.Enabled = FormatFileSystem.Enabled = NewDeviceName.Enabled = DoQuickFormat.Enabled
                = DoDriveFormat.Checked;

            NewDeviceName.Text = (NewDeviceName.Enabled) ? GetDriveInformation().VolumeLabel : "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running) e.Cancel = true;
        }
    }
}