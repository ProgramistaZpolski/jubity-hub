using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jubity_Hub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("C:\\Smiecie");
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += Toaleta_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    new System.Uri("https://cdn.discordapp.com/attachments/343758314498293760/596042553053282304/Smiec.zip"),
                    "C:\\Smiecie\\smiec.zip"
                );
            }
            Process.Start(@"C:\Smiecie\");
        }
        void Toaleta_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://mega.nz/#!DCwH0A6I!tZxz8Ac38w1rQ2wYAm_w-W9Kz74TdHw2k2QhSHLdv94");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("C:\\Smiecie");
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += Toaleta_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    new System.Uri("https://cdn.discordapp.com/attachments/343758314498293760/597101548148883486/JubySetup.exe"),
                    "C:\\Smiecie\\jubbby.exe"
                );
            }
            Process.Start(@"C:\Smiecie\");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //https://cdn.discordapp.com/attachments/444866910035771415/597791904112836628/symulator-instalowania-romu-20190708-142620.save
            System.IO.Directory.CreateDirectory("C:\\Smiecie");
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += Toaleta_DownloadProgressChanged;
                wc.DownloadFileAsync(
                    new System.Uri("https://cdn.discordapp.com/attachments/444866910035771415/597791904112836628/symulator-instalowania-romu-20190708-142620.save"),
                    "C:\\Smiecie\\CHEAT.save"
                );
            }
            Process.Start(@"C:\Smiecie\");
        }
    }
}
