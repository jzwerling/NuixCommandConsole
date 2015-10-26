using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuix
{
    public partial class NuixCommandConsole : Form
    {
        private RichTextBox ActiveOutput;
        private static string TIMESTAMP = DateTime.Now.ToString("yyyyMMddHHmmss");
        private static string USERPROFILE = Environment.GetEnvironmentVariable("USERPROFILE");
        private static string NUIXTEMPDIRECTORY = USERPROFILE + "\\AppData\\Local\\Temp\\Nuix";
        private static string NUIXLOGDIR = USERPROFILE + "\\AppData\\Local\\Nuix\\Logs";
        private static string NUIXWORKSTATIONDIRECTORY = "C:\\Program Files\\Nuix\\Nuix 6.2";
        private static string NUIXENGINEDIRECTORY = "C:\\Development\\Nuix-Engine\\6.2";
        private static string NUIXLOGLEVEL = "INFO";
        private static string NUIXLICENSE = "";
        private static string NUIX_USERNAME = "";
        private static string NUIX_PASSWORD = "";

        public NuixCommandConsole()
        {
            InitializeComponent();
            LoadFromConfig();
            ActivityTree.ExpandAll();
        }

        public void EnableUI()
        {
            Tabs.Enabled = true;
        }

        public void DisableUI()
        {
            Tabs.Enabled = false;
        }

        public string GetNuixLogDirectory()
        {
            return NUIXLOGDIR;
        }

        public string getNuixManagementServerRegistryServers()
        {
            return NuixManagementServerRegistryServersSystemProperty.Text;
        }

        public string GetNuixWorkstationDirectory()
        {
            return NUIXWORKSTATIONDIRECTORY;
        }

        public string GetNuixEngineDirectory()
        {
            return NUIXENGINEDIRECTORY;
        }

        public string GetNuixTempDirectory()
        {
            return NUIXTEMPDIRECTORY;
        }

        public string GetNuixLicense()
        {
            return NUIXLICENSE;
        }

        public void StartActivity(string FileName, String Arguments, RichTextBox Output)
        {
            ActivityArguments arguments = new ActivityArguments();
            arguments.FileName = FileName;
            arguments.Arguments = Arguments;
            ActiveOutput = Output;
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                worker.DoWork += new DoWorkEventHandler(Work);
                worker.ProgressChanged += new ProgressChangedEventHandler(Progress);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Done);
                if (!worker.IsBusy)
                {
                    worker.RunWorkerAsync(arguments);
                }
            }
        }

        private void Work(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() => { 
                DisableUI();
                if (ActiveOutput != null)
                    ActiveOutput.Enabled = true;
            }));
            ActivityArguments arguments = (ActivityArguments) e.Argument;
            this.BeginInvoke(new MethodInvoker(() => { 
                ActiveOutput.Clear();
                string s = "Current working directory is " + Directory.GetCurrentDirectory() + "." + Environment.NewLine;
                ActiveOutput.AppendText(s);
            }));
            /*
            string executable = NUIXWORKSTATIONDIRECTORY;
            if (arguments.Type == "java")
            {
                executable = executable + "\\jre\\bin\\java.exe";
            }
            else
            {
                executable = executable + "\\nuix_console.exe";
            }
             */
            using (Process process = new Process())
            {
                //this.BeginInvoke(new MethodInvoker(() => { ActiveOutput.AppendText("Preparing to invoke " + "\"" + arguments.FileName + "\" " + arguments.Arguments + Environment.NewLine); }));
                process.StartInfo.FileName = "\"" + arguments.FileName + "\"";
                process.StartInfo.Arguments = arguments.Arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.OutputDataReceived += Redirect;
                process.ErrorDataReceived += Redirect;
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
                process.WaitForExit();
            }
        }

        private void Progress(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
        }

        private void Done(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            this.BeginInvoke(new MethodInvoker(() => { EnableUI(); }));
        }

        public void Redirect(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != string.Empty)
            {
                this.BeginInvoke(new MethodInvoker(() => { 
                    ActiveOutput.AppendText(e.Data + Environment.NewLine);
                    ActiveOutput.ScrollToCaret();
                }));
            }
        }

        private void LoadFromConfig()
        {
            if (File.Exists("NuixCommandConsole.cfg"))
            {
                foreach (var row in File.ReadAllLines("NuixCommandConsole.cfg"))
                {
                    string key = row.Substring(0, row.IndexOf("="));
                    string value = row.Substring(row.IndexOf("=") + 1);
                    switch(key)
                    {
                        case "NUIXTEMPDIRECTORY":
                            NUIXTEMPDIRECTORY=value;
                            this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.Text = NUIXTEMPDIRECTORY;
                        break;
                        case "NUIXLOGDIR":
                            NUIXLOGDIR = value;
                            this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.Text = NUIXLOGDIR;
                        break;
                        case "NUIXWORKSTATIONDIRECTORY":
                            NUIXWORKSTATIONDIRECTORY = value;
                            this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Text = NUIXWORKSTATIONDIRECTORY;
                        break;
                        case "NUIXENGINEDIRECTORY":
                            NUIXENGINEDIRECTORY = value;
                            this.LocalNuixEngineDirectoryTextBox.Text = NUIXENGINEDIRECTORY;
                        break;
                        case "NUIXLOGLEVEL":
                            NUIXLOGLEVEL = value;
                            this.LocalEnvironmentSettingsLocalLogLevelComboBox.SelectedItem = NUIXLOGLEVEL;
                        break;
                        case "NUIX_PASSWORD":
                            NUIX_PASSWORD = Encoding.ASCII.GetString(System.Convert.FromBase64String(value));
                            this.NuixManagementServerPassword.Text = NUIX_PASSWORD;
                        break;
                        case "NUIX_USERNAME":
                            NUIX_USERNAME = value;
                            this.NuixManagementServerUsername.Text = NUIX_USERNAME;
                        break;
                        case "NUIXLICENSE":
                            NUIXLICENSE = value;
                            if(!this.AvailableNuixLicenseComboBox.Items.Contains(NUIXLICENSE))
                            {
                                this.AvailableNuixLicenseComboBox.Items.Add(NUIXLICENSE);
                            }
                            this.AvailableNuixLicenseComboBox.SelectedItem = NUIXLICENSE;
                        break;
                    }
                }
            } 
            else 
            {
                ApplyDefaultSettings();
                SaveSettings();
            }
        }

        private void ActivityTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ActivitiesSplitContainer.Panel2.Controls.Clear();
            Type type = Type.GetType("Nuix.ActivityTemplates." + ActivityTree.SelectedNode.Name + "." + ActivityTree.SelectedNode.Name);
            object obj = Activator.CreateInstance(type, this);
            ActivitiesSplitContainer.Panel2.Controls.Add((Control) obj);
            ActivitiesSplitContainer.Panel2.Controls[0].Dock = DockStyle.Fill;
            UserControl control = (UserControl)ActivitiesSplitContainer.Panel2.Controls[0];
            control.AutoScroll = true;
        }

        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SettingsRestoreDefaultsButton_Click(object sender, EventArgs e)
        {
            ApplyDefaultSettings();
        }

        private void SaveSettings()
        {
            NUIXTEMPDIRECTORY = this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.Text;
            NUIXLOGDIR = this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.Text;
            NUIXWORKSTATIONDIRECTORY = this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Text;
            NUIXENGINEDIRECTORY = this.LocalNuixEngineDirectoryTextBox.Text;
            NUIXLOGLEVEL = (string)this.LocalEnvironmentSettingsLocalLogLevelComboBox.SelectedItem;
            NUIX_USERNAME = this.NuixManagementServerUsername.Text;
            NUIX_PASSWORD = this.NuixManagementServerPassword.Text;
            NUIXLICENSE = (string)this.AvailableNuixLicenseComboBox.SelectedItem;
            string[] cfg = {
                "NUIXTEMPDIRECTORY=" + NUIXTEMPDIRECTORY,
                "NUIXLOGDIR=" + NUIXLOGDIR,
                "NUIXWORKSTATIONDIRECTORY=" + NUIXWORKSTATIONDIRECTORY,
                "NUIXENGINEDIRECTORY=" + NUIXENGINEDIRECTORY,
                "NUIXLOGLEVEL=" + NUIXLOGLEVEL,
                "NUIX_USERNAME=" + NUIX_USERNAME,
                "NUIX_PASSWORD=" + System.Convert.ToBase64String(Encoding.ASCII.GetBytes(NUIX_PASSWORD)),
                "NUIXLICENSE=" + NUIXLICENSE
            };
            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "\\NuixCommandConsole.cfg", cfg);
        }

        private void ApplyDefaultSettings()
        {
            USERPROFILE = Environment.GetEnvironmentVariable("USERPROFILE");
            NUIXTEMPDIRECTORY = USERPROFILE + "\\AppData\\Local\\Temp\\Nuix";
            NUIXLOGDIR = USERPROFILE + "\\AppData\\Local\\Nuix\\Logs";
            NUIXWORKSTATIONDIRECTORY = "C:\\Program Files\\Nuix\\Nuix 6.2";
            NUIXENGINEDIRECTORY = "C:\\Development\\Nuix-Engine\\6.2";
            this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.Text = NUIXTEMPDIRECTORY;
            this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.Text = NUIXLOGDIR;
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Text = NUIXWORKSTATIONDIRECTORY;
            this.LocalNuixEngineDirectoryTextBox.Text = NUIXENGINEDIRECTORY;
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.SelectedIndex = 4;
        }

        private void LocalEnvironmentSettingsNuixWorkstationDirBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the location of the Nuix Workstation installation.";
            dialog.ShowNewFolderButton = false;
            dialog.SelectedPath = LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Text;
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Text = dialog.SelectedPath;
                NUIXWORKSTATIONDIRECTORY = dialog.SelectedPath;
            }
        }

        private void LocalNuixEngineDirectoryBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the location of the Nuix Engine installation.";
            dialog.ShowNewFolderButton = false;
            dialog.SelectedPath = LocalNuixEngineDirectoryTextBox.Text;
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                LocalNuixEngineDirectoryTextBox.Text = dialog.SelectedPath;
                NUIXENGINEDIRECTORY = dialog.SelectedPath;
            }
        }

        private void LocalEnvironmentSettingsLogDirBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the location of the log directory to be used for operations run locally.";
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.Text;
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                LocalEnvironmentSettingsLocalLogDirectoryTextBox.Text = dialog.SelectedPath;
                NUIXLOGDIR = dialog.SelectedPath;
            }
        }

        private void LocalEnvironmentSettingsTempDirBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the location of the temp directory to be used for operations run locally.";
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.Text;
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                LocalEnvironmentSettingsLocalTempDirectoryTextBox.Text = dialog.SelectedPath;
                NUIXTEMPDIRECTORY = dialog.SelectedPath;
            }
        }
        private void LocalEnvironmentSettingsLocalLogLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NUIXLOGLEVEL = (string)LocalEnvironmentSettingsLocalLogLevelComboBox.SelectedItem;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RefreshLicensesButton_Click(object sender, EventArgs e)
        {
            AvailableNuixLicenseComboBox.Items.Clear();
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                worker.DoWork += new DoWorkEventHandler(RefreshLicensesWork);
                worker.ProgressChanged += new ProgressChangedEventHandler(RefreshLicensesProgress);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RefreshLicensesDone);
                if (!worker.IsBusy)
                {
                    worker.RunWorkerAsync();
                }
            }
        }

        private void RefreshLicensesWork(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() => { DisableUI(); }));
            string executable = NUIXWORKSTATIONDIRECTORY + "\\jre\\bin\\java.exe";
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "\"" + executable + "\"";
                process.StartInfo.Arguments = "-cp \"" + Directory.GetCurrentDirectory() + "\";.\\nuix-command-console.jar;\"" + NUIXENGINEDIRECTORY + "\\lib\\*\" com.nuix.cc.OutputAvailableLicenses \"" + NuixManagementServerUsername.Text + "\" \"" + NuixManagementServerPassword + "\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.OutputDataReceived += RefreshLicensesRedirectStdOut;
                process.ErrorDataReceived += RefreshLicensesRedirectStdErr;
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
                process.WaitForExit();
            }
        }

        private void RefreshLicensesProgress(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
        }

        private void RefreshLicensesDone(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            this.BeginInvoke(new MethodInvoker(() => { EnableUI(); }));
        }

        public void RefreshLicensesRedirectStdOut(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data) && e.Data.StartsWith("-licencesourcetype"))
            {
                this.BeginInvoke(new MethodInvoker(() => { 
                    AvailableNuixLicenseComboBox.Items.Add(e.Data); 
                }));
            }
        }

        public void RefreshLicensesRedirectStdErr(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                //MessageBox.Show(e.Data);
            }
        }

        private void AvailableNuixLicenseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuixCommandConsole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nccDataSet.NuixRESTNodes' table. You can move, or remove it, as needed.
            this.nuixRESTNodesTableAdapter.Fill(this.nccDataSet.NuixRESTNodes);

        }
    }
}
