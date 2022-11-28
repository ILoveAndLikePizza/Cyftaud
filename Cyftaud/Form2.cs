using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void WebsiteButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c start https://nm-games.eu");
        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c start https://github.com/ILoveAndLikePizza/Cyftaud");
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c start https://discord.gg/CaMaGRXDqB");
        }
    }
}
