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

namespace Nuix.ActivityTemplates.PSTPusherNode
{
    public partial class PSTPusherNode : UserControl
    {
        private PSTPusherNode() { }
        private NuixCommandConsole NuixCommandConsole;
        public PSTPusherNode(NuixCommandConsole NuixCommandConsole)
        {
            InitializeComponent();
            this.NuixCommandConsole = NuixCommandConsole;
            LoadFromConfig();
        }

        private void PSTPusherExecuteButton_Click(object sender, EventArgs e)
        {
            Save();
            NuixCommandConsole.StartActivity(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\Process PSTs to EWS_config.bat", "", O365PSTPusherRichTextBox);
        }

        private void NuixO365PstPusherBrowseForMappingFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "CSV File (*.csv)|*.csv";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.NuixO365PstPusherMappingFileTextBox.Text = ofd.FileName;
            }
        }

        private void NuixO365PstPusherBrowseForExportDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (string.IsNullOrEmpty(this.NuixO365PstPusherExportDirectoryTextBox.Text))
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                fbd.SelectedPath = this.NuixO365PstPusherExportDirectoryTextBox.Text;
            if (!Directory.Exists(fbd.SelectedPath))
            {
                Directory.CreateDirectory(fbd.SelectedPath);
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.NuixO365PstPusherExportDirectoryTextBox.Text = fbd.SelectedPath;
            }
        }

        private void NuixO365PstPusherCasePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (string.IsNullOrEmpty(this.NuixO365PstPusherCasePathTextBox.Text))
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                fbd.SelectedPath = this.NuixO365PstPusherCasePathTextBox.Text;
            if (!Directory.Exists(fbd.SelectedPath))
            {
                Directory.CreateDirectory(fbd.SelectedPath);
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.NuixO365PstPusherCasePathTextBox.Text = fbd.SelectedPath;
            }
        }

        private void LoadFromConfig()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\PstPusher.save"))
            {
                foreach (string row in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\PstPusher.save"))
                {
                    string key = row.Substring(0, row.IndexOf("="));
                    string value = row.Substring(row.IndexOf("=") + 1);
                    switch (key)
                    {
                        case "MappingFile":
                            this.NuixO365PstPusherMappingFileTextBox.Text = value;
                        break;
                        case "ExportDirectory":
                            this.NuixO365PstPusherExportDirectoryTextBox.Text = value;
                        break;
                        case "RunName":
                            this.NuixO365PstPusherRunNameTextBox.Text = value;
                        break;
                        case "CasePath":
                            this.NuixO365PstPusherCasePathTextBox.Text = value;
                        break;
                        case "NuixWorkers":
                            this.NuixO365PstPusherNuixWorkersTextBox.Text = value;
                        break;
                        case "ApplicationMemory":
                            this.NuixO365PstPusherApplicationMemoryTextBox.Text = value;
                        break;
                        case "WorkerMemory":
                            this.NuixO365PstPusherWorkerMemoryTextBox.Text = value;
                        break;
                        case "MaintainSourceFolderStructure":
                            if(bool.Parse(value))
                                this.NuixO365PstPusherMaintainSourceFolderStructureCheckBox.CheckState = CheckState.Checked;
                            else
                                this.NuixO365PstPusherMaintainSourceFolderStructureCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "IsEnterpriseSourceData":
                            if(bool.Parse(value))
                                this.NuixO365PstPusherEnterpriseVaultSourceDataCheckBox.CheckState = CheckState.Checked;
                            else
                                this.NuixO365PstPusherEnterpriseVaultSourceDataCheckBox.CheckState = CheckState.Unchecked;
                        break;
                        case "ServiceAccountConfiguredForImpersonation":
                        if (bool.Parse(value))
                            this.NuixO365PstPusherServiceAccountIsConfiguredForImpersonationCheckBox.CheckState = CheckState.Checked;
                        else
                            this.NuixO365PstPusherServiceAccountIsConfiguredForImpersonationCheckBox.CheckState = CheckState.Unchecked;
                        break;
                    }
                }
            }
        }

        private void NuixO365PstPusherSaveConfigurationsButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private Dictionary<string, string> Save()
        {
            string InvocationTimeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("MappingFile", NuixO365PstPusherMappingFileTextBox.Text);
            parameters.Add("ExportDirectory", this.NuixO365PstPusherExportDirectoryTextBox.Text);
            parameters.Add("RunName", NuixO365PstPusherRunNameTextBox.Text);
            parameters.Add("CasePath", NuixO365PstPusherCasePathTextBox.Text);
            parameters.Add("NuixWorkers", NuixO365PstPusherNuixWorkersTextBox.Text);
            parameters.Add("ApplicationMemory", NuixO365PstPusherApplicationMemoryTextBox.Text);
            parameters.Add("WorkerMemory", NuixO365PstPusherWorkerMemoryTextBox.Text);
            parameters.Add("MaintainSourceFolderStructure", NuixO365PstPusherMaintainSourceFolderStructureCheckBox.Checked.ToString());
            parameters.Add("IsEnterpriseSourceData", NuixO365PstPusherEnterpriseVaultSourceDataCheckBox.Checked.ToString());
            parameters.Add("ServiceAccountConfiguredForImpersonation", NuixO365PstPusherServiceAccountIsConfiguredForImpersonationCheckBox.Checked.ToString());
            string[] save = new string[] { 
                "MappingFile=" + parameters["MappingFile"],
                "ExportDirectory=" + parameters["ExportDirectory"],
                "RunName=" + parameters["RunName"],
                "CasePath=" + parameters["CasePath"],
                "NuixWorkers=" + parameters["NuixWorkers"],
                "ApplicationMemory=" + parameters["ApplicationMemory"],
                "WorkerMemory=" + parameters["WorkerMemory"],
                "MaintainSourceFolderStructure=" + parameters["MaintainSourceFolderStructure"],
                "IsEnterpriseSourceData=" + parameters["IsEnterpriseSourceData"],
                "ServiceAccountConfiguredForImpersonation=" + parameters["ServiceAccountConfiguredForImpersonation"]
            };
            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\PstPusher.save", save);
            List<string> bat = new List<string>();
            foreach (string row in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\Process PSTs to EWS_config.bat.template"))
            {
                string updated;
                if (row.Contains("[NuixWorkstationDirectory]"))
                    updated = row + " " + NuixCommandConsole.GetNuixLicense();
                else
                    continue;
                updated = updated.Replace("[NuixWorkstationDirectory]", NuixCommandConsole.GetNuixWorkstationDirectory());
                updated = updated.Replace("[ApplicationMemory]", parameters["ApplicationMemory"]);
                updated = updated.Replace("[NuixLogDir]", NuixCommandConsole.GetNuixLogDirectory() + "\\" + this.NuixO365PstPusherRunNameTextBox.Text + "-" + InvocationTimeStamp);
                updated = updated.Replace("[NuixTempDir]", NuixCommandConsole.GetNuixTempDirectory());
                updated = updated.Replace("[MappingFile]", parameters["MappingFile"]);
                updated = updated.Replace("[ExportDirectory]", parameters["ExportDirectory"] + "\\" + this.NuixO365PstPusherRunNameTextBox.Text + "-" + InvocationTimeStamp);
                updated = updated.Replace("[MaintainSourceFolderStructure]", parameters["MaintainSourceFolderStructure"]);
                updated = updated.Replace("[ServiceAccountConfiguredForImpersonation]", parameters["ServiceAccountConfiguredForImpersonation"]);
                if (bool.Parse(parameters["IsEnterpriseSourceData"]))
                    updated = updated.Replace("[EnterpriseValueSourceData]", "2");
                else
                    updated = updated.Replace("[EnterpriseValueSourceData]", "1");
                bat.Add(updated);
            }
            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\Process PSTs to EWS_config.bat", bat);

            List<string> SystemProperties = new List<string>();
            foreach (string row in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\System_Properties.rb_.template"))
            {
                string updated = row.Replace("[RUNNAME]", parameters["RunName"]);
                updated = updated.Replace("[CASEPATH]", parameters["CasePath"]);
                updated = updated.Replace("[WORKERCOUNT]", parameters["NuixWorkers"]);
                updated = updated.Replace("[WORKERMEMORY]", parameters["WorkerMemory"]);
                updated = updated.Replace("[WORKERTEMP]", NuixCommandConsole.GetNuixTempDirectory());
                SystemProperties.Add(updated);
            }
            System.IO.File.WriteAllLines(Directory.GetCurrentDirectory() + "\\ActivityTemplates\\PSTPusherNode\\System_Properties.rb_", SystemProperties);

            return parameters;
        }
    }
}
