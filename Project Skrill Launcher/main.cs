using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Project_Skrill_Launcher
{
    public partial class main : Form
    {
        public String Serverpath = "";
        public String Clientpath = "";
        public main()
        {
            InitializeComponent();
        }

        private void StartServer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] Server = Process.GetProcessesByName("sodoff");
                Process[] mmo = Process.GetProcessesByName("sodoffmmo");
                if (Server.Length == 0 && mmo.Length == 0)
                {
                    ProcessStartInfo _processStartInfo = new ProcessStartInfo();
                    _processStartInfo.WorkingDirectory = Serverpath;
                    _processStartInfo.FileName = @"sodoff.exe";
                    _processStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    Process myProcess = Process.Start(_processStartInfo);
                    if (mmoOption.Checked == true)
                    {
                        ProcessStartInfo _processStartInfoo = new ProcessStartInfo();
                        _processStartInfoo.WorkingDirectory = Serverpath;
                        _processStartInfoo.FileName = @"sodoffmmo.exe";
                        _processStartInfoo.WindowStyle = ProcessWindowStyle.Minimized;
                        Process myProcesss = Process.Start(_processStartInfoo);
                    }
                }
                else if (Server.Length > 0 || mmo.Length > 0)
                {
                    MessageBox.Show("Close running server first");
                }
            }
            catch
            {
                if (Serverpath == "")
                {
                    MessageBox.Show("Invalid Server path");
                }
            }
        }

        private void StartClient_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] Server = Process.GetProcessesByName("sodoff");
                if (Server.Length == 0)
                {
                    if (MessageBox.Show("Are you sure you want to run the game without the server?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Process[] Client = Process.GetProcessesByName("DOMain");
                        if (Client.Length == 0)
                        {
                            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
                            _processStartInfo.WorkingDirectory = Clientpath;
                            _processStartInfo.FileName = @"DOMain.exe";
                            Process myProcess = Process.Start(_processStartInfo);
                        }
                        else if (Client.Length > 0)
                        {
                            MessageBox.Show("Close running client first");
                        }
                    }
                }
                else if (Server.Length > 0)
                {
                    Process[] Client = Process.GetProcessesByName("DOMain");
                    if (Client.Length == 0)
                    {
                        ProcessStartInfo _processStartInfo = new ProcessStartInfo();
                        _processStartInfo.WorkingDirectory = Clientpath;
                        _processStartInfo.FileName = @"DOMain.exe";
                        Process myProcess = Process.Start(_processStartInfo);
                    }
                    else if (Client.Length > 0)
                    {
                        MessageBox.Show("Close running client first");
                    }
                }
            }
            catch
            {
                if (Clientpath == "")
                {
                    MessageBox.Show("Invalid Client path");
                }
            }
        }

        private void Serverpath_Input_TextChanged(object sender, EventArgs e)
        {
            Serverpath = Serverpath_Input.Text;
            File.WriteAllText("launcherconfig/skrillconfig/ServerpathData.txt", Serverpath);
        }

        private void Clientpath_Input_TextChanged(object sender, EventArgs e)
        {
            Clientpath = Clientpath_Input.Text;
            File.WriteAllText("launcherconfig/skrillconfig/ClientpathData.txt", Clientpath);
        }

        private void StopServer_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] Server = Process.GetProcessesByName("sodoff");
                Process[] mmo = Process.GetProcessesByName("sodoffmmo");
                if (Server.Length == 0 && mmo.Length == 0)
                {
                    MessageBox.Show("Server is not running");
                }
                else if (Server.Length > 0 || mmo.Length > 0)
                {
                    foreach (var process in Process.GetProcessesByName("sodoff"))
                    {
                        process.Kill();
                    }
                    foreach (var process in Process.GetProcessesByName("sodoffmmo"))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception b)
            {
                MessageBox.Show("Error:" + b);
            }
        }

        private void StopClient_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] Client = Process.GetProcessesByName("DOMain");
                if (Client.Length == 0)
                {
                    MessageBox.Show("Client is not running");
                }
                else if (Client.Length > 0)
                {
                    foreach (var process in Process.GetProcessesByName("DOMain"))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception b)
            {
                MessageBox.Show("Error:" + b);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists("launcherconfig/skrillconfig"))
                {
                    Directory.CreateDirectory("launcherconfig/skrillconfig");
                    if (Directory.Exists("launcherconfig/skrillconfig"))
                    {
                        if (!File.Exists("launcherconfig/skrillconfig/MMOData.txt"))
                        {
                            File.WriteAllText("launcherconfig/skrillconfig/MMOData.txt", "false");
                        }
                        else if (File.Exists("launcherconfig/skrillconfig/MMOData.txt"))
                        {
                            String MMOFILE = File.ReadAllText("launcherconfig/skrillconfig/MMOData.txt");
                            if (MMOFILE == "true")
                            {
                                mmoOption.Checked = true;
                            }
                            else if (MMOFILE == "false")
                            {
                                mmoOption.Checked = false;
                            }
                        }
                        if (File.Exists("launcherconfig/skrillconfig/ServerpathData.txt"))
                        {
                            String ServerpathFile = File.ReadAllText("launcherconfig/skrillconfig/ServerpathData.txt");
                            String clientpathFile = File.ReadAllText("launcherconfig/skrillconfig/ClientpathData.txt");
                            Serverpath = ServerpathFile;
                            Serverpath_Input.Text = ServerpathFile;
                        }
                        else if (!File.Exists("launcherconfig/skrillconfig/ServerpathData.txt"))
                        {
                            Serverpath = "";
                            Serverpath_Input.Text = "";
                            File.WriteAllText("launcherconfig/skrillconfig/ServerpathData.txt", "");
                        }
                        if (File.Exists("launcherconfig/skrillconfig/ClientpathData.txt"))
                        {
                            String ServerpathFile = File.ReadAllText("launcherconfig/skrillconfig/ServerpathData.txt");
                            String clientpathFile = File.ReadAllText("launcherconfig/skrillconfig/ClientpathData.txt");
                            Clientpath = clientpathFile;
                            Clientpath_Input.Text = clientpathFile;
                        }
                        else if (!File.Exists("launcherconfig/skrillconfig/ClientpathData.txt"))
                        {
                            Clientpath = "";
                            Clientpath_Input.Text = "";
                            File.WriteAllText("launcherconfig/skrillconfig/ClientpathData.txt", "");
                        }
                    }
                }
                else if (Directory.Exists("launcherconfig/skrillconfig"))
                {
                    if (!File.Exists("launcherconfig/skrillconfig/MMOData.txt"))
                    {
                        File.WriteAllText("launcherconfig/skrillconfig/MMOData.txt", "false");
                    }
                    else if (File.Exists("launcherconfig/skrillconfig/MMOData.txt"))
                    {
                        String MMOFILE = File.ReadAllText("launcherconfig/skrillconfig/MMOData.txt");
                        if (MMOFILE == "true")
                        {
                            mmoOption.Checked = true;
                        }
                        else if (MMOFILE == "false")
                        {
                            mmoOption.Checked = false;
                        }
                    }
                    if (File.Exists("launcherconfig/skrillconfig/ServerpathData.txt"))
                    {
                        String ServerpathFile = File.ReadAllText("launcherconfig/skrillconfig/ServerpathData.txt");
                        String clientpathFile = File.ReadAllText("launcherconfig/skrillconfig/ClientpathData.txt");
                        Serverpath = ServerpathFile;
                        Serverpath_Input.Text = ServerpathFile;
                    }
                    else if (!File.Exists("launcherconfig/skrillconfig/ServerpathData.txt"))
                    {
                        Serverpath = "";
                        Serverpath_Input.Text = "";
                        File.WriteAllText("launcherconfig/skrillconfig/ServerpathData.txt", "");
                    }
                    if (File.Exists("launcherconfig/skrillconfig/ClientpathData.txt"))
                    {
                        String ServerpathFile = File.ReadAllText("launcherconfig/skrillconfig/ServerpathData.txt");
                        String clientpathFile = File.ReadAllText("launcherconfig/skrillconfig/ClientpathData.txt");
                        Clientpath = clientpathFile;
                        Clientpath_Input.Text = clientpathFile;
                    }
                    else if (!File.Exists("launcherconfig/skrillconfig/ClientpathData.txt"))
                    {
                        Clientpath = "";
                        Clientpath_Input.Text = "";
                        File.WriteAllText("launcherconfig/skrillconfig/ClientpathData.txt", "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

    private void mmoOption_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("launcherconfig/skrillconfig/MMOData.txt"))
                {
                    if (mmoOption.Checked == true)
                    {
                        File.WriteAllText("launcherconfig/skrillconfig/MMOData.txt", "true");
                    }
                    else if (mmoOption.Checked == false)
                    {
                        File.WriteAllText("launcherconfig/skrillconfig/MMOData.txt", "false");
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show("" +  ec.Message);
            }
        }
    }
}