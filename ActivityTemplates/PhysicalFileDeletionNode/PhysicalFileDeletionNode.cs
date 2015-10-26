using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuix.ActivityTemplates.PhysicalFileDeletionNode
{
    public partial class PhysicalFileDeletionNode : UserControl
    {
        private PhysicalFileDeletionNode() { }
        private NuixCommandConsole NuixCommandConsole;
        public PhysicalFileDeletionNode(NuixCommandConsole NuixCommandConsole)
        {
            InitializeComponent();
            this.NuixCommandConsole = NuixCommandConsole;
            LoadFromConfig();
        }

        private void rootCasesDirectoryBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (string.IsNullOrEmpty(RootCasesDirectoryTextBox.Text))
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                fbd.SelectedPath = RootCasesDirectoryTextBox.Text;
            if (!Directory.Exists(fbd.SelectedPath))
            {
                Directory.CreateDirectory(fbd.SelectedPath);
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                RootCasesDirectoryTextBox.Text = fbd.SelectedPath;
            }
        }

        private void OutputDirectoryBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (string.IsNullOrEmpty(OutputDirectoryTextBox.Text))
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                fbd.SelectedPath = OutputDirectoryTextBox.Text;
            if (!Directory.Exists(fbd.SelectedPath))
            {
                Directory.CreateDirectory(fbd.SelectedPath);
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                OutputDirectoryTextBox.Text = fbd.SelectedPath;
            }
        }

        private void CollectorExecutableBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "EXE File (*.exe)|*.exe";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.CollectorExecutableTextBox.Text = ofd.FileName;
            }
        }

        private void SendNotificationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SendNotificationsCheckBox.Checked)
            {
                SendNotificationsTextBox.Enabled = true;
            }
            else
            {
                SendNotificationsTextBox.Enabled = false;
            }
        }

        private void SaveConfigurationButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void DeleteFilesButton_Click(object sender, EventArgs e)
        {
            Save();
            NuixCommandConsole.StartActivity(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PhysicalFileDeletionNode\\PhysicalFileDeletionNode.bat", "", OutputRichTextBox);
        }

        private Dictionary<string, string> Save()
        {
            string InvocationTimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("RootCasesDirectory", RootCasesDirectoryTextBox.Text);
            parameters.Add("OutputDirectory", OutputDirectoryTextBox.Text);
            parameters.Add("CollectorExecutable", CollectorExecutableTextBox.Text);
            parameters.Add("Scope", ScopeTextBox.Text);
            parameters.Add("VerificationOne", VerificationOneCheckBox.Checked.ToString());
            parameters.Add("Username", UsernameTextBox.Text);
            parameters.Add("Domain", DomainTextBox.Text);
            parameters.Add("Password", PasswordTextBox.Text);
            parameters.Add("ScrambleCreationDate", ScrambleCreationDateCheckBox.Checked.ToString());
            parameters.Add("ScrambleAccessDate", ScrambleAccessDateCheckBox.Checked.ToString());
            parameters.Add("ScrambleModificationDate", ScrambleModificationDateCheckbox.Checked.ToString());
            parameters.Add("DeleteFolders", DeleteFoldersCheckBox.Checked.ToString());
            parameters.Add("OverwriteCount", OverwriteCountComboBox.GetItemText(OverwriteCountComboBox.SelectedItem));
            parameters.Add("VerificationTwo", VerificationTwoCheckBox.Checked.ToString());
            parameters.Add("VerifyCreationDate", VerifyCreationDateCheckBox.Checked.ToString());
            parameters.Add("VerifySize", VerifySizeCheckBox.Checked.ToString());
            parameters.Add("VerifyModificationDate", VerifyModificationDateCheckBox.Checked.ToString());
            parameters.Add("VerifyMD5Hash", VerifyMD5HashCheckBox.Checked.ToString());
            parameters.Add("VerifyAccessDate", VerifyAccessDateCheckBox.Checked.ToString());
            parameters.Add("ValidateJobFileXML", ValidateJobFileXMLCheckBox.Checked.ToString());
            parameters.Add("SendNotifications", SendNotificationsCheckBox.Checked.ToString());
            parameters.Add("NotificationTargets", SendNotificationsTextBox.Text);

            string [] save = new string [] { 
                "RootCasesDirectory=" + parameters["RootCasesDirectory"],
                "OutputDirectory=" + parameters["OutputDirectory"],
                "CollectorExecutable=" + parameters["CollectorExecutable"],
                "Scope=" + parameters["Scope"],
                "VerificationOne=" + parameters["VerificationOne"],
                "Username=" + parameters["Username"],
                "Domain=" + parameters["Domain"],
                "Password=" + System.Convert.ToBase64String(Encoding.ASCII.GetBytes(parameters["Password"])),
                "ScrambleCreationDate=" + parameters["ScrambleCreationDate"],
                "ScrambleAccessDate=" + parameters["ScrambleAccessDate"],
                "ScrambleModificationDate=" + parameters["ScrambleModificationDate"],
                "DeleteFolders=" + parameters["DeleteFolders"],
                "OverwriteCount=" + parameters["OverwriteCount"],
                "VerificationTwo=" + parameters["VerificationTwo"],
                "VerifyCreationDate=" + parameters["VerifyCreationDate"],
                "VerifySize=" + parameters["VerifySize"],
                "VerifyModificationDate=" + parameters["VerifyModificationDate"],
                "VerifyMD5Hash=" + parameters["VerifyMD5Hash"],
                "VerifyAccessDate=" + parameters["VerifyAccessDate"],
                "ValidateJobFileXML=" + parameters["ValidateJobFileXML"],
                "SendNotifications=" + parameters["SendNotifications"],
                "NotificationTargets=" + parameters["NotificationTargets"]
            };
            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PhysicalFileDeletionNode\\PhysicalFileDeletionNode.save", save);

            string JobFileTemplate = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PhysicalFileDeletionNode\\DefensibleForensicDeletionTemplate.xml");
            JobFileTemplate = JobFileTemplate.Replace("~OVERWRITECOUNT~", parameters["OverwriteCount"])
                                             .Replace("~SCRAMBLECREATIONDATE~", YesOrNo(bool.Parse(parameters["ScrambleCreationDate"])))
                                             .Replace("~SCRAMBLEMODIFICATIONDATE~", YesOrNo(bool.Parse(parameters["ScrambleModificationDate"])))
                                             .Replace("~SCRAMBLEACCESSDATE~", YesOrNo(bool.Parse(parameters["ScrambleAccessDate"])))
                                             .Replace("~DELETEFOLDERS~", YesOrNo(bool.Parse(parameters["DeleteFolders"])))
                                             .Replace("~OUTPUTLOGDIRECTORY~", parameters["OutputDirectory"] + "\\" + InvocationTimeStamp);
            string JobFileInstance = Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PhysicalFileDeletionNode\\DefensibleForensicDeletion" + InvocationTimeStamp + ".xml";
            System.IO.File.WriteAllText(JobFileInstance, JobFileTemplate, Encoding.GetEncoding("UTF-8"));

            Dictionary<string, string> licenseInfo = GetNuixLicenseInfo();

            string [] bat = new string [] {
                "@echo OFF",
                "echo RootCasesDirectory=" + parameters["RootCasesDirectory"],
                "echo OutputDirectory=" + parameters["OutputDirectory"],
                "echo CollectorExecutable=" + parameters["CollectorExecutable"],
                "echo Scope=" + parameters["Scope"],
                "echo VerificationOne=" + parameters["VerificationOne"],
                "echo Username=" + parameters["Username"],
                "echo Domain=" + parameters["Domain"],
                "echo Password(Encrypted)=" + System.Convert.ToBase64String(Encoding.ASCII.GetBytes(parameters["Password"])),
                "echo ScrambleCreationDate=" + parameters["ScrambleCreationDate"],
                "echo ScrambleAccessDate=" + parameters["ScrambleAccessDate"],
                "echo ScrambleModificationDate=" + parameters["ScrambleModificationDate"],
                "echo DeleteFolders=" + parameters["DeleteFolders"],
                "echo OverwriteCount=" + parameters["OverwriteCount"],
                "echo VerificationTwo=" + parameters["VerificationTwo"],
                "echo VerifyCreationDate=" + parameters["VerifyCreationDate"],
                "echo VerifySize=" + parameters["VerifySize"],
                "echo VerifyModificationDate=" + parameters["VerifyModificationDate"],
                "echo VerifyMD5Hash=" + parameters["VerifyMD5Hash"],
                "echo VerifyAccessDate=" + parameters["VerifyAccessDate"],
                "echo ValidateJobFileXML=" + parameters["ValidateJobFileXML"],
                "echo SendNotifications=" + parameters["SendNotifications"],
                "echo NotificationTargets=" + parameters["NotificationTargets"],
                "\"" + NuixCommandConsole.GetNuixWorkstationDirectory() + "\\jre\\bin\\java.exe\" -cp \"" + Directory.GetCurrentDirectory() + "\";.\\nuix-command-console.jar;\"" + NuixCommandConsole.GetNuixEngineDirectory() + "\\lib\\*\"  com.nuix.cc.collector.PhysicalFileDeletion \"" + parameters["RootCasesDirectory"] +"\" \"" 
                        + parameters["OutputDirectory"] +"\" \"" 
                        + licenseInfo["licensesourcetype"] +"\" \"" 
                        + licenseInfo["licencesourcelocation"] +"\" \"" 
                        + licenseInfo["licencetype"] +"\" \"" 
                        + licenseInfo["nms.username"] +"\" \"" 
                        + licenseInfo["nms.password"] +"\" \""
                        + InvocationTimeStamp +"\" \""
                        + parameters["Scope"] +"\" \""
                        + parameters["CollectorExecutable"] +"\" \""
                        + JobFileInstance +"\" \" -Dnuix.registry.servers=\"" 
                        + NuixCommandConsole.getNuixManagementServerRegistryServers() 
                        + "\" -Djava.io.tmpdir=\"" 
                        + licenseInfo["java.io.tmpdir"] 
                        + "\" -Dnuix.logdir=\"" 
                        + licenseInfo["nuix.logdir"] 
                        + "\" -Dnuix.loglevel=\"" 
                        + licenseInfo["nuix.loglevel"] + "\""
            };
            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PhysicalFileDeletionNode\\PhysicalFileDeletionNode.bat", bat);
            return parameters;
        }

        public static IEnumerable<string> GetFileList(string fileSearchPattern, string rootFolderPath)
        {
            Queue<string> pending = new Queue<string>();
            pending.Enqueue(rootFolderPath);
            string[] tmp;
            while (pending.Count > 0)
            {
                rootFolderPath = pending.Dequeue();
                tmp = Directory.GetFiles(rootFolderPath, fileSearchPattern);
                for (int i = 0; i < tmp.Length; i++)
                {
                    yield return tmp[i];
                }
                tmp = Directory.GetDirectories(rootFolderPath);
                for (int i = 0; i < tmp.Length; i++)
                {
                    pending.Enqueue(tmp[i]);
                }
            }
        }

        private string YesOrNo(bool b)
        {
            if (b)
                return "yes";
            else
                return "no";
        }

        private Dictionary<string, string> GetNuixLicenseInfo()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            if (File.Exists(Directory.GetCurrentDirectory() + "\\NuixCommandConsole.cfg"))
            {
                foreach (string row in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\NuixCommandConsole.cfg"))
                {
                    string key = row.Substring(0, row.IndexOf("="));
                    string value = row.Substring(row.IndexOf("=") + 1);
                    switch (key)
                    {
                        case "NUIXTEMPDIRECTORY":
                            info.Add("java.io.tmpdir", value);
                            break;
                        case "NUIXLOGDIR":
                            info.Add("nuix.logdir", value);
                        break;
                        case "NUIXLOGLEVEL":
                            info.Add("nuix.loglevel", value);
                        break;
                        case "NUIXLICENSE":
                            string [] split = value.Split(' ');
                            info.Add("licensesourcetype", split[1]);
                            info.Add("licencesourcelocation", split[3]);
                            info.Add("licencetype", split[5]);
                        break;
                        case "NUIX_USERNAME":
                            info.Add("nms.username", value);
                        break;
                        case "NUIX_PASSWORD":
                            info.Add("nms.password", Encoding.ASCII.GetString(System.Convert.FromBase64String(value)));
                        break;
                    }
                }
            }
            return info;
        }

        private void LoadFromConfig()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PhysicalFileDeletionNode\\PhysicalFileDeletionNode.save"))
            {
                foreach (string row in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PhysicalFileDeletionNode\\PhysicalFileDeletionNode.save"))
                {
                    string key = row.Substring(0, row.IndexOf("="));
                    string value = row.Substring(row.IndexOf("=") + 1);
                    switch (key)
                    {            
                        case "RootCasesDirectory":
                            this.RootCasesDirectoryTextBox.Text = value;
                        break;
                        case "OutputDirectory":
                            this.OutputDirectoryTextBox.Text = value;
                        break;
                        case "CollectorExecutable":
                            this.CollectorExecutableTextBox.Text = value;
                        break;
                        case "Scope":
                            this.ScopeTextBox.Text = value;
                        break;
                        case "VerificationOne":
                            if (bool.Parse(value))
                                this.VerificationOneCheckBox.CheckState = CheckState.Checked;
                            else
                                this.VerificationOneCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "Username":
                            this.UsernameTextBox.Text = value;
                            break;
                        case "Domain":
                            this.DomainTextBox.Text = value;
                        break;
                        case "Password":
                            this.PasswordTextBox.Text = Encoding.ASCII.GetString(System.Convert.FromBase64String(value));
                        break;
                        case "ScrambleCreationDate":
                            if (bool.Parse(value))
                                this.ScrambleCreationDateCheckBox.CheckState = CheckState.Checked;
                            else
                                this.ScrambleCreationDateCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "ScrambleAccessDate":
                            if (bool.Parse(value))
                                this.ScrambleAccessDateCheckBox.CheckState = CheckState.Checked;
                            else
                                this.ScrambleAccessDateCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "ScrambleModificationDate":
                            if (bool.Parse(value))
                                this.ScrambleModificationDateCheckbox.CheckState = CheckState.Checked;
                            else
                                this.ScrambleModificationDateCheckbox.CheckState = CheckState.Unchecked;
                        break;
                        case "DeleteFolders":
                            if (bool.Parse(value))
                                this.DeleteFoldersCheckBox.CheckState = CheckState.Checked;
                            else
                                this.DeleteFoldersCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "OverwriteCount":
                            this.OverwriteCountComboBox.SelectedIndex = this.OverwriteCountComboBox.Items.IndexOf(value);
                        break;
                        case "VerificationTwo":
                            if (bool.Parse(value))
                                this.VerificationTwoCheckBox.CheckState = CheckState.Checked;
                            else
                                this.VerificationTwoCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "VerifyCreationDate":
                            if (bool.Parse(value))
                                this.VerifyCreationDateCheckBox.CheckState = CheckState.Checked;
                            else
                                this.VerifyCreationDateCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "VerifySize":
                            if (bool.Parse(value))
                                this.VerifySizeCheckBox.CheckState = CheckState.Checked;
                            else
                                this.VerifySizeCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "VerifyModificationDate":
                            if (bool.Parse(value))
                                this.VerifyModificationDateCheckBox.CheckState = CheckState.Checked;
                            else
                                this.VerifyModificationDateCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "VerifyMD5Hash":
                            if (bool.Parse(value))
                                this.VerifyMD5HashCheckBox.CheckState = CheckState.Checked;
                            else
                                this.VerifyMD5HashCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "VerifyAccessDate":
                            if (bool.Parse(value))
                                this.VerifyAccessDateCheckBox.CheckState = CheckState.Checked;
                            else
                                this.VerifyAccessDateCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "ValidateJobFileXML":
                            if (bool.Parse(value))
                                this.ValidateJobFileXMLCheckBox.CheckState = CheckState.Checked;
                            else
                                this.ValidateJobFileXMLCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "SendNotifications":
                            if (bool.Parse(value))
                                this.SendNotificationsCheckBox.CheckState = CheckState.Checked;
                            else
                                this.SendNotificationsCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "NotificationTargets":
                            this.SendNotificationsTextBox.Text = value;
                        break;
                    }
                }
            }
        }
    }
}
