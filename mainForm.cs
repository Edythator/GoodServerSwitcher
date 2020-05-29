using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;

namespace goodNewServerSwitcher
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        List<string> buffer = new List<string>();
        string[] osuIP = { "osu.ppy.sh", "c.ppy.sh", "c1.ppy.sh", "c2.ppy.sh", "c3.ppy.sh",
            "c4.ppy.sh", "c5.ppy.sh", "c6.ppy.sh", "ce.ppy.sh", "a.ppy.sh", "s.ppy.sh", "i.ppy.sh", "bm6.ppy.sh" };
        string path = @"C:\Windows\system32\drivers\etc\hosts";

        private void mainForm_Load(object sender, EventArgs e)
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    MessageBox.Show("Please run the program as an administrator.", "GoodServerSwitcher");
                    Environment.Exit(-1);
                }
            }

            buffer = File.ReadAllLines(path).ToList();
            foreach (string s in buffer)
                txtBoxHosts.Text += s + Environment.NewLine;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string banchoIP = "";
            bool alreadyModified = false;
            foreach (string s in buffer)
            {
                if (s.Contains("osu.ppy.sh"))
                {
                    banchoIP = s.Replace("osu.ppy.sh", "").Trim();
                    alreadyModified = true;
                    break;
                }
            }

            if (alreadyModified)
            {
                buffer.RemoveAll(x => x.Contains(banchoIP) && osuIP.Any(y => x.Contains(y)));
                File.WriteAllLines(path, buffer);
                txtBoxHosts.Text = "";
                foreach (string s in buffer)
                    txtBoxHosts.Text += s + Environment.NewLine;
            }

            else
            {
                List<string> newBuffer = new List<string>();
                if (txtBoxIP.Text != "")
                {
                    banchoIP = txtBoxIP.Text;
                    foreach (string s in osuIP)
                        newBuffer.Add(banchoIP + "      " + s);
                    File.AppendAllLines(path, newBuffer);

                    foreach (string s in newBuffer)
                        txtBoxHosts.Text += s + Environment.NewLine;
                }
                else
                    MessageBox.Show("Please enter an IP.", "GoodServerSwitcher");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtBoxCertPath.Text = ofd.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            txtBoxCertPath.Text = txtBoxCertPath.Text.Trim();
            if (txtBoxCertPath.Text != "")
            {
                using (Process p = new Process())
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/C certutil –addstore -enterprise –f \"Root\" " + $"\"{txtBoxCertPath.Text}\"");
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.Verb = "runas";
                    p.StartInfo = startInfo;
                    p.Start();
                }
                MessageBox.Show("Imported certificate.", "GoodServerSwitcher");
            }
            else
                MessageBox.Show("Please enter the path of the certificate file.", "GoodServerSwitcher");
        }
    }
}
