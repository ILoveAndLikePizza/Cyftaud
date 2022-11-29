using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyftaud
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            NameVersionLabel.Text += ProductVersion;
        }
        private void OpenURL(string url)
        {
            ProcessStartInfo process = new ProcessStartInfo("cmd.exe", "/c start " + url);
            process.CreateNoWindow = true;
            System.Diagnostics.Process.Start(process);
        }

        private void WebsiteButton_Click(object sender, EventArgs e)
        {
            OpenURL("https://nm-games.eu");
        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            OpenURL("https://github.com/ILoveAndLikePizza/Cyftaud");
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            OpenURL("https://discord.gg/CaMaGRXDqB");
        }
    }
}
