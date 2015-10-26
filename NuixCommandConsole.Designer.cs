namespace Nuix
{
    partial class NuixCommandConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("PST Pusher");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Intelligent Migration Activities", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Physical File Deletion");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Information Governance Activities", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Search");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("General Utilities", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Custom Script");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Taxonomy");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuixCommandConsole));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ActivitiesTab = new System.Windows.Forms.TabPage();
            this.ActivitiesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ActivityTree = new System.Windows.Forms.TreeView();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsTopSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SettingsTopNestedSplitContainer = new System.Windows.Forms.SplitContainer();
            this.LocalEnvironmentSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.LocalNuixEngineDirectoryBrowseButton = new System.Windows.Forms.Button();
            this.LocalNuixEngineDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.LocalNuixEngineDirectoryLabel = new System.Windows.Forms.Label();
            this.LocalEnvironmentSettingsTempDirBrowseButton = new System.Windows.Forms.Button();
            this.LocalEnvironmentSettingsLogDirBrowseButton = new System.Windows.Forms.Button();
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton = new System.Windows.Forms.Button();
            this.LocalEnvironmentSettingsLogLevelLabel = new System.Windows.Forms.Label();
            this.LocalEnvironmentSettingsLocalLogLevelComboBox = new System.Windows.Forms.ComboBox();
            this.LocalEnvironmentSettingsLocalTempDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.LocalEnvironmentSettingsLocalLogDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.LocalEnvironmentSettingsLocalTempDirectoryLabel = new System.Windows.Forms.Label();
            this.LocalEnvironmentSettingsNuixLogDirectoryLabel = new System.Windows.Forms.Label();
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel = new System.Windows.Forms.Label();
            this.RemoteOrchestrationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.remoteNuixRESTGrid = new System.Windows.Forms.DataGridView();
            this.remoteNodeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteNodeBaseUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteNodeUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteNodePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteNodeLicenseShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteNodeLicenseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteNodeWorkersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuixRESTNodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nccDataSet = new Nuix.nccDataSet();
            this.SettingsBottomNestedSplitContainer = new System.Windows.Forms.SplitContainer();
            this.LicenseSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NuixRegistryServerLabel = new System.Windows.Forms.Label();
            this.NuixManagementServerRegistryServersSystemProperty = new System.Windows.Forms.TextBox();
            this.RefreshLicensesButton = new System.Windows.Forms.Button();
            this.OptionalLabel1 = new System.Windows.Forms.Label();
            this.NuixManagementServerPasswordLabel = new System.Windows.Forms.Label();
            this.NuixManagementServerUsernameLabel = new System.Windows.Forms.Label();
            this.NuixManagementServerPassword = new System.Windows.Forms.TextBox();
            this.NuixManagementServerUsername = new System.Windows.Forms.TextBox();
            this.AvailableNuixLicensesLabel = new System.Windows.Forms.Label();
            this.AvailableNuixLicenseComboBox = new System.Windows.Forms.ComboBox();
            this.SettingsButtonsPanel = new System.Windows.Forms.Panel();
            this.SettingsRestoreDefaultsButton = new System.Windows.Forms.Button();
            this.SettingsSaveButton = new System.Windows.Forms.Button();
            this.DataClassificationTab = new System.Windows.Forms.TabPage();
            this.dataClassificationSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataClassificationTaxonomyTree = new System.Windows.Forms.TreeView();
            this.dataClassificationMenuStrip = new System.Windows.Forms.MenuStrip();
            this.dataClassificationTaxonomyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTaxonomyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataClassificationViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mimeTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditedSizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuixRESTNodesTableAdapter = new Nuix.nccDataSetTableAdapters.NuixRESTNodesTableAdapter();
            this.Tabs.SuspendLayout();
            this.ActivitiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivitiesSplitContainer)).BeginInit();
            this.ActivitiesSplitContainer.Panel1.SuspendLayout();
            this.ActivitiesSplitContainer.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTopSplitContainer)).BeginInit();
            this.SettingsTopSplitContainer.Panel1.SuspendLayout();
            this.SettingsTopSplitContainer.Panel2.SuspendLayout();
            this.SettingsTopSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTopNestedSplitContainer)).BeginInit();
            this.SettingsTopNestedSplitContainer.Panel1.SuspendLayout();
            this.SettingsTopNestedSplitContainer.Panel2.SuspendLayout();
            this.SettingsTopNestedSplitContainer.SuspendLayout();
            this.LocalEnvironmentSettingsGroupBox.SuspendLayout();
            this.RemoteOrchestrationSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remoteNuixRESTGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuixRESTNodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBottomNestedSplitContainer)).BeginInit();
            this.SettingsBottomNestedSplitContainer.Panel1.SuspendLayout();
            this.SettingsBottomNestedSplitContainer.Panel2.SuspendLayout();
            this.SettingsBottomNestedSplitContainer.SuspendLayout();
            this.LicenseSettingsGroupBox.SuspendLayout();
            this.SettingsButtonsPanel.SuspendLayout();
            this.DataClassificationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClassificationSplitContainer)).BeginInit();
            this.dataClassificationSplitContainer.Panel1.SuspendLayout();
            this.dataClassificationSplitContainer.Panel2.SuspendLayout();
            this.dataClassificationSplitContainer.SuspendLayout();
            this.dataClassificationMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ActivitiesTab);
            this.Tabs.Controls.Add(this.SettingsTab);
            this.Tabs.Controls.Add(this.DataClassificationTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(844, 853);
            this.Tabs.TabIndex = 0;
            // 
            // ActivitiesTab
            // 
            this.ActivitiesTab.BackColor = System.Drawing.SystemColors.Control;
            this.ActivitiesTab.Controls.Add(this.ActivitiesSplitContainer);
            this.ActivitiesTab.Location = new System.Drawing.Point(4, 25);
            this.ActivitiesTab.Name = "ActivitiesTab";
            this.ActivitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActivitiesTab.Size = new System.Drawing.Size(836, 824);
            this.ActivitiesTab.TabIndex = 0;
            this.ActivitiesTab.Text = "Activities";
            // 
            // ActivitiesSplitContainer
            // 
            this.ActivitiesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivitiesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.ActivitiesSplitContainer.Name = "ActivitiesSplitContainer";
            // 
            // ActivitiesSplitContainer.Panel1
            // 
            this.ActivitiesSplitContainer.Panel1.AutoScroll = true;
            this.ActivitiesSplitContainer.Panel1.Controls.Add(this.ActivityTree);
            // 
            // ActivitiesSplitContainer.Panel2
            // 
            this.ActivitiesSplitContainer.Panel2.AutoScroll = true;
            this.ActivitiesSplitContainer.Size = new System.Drawing.Size(830, 818);
            this.ActivitiesSplitContainer.SplitterDistance = 247;
            this.ActivitiesSplitContainer.TabIndex = 0;
            // 
            // ActivityTree
            // 
            this.ActivityTree.BackColor = System.Drawing.SystemColors.Control;
            this.ActivityTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivityTree.FullRowSelect = true;
            this.ActivityTree.Location = new System.Drawing.Point(0, 0);
            this.ActivityTree.Name = "ActivityTree";
            treeNode1.Name = "PSTPusherNode";
            treeNode1.Text = "PST Pusher";
            treeNode2.Name = "IntelligentMigrationActivitiesNode";
            treeNode2.Text = "Intelligent Migration Activities";
            treeNode3.Name = "PhysicalFileDeletionNode";
            treeNode3.Text = "Physical File Deletion";
            treeNode4.Name = "InformationGovernanceActivitiesNode";
            treeNode4.Text = "Information Governance Activities";
            treeNode5.Name = "SearchNode";
            treeNode5.Text = "Search";
            treeNode6.Name = "GeneralUtilitiesNode";
            treeNode6.Text = "General Utilities";
            treeNode7.Name = "CustomScriptActivityNode";
            treeNode7.Text = "Custom Script";
            this.ActivityTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode7});
            this.ActivityTree.Size = new System.Drawing.Size(247, 818);
            this.ActivityTree.TabIndex = 0;
            this.ActivityTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ActivityTree_AfterSelect);
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsTab.Controls.Add(this.SettingsTopSplitContainer);
            this.SettingsTab.Location = new System.Drawing.Point(4, 25);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(836, 570);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            // 
            // SettingsTopSplitContainer
            // 
            this.SettingsTopSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTopSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.SettingsTopSplitContainer.Name = "SettingsTopSplitContainer";
            this.SettingsTopSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SettingsTopSplitContainer.Panel1
            // 
            this.SettingsTopSplitContainer.Panel1.Controls.Add(this.SettingsTopNestedSplitContainer);
            // 
            // SettingsTopSplitContainer.Panel2
            // 
            this.SettingsTopSplitContainer.Panel2.Controls.Add(this.SettingsBottomNestedSplitContainer);
            this.SettingsTopSplitContainer.Size = new System.Drawing.Size(830, 564);
            this.SettingsTopSplitContainer.SplitterDistance = 366;
            this.SettingsTopSplitContainer.TabIndex = 5;
            // 
            // SettingsTopNestedSplitContainer
            // 
            this.SettingsTopNestedSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTopNestedSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SettingsTopNestedSplitContainer.Name = "SettingsTopNestedSplitContainer";
            this.SettingsTopNestedSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SettingsTopNestedSplitContainer.Panel1
            // 
            this.SettingsTopNestedSplitContainer.Panel1.Controls.Add(this.LocalEnvironmentSettingsGroupBox);
            // 
            // SettingsTopNestedSplitContainer.Panel2
            // 
            this.SettingsTopNestedSplitContainer.Panel2.Controls.Add(this.RemoteOrchestrationSettingsGroupBox);
            this.SettingsTopNestedSplitContainer.Size = new System.Drawing.Size(830, 366);
            this.SettingsTopNestedSplitContainer.SplitterDistance = 165;
            this.SettingsTopNestedSplitContainer.TabIndex = 0;
            // 
            // LocalEnvironmentSettingsGroupBox
            // 
            this.LocalEnvironmentSettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalNuixEngineDirectoryBrowseButton);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalNuixEngineDirectoryTextBox);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalNuixEngineDirectoryLabel);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsTempDirBrowseButton);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsLogDirBrowseButton);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsLogLevelLabel);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsLocalLogLevelComboBox);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsLocalTempDirectoryTextBox);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsLocalLogDirectoryTextBox);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsLocalTempDirectoryLabel);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsNuixLogDirectoryLabel);
            this.LocalEnvironmentSettingsGroupBox.Controls.Add(this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel);
            this.LocalEnvironmentSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalEnvironmentSettingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LocalEnvironmentSettingsGroupBox.Name = "LocalEnvironmentSettingsGroupBox";
            this.LocalEnvironmentSettingsGroupBox.Size = new System.Drawing.Size(830, 165);
            this.LocalEnvironmentSettingsGroupBox.TabIndex = 0;
            this.LocalEnvironmentSettingsGroupBox.TabStop = false;
            this.LocalEnvironmentSettingsGroupBox.Text = "Local Environment Settings";
            // 
            // LocalNuixEngineDirectoryBrowseButton
            // 
            this.LocalNuixEngineDirectoryBrowseButton.Location = new System.Drawing.Point(603, 48);
            this.LocalNuixEngineDirectoryBrowseButton.Name = "LocalNuixEngineDirectoryBrowseButton";
            this.LocalNuixEngineDirectoryBrowseButton.Size = new System.Drawing.Size(75, 27);
            this.LocalNuixEngineDirectoryBrowseButton.TabIndex = 12;
            this.LocalNuixEngineDirectoryBrowseButton.Text = "Browse";
            this.LocalNuixEngineDirectoryBrowseButton.UseVisualStyleBackColor = true;
            this.LocalNuixEngineDirectoryBrowseButton.Click += new System.EventHandler(this.LocalNuixEngineDirectoryBrowseButton_Click);
            // 
            // LocalNuixEngineDirectoryTextBox
            // 
            this.LocalNuixEngineDirectoryTextBox.Location = new System.Drawing.Point(250, 50);
            this.LocalNuixEngineDirectoryTextBox.Name = "LocalNuixEngineDirectoryTextBox";
            this.LocalNuixEngineDirectoryTextBox.Size = new System.Drawing.Size(347, 22);
            this.LocalNuixEngineDirectoryTextBox.TabIndex = 11;
            // 
            // LocalNuixEngineDirectoryLabel
            // 
            this.LocalNuixEngineDirectoryLabel.AutoSize = true;
            this.LocalNuixEngineDirectoryLabel.Location = new System.Drawing.Point(61, 55);
            this.LocalNuixEngineDirectoryLabel.Name = "LocalNuixEngineDirectoryLabel";
            this.LocalNuixEngineDirectoryLabel.Size = new System.Drawing.Size(182, 17);
            this.LocalNuixEngineDirectoryLabel.TabIndex = 10;
            this.LocalNuixEngineDirectoryLabel.Text = "Local Nuix Engine Directory";
            // 
            // LocalEnvironmentSettingsTempDirBrowseButton
            // 
            this.LocalEnvironmentSettingsTempDirBrowseButton.Location = new System.Drawing.Point(603, 135);
            this.LocalEnvironmentSettingsTempDirBrowseButton.Name = "LocalEnvironmentSettingsTempDirBrowseButton";
            this.LocalEnvironmentSettingsTempDirBrowseButton.Size = new System.Drawing.Size(75, 27);
            this.LocalEnvironmentSettingsTempDirBrowseButton.TabIndex = 9;
            this.LocalEnvironmentSettingsTempDirBrowseButton.Text = "Browse";
            this.LocalEnvironmentSettingsTempDirBrowseButton.UseVisualStyleBackColor = true;
            this.LocalEnvironmentSettingsTempDirBrowseButton.Click += new System.EventHandler(this.LocalEnvironmentSettingsTempDirBrowseButton_Click);
            // 
            // LocalEnvironmentSettingsLogDirBrowseButton
            // 
            this.LocalEnvironmentSettingsLogDirBrowseButton.Location = new System.Drawing.Point(603, 76);
            this.LocalEnvironmentSettingsLogDirBrowseButton.Name = "LocalEnvironmentSettingsLogDirBrowseButton";
            this.LocalEnvironmentSettingsLogDirBrowseButton.Size = new System.Drawing.Size(75, 27);
            this.LocalEnvironmentSettingsLogDirBrowseButton.TabIndex = 8;
            this.LocalEnvironmentSettingsLogDirBrowseButton.Text = "Browse";
            this.LocalEnvironmentSettingsLogDirBrowseButton.UseVisualStyleBackColor = true;
            this.LocalEnvironmentSettingsLogDirBrowseButton.Click += new System.EventHandler(this.LocalEnvironmentSettingsLogDirBrowseButton_Click);
            // 
            // LocalEnvironmentSettingsNuixWorkstationDirBrowseButton
            // 
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton.Location = new System.Drawing.Point(603, 19);
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton.Name = "LocalEnvironmentSettingsNuixWorkstationDirBrowseButton";
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton.Size = new System.Drawing.Size(75, 27);
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton.TabIndex = 0;
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton.Text = "Browse";
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton.UseVisualStyleBackColor = true;
            this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton.Click += new System.EventHandler(this.LocalEnvironmentSettingsNuixWorkstationDirBrowseButton_Click);
            // 
            // LocalEnvironmentSettingsLogLevelLabel
            // 
            this.LocalEnvironmentSettingsLogLevelLabel.AutoSize = true;
            this.LocalEnvironmentSettingsLogLevelLabel.Location = new System.Drawing.Point(173, 110);
            this.LocalEnvironmentSettingsLogLevelLabel.Name = "LocalEnvironmentSettingsLogLevelLabel";
            this.LocalEnvironmentSettingsLogLevelLabel.Size = new System.Drawing.Size(70, 17);
            this.LocalEnvironmentSettingsLogLevelLabel.TabIndex = 7;
            this.LocalEnvironmentSettingsLogLevelLabel.Text = "Log Level";
            // 
            // LocalEnvironmentSettingsLocalLogLevelComboBox
            // 
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.FormattingEnabled = true;
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.Items.AddRange(new object[] {
            "OFF",
            "FATAL",
            "ERROR",
            "WARN",
            "INFO",
            "DEBUG",
            "ALL"});
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.Location = new System.Drawing.Point(249, 107);
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.Name = "LocalEnvironmentSettingsLocalLogLevelComboBox";
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.Size = new System.Drawing.Size(121, 24);
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.TabIndex = 6;
            this.LocalEnvironmentSettingsLocalLogLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.LocalEnvironmentSettingsLocalLogLevelComboBox_SelectedIndexChanged);
            // 
            // LocalEnvironmentSettingsLocalTempDirectoryTextBox
            // 
            this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.Location = new System.Drawing.Point(249, 137);
            this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.Name = "LocalEnvironmentSettingsLocalTempDirectoryTextBox";
            this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.Size = new System.Drawing.Size(348, 22);
            this.LocalEnvironmentSettingsLocalTempDirectoryTextBox.TabIndex = 5;
            // 
            // LocalEnvironmentSettingsLocalLogDirectoryTextBox
            // 
            this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.Location = new System.Drawing.Point(249, 78);
            this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.Name = "LocalEnvironmentSettingsLocalLogDirectoryTextBox";
            this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.Size = new System.Drawing.Size(348, 22);
            this.LocalEnvironmentSettingsLocalLogDirectoryTextBox.TabIndex = 4;
            // 
            // LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox
            // 
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Location = new System.Drawing.Point(249, 21);
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Name = "LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox";
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.Size = new System.Drawing.Size(348, 22);
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox.TabIndex = 3;
            // 
            // LocalEnvironmentSettingsLocalTempDirectoryLabel
            // 
            this.LocalEnvironmentSettingsLocalTempDirectoryLabel.AutoSize = true;
            this.LocalEnvironmentSettingsLocalTempDirectoryLabel.Location = new System.Drawing.Point(100, 140);
            this.LocalEnvironmentSettingsLocalTempDirectoryLabel.Name = "LocalEnvironmentSettingsLocalTempDirectoryLabel";
            this.LocalEnvironmentSettingsLocalTempDirectoryLabel.Size = new System.Drawing.Size(143, 17);
            this.LocalEnvironmentSettingsLocalTempDirectoryLabel.TabIndex = 2;
            this.LocalEnvironmentSettingsLocalTempDirectoryLabel.Text = "Local Temp Directory";
            // 
            // LocalEnvironmentSettingsNuixLogDirectoryLabel
            // 
            this.LocalEnvironmentSettingsNuixLogDirectoryLabel.AutoSize = true;
            this.LocalEnvironmentSettingsNuixLogDirectoryLabel.Location = new System.Drawing.Point(112, 81);
            this.LocalEnvironmentSettingsNuixLogDirectoryLabel.Name = "LocalEnvironmentSettingsNuixLogDirectoryLabel";
            this.LocalEnvironmentSettingsNuixLogDirectoryLabel.Size = new System.Drawing.Size(131, 17);
            this.LocalEnvironmentSettingsNuixLogDirectoryLabel.TabIndex = 1;
            this.LocalEnvironmentSettingsNuixLogDirectoryLabel.Text = "Local Log Directory";
            // 
            // LocalEnvironmentSettingsNuixWorkstationDirectoryLabel
            // 
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel.AutoSize = true;
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel.Location = new System.Drawing.Point(30, 24);
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel.Name = "LocalEnvironmentSettingsNuixWorkstationDirectoryLabel";
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel.Size = new System.Drawing.Size(213, 17);
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel.TabIndex = 0;
            this.LocalEnvironmentSettingsNuixWorkstationDirectoryLabel.Text = "Local Nuix Workstation Directory";
            // 
            // RemoteOrchestrationSettingsGroupBox
            // 
            this.RemoteOrchestrationSettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoteOrchestrationSettingsGroupBox.Controls.Add(this.remoteNuixRESTGrid);
            this.RemoteOrchestrationSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoteOrchestrationSettingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RemoteOrchestrationSettingsGroupBox.Name = "RemoteOrchestrationSettingsGroupBox";
            this.RemoteOrchestrationSettingsGroupBox.Size = new System.Drawing.Size(830, 197);
            this.RemoteOrchestrationSettingsGroupBox.TabIndex = 1;
            this.RemoteOrchestrationSettingsGroupBox.TabStop = false;
            this.RemoteOrchestrationSettingsGroupBox.Text = "Remote Orchestration Settings";
            // 
            // remoteNuixRESTGrid
            // 
            this.remoteNuixRESTGrid.AutoGenerateColumns = false;
            this.remoteNuixRESTGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.remoteNuixRESTGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.remoteNodeNameDataGridViewTextBoxColumn,
            this.remoteNodeBaseUrlDataGridViewTextBoxColumn,
            this.remoteNodeUsernameDataGridViewTextBoxColumn,
            this.remoteNodePasswordDataGridViewTextBoxColumn,
            this.remoteNodeLicenseShortNameDataGridViewTextBoxColumn,
            this.remoteNodeLicenseDescriptionDataGridViewTextBoxColumn,
            this.remoteNodeWorkersDataGridViewTextBoxColumn});
            this.remoteNuixRESTGrid.DataSource = this.nuixRESTNodesBindingSource;
            this.remoteNuixRESTGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteNuixRESTGrid.Location = new System.Drawing.Point(3, 18);
            this.remoteNuixRESTGrid.Name = "remoteNuixRESTGrid";
            this.remoteNuixRESTGrid.RowTemplate.Height = 24;
            this.remoteNuixRESTGrid.Size = new System.Drawing.Size(824, 176);
            this.remoteNuixRESTGrid.TabIndex = 0;
            // 
            // remoteNodeNameDataGridViewTextBoxColumn
            // 
            this.remoteNodeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remoteNodeNameDataGridViewTextBoxColumn.DataPropertyName = "remoteNodeName";
            this.remoteNodeNameDataGridViewTextBoxColumn.HeaderText = "Nuix RESTful Instance Name";
            this.remoteNodeNameDataGridViewTextBoxColumn.Name = "remoteNodeNameDataGridViewTextBoxColumn";
            // 
            // remoteNodeBaseUrlDataGridViewTextBoxColumn
            // 
            this.remoteNodeBaseUrlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remoteNodeBaseUrlDataGridViewTextBoxColumn.DataPropertyName = "remoteNodeBaseUrl";
            this.remoteNodeBaseUrlDataGridViewTextBoxColumn.HeaderText = "Base URL";
            this.remoteNodeBaseUrlDataGridViewTextBoxColumn.Name = "remoteNodeBaseUrlDataGridViewTextBoxColumn";
            // 
            // remoteNodeUsernameDataGridViewTextBoxColumn
            // 
            this.remoteNodeUsernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remoteNodeUsernameDataGridViewTextBoxColumn.DataPropertyName = "remoteNodeUsername";
            this.remoteNodeUsernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.remoteNodeUsernameDataGridViewTextBoxColumn.Name = "remoteNodeUsernameDataGridViewTextBoxColumn";
            // 
            // remoteNodePasswordDataGridViewTextBoxColumn
            // 
            this.remoteNodePasswordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remoteNodePasswordDataGridViewTextBoxColumn.DataPropertyName = "remoteNodePassword";
            this.remoteNodePasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.remoteNodePasswordDataGridViewTextBoxColumn.Name = "remoteNodePasswordDataGridViewTextBoxColumn";
            // 
            // remoteNodeLicenseShortNameDataGridViewTextBoxColumn
            // 
            this.remoteNodeLicenseShortNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remoteNodeLicenseShortNameDataGridViewTextBoxColumn.DataPropertyName = "remoteNodeLicenseShortName";
            this.remoteNodeLicenseShortNameDataGridViewTextBoxColumn.HeaderText = "License Short Name";
            this.remoteNodeLicenseShortNameDataGridViewTextBoxColumn.Name = "remoteNodeLicenseShortNameDataGridViewTextBoxColumn";
            // 
            // remoteNodeLicenseDescriptionDataGridViewTextBoxColumn
            // 
            this.remoteNodeLicenseDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remoteNodeLicenseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "remoteNodeLicenseDescription";
            this.remoteNodeLicenseDescriptionDataGridViewTextBoxColumn.HeaderText = "License Description";
            this.remoteNodeLicenseDescriptionDataGridViewTextBoxColumn.Name = "remoteNodeLicenseDescriptionDataGridViewTextBoxColumn";
            // 
            // remoteNodeWorkersDataGridViewTextBoxColumn
            // 
            this.remoteNodeWorkersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remoteNodeWorkersDataGridViewTextBoxColumn.DataPropertyName = "remoteNodeWorkers";
            this.remoteNodeWorkersDataGridViewTextBoxColumn.HeaderText = "Number of Workers";
            this.remoteNodeWorkersDataGridViewTextBoxColumn.Name = "remoteNodeWorkersDataGridViewTextBoxColumn";
            // 
            // nuixRESTNodesBindingSource
            // 
            this.nuixRESTNodesBindingSource.DataMember = "NuixRESTNodes";
            this.nuixRESTNodesBindingSource.DataSource = this.nccDataSet;
            // 
            // nccDataSet
            // 
            this.nccDataSet.DataSetName = "nccDataSet";
            this.nccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SettingsBottomNestedSplitContainer
            // 
            this.SettingsBottomNestedSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBottomNestedSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SettingsBottomNestedSplitContainer.Name = "SettingsBottomNestedSplitContainer";
            this.SettingsBottomNestedSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SettingsBottomNestedSplitContainer.Panel1
            // 
            this.SettingsBottomNestedSplitContainer.Panel1.Controls.Add(this.LicenseSettingsGroupBox);
            // 
            // SettingsBottomNestedSplitContainer.Panel2
            // 
            this.SettingsBottomNestedSplitContainer.Panel2.Controls.Add(this.SettingsButtonsPanel);
            this.SettingsBottomNestedSplitContainer.Size = new System.Drawing.Size(830, 194);
            this.SettingsBottomNestedSplitContainer.SplitterDistance = 145;
            this.SettingsBottomNestedSplitContainer.TabIndex = 0;
            // 
            // LicenseSettingsGroupBox
            // 
            this.LicenseSettingsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LicenseSettingsGroupBox.Controls.Add(this.label2);
            this.LicenseSettingsGroupBox.Controls.Add(this.label1);
            this.LicenseSettingsGroupBox.Controls.Add(this.NuixRegistryServerLabel);
            this.LicenseSettingsGroupBox.Controls.Add(this.NuixManagementServerRegistryServersSystemProperty);
            this.LicenseSettingsGroupBox.Controls.Add(this.RefreshLicensesButton);
            this.LicenseSettingsGroupBox.Controls.Add(this.OptionalLabel1);
            this.LicenseSettingsGroupBox.Controls.Add(this.NuixManagementServerPasswordLabel);
            this.LicenseSettingsGroupBox.Controls.Add(this.NuixManagementServerUsernameLabel);
            this.LicenseSettingsGroupBox.Controls.Add(this.NuixManagementServerPassword);
            this.LicenseSettingsGroupBox.Controls.Add(this.NuixManagementServerUsername);
            this.LicenseSettingsGroupBox.Controls.Add(this.AvailableNuixLicensesLabel);
            this.LicenseSettingsGroupBox.Controls.Add(this.AvailableNuixLicenseComboBox);
            this.LicenseSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LicenseSettingsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LicenseSettingsGroupBox.Name = "LicenseSettingsGroupBox";
            this.LicenseSettingsGroupBox.Size = new System.Drawing.Size(830, 145);
            this.LicenseSettingsGroupBox.TabIndex = 2;
            this.LicenseSettingsGroupBox.TabStop = false;
            this.LicenseSettingsGroupBox.Text = "License Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "(Optional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "(Optional)";
            // 
            // NuixRegistryServerLabel
            // 
            this.NuixRegistryServerLabel.AutoSize = true;
            this.NuixRegistryServerLabel.Location = new System.Drawing.Point(6, 115);
            this.NuixRegistryServerLabel.Name = "NuixRegistryServerLabel";
            this.NuixRegistryServerLabel.Size = new System.Drawing.Size(144, 17);
            this.NuixRegistryServerLabel.TabIndex = 9;
            this.NuixRegistryServerLabel.Text = "Nuix Registry Servers";
            // 
            // NuixManagementServerRegistryServersSystemProperty
            // 
            this.NuixManagementServerRegistryServersSystemProperty.Location = new System.Drawing.Point(156, 112);
            this.NuixManagementServerRegistryServersSystemProperty.Name = "NuixManagementServerRegistryServersSystemProperty";
            this.NuixManagementServerRegistryServersSystemProperty.PasswordChar = '*';
            this.NuixManagementServerRegistryServersSystemProperty.Size = new System.Drawing.Size(206, 22);
            this.NuixManagementServerRegistryServersSystemProperty.TabIndex = 8;
            // 
            // RefreshLicensesButton
            // 
            this.RefreshLicensesButton.Location = new System.Drawing.Point(684, 21);
            this.RefreshLicensesButton.Name = "RefreshLicensesButton";
            this.RefreshLicensesButton.Size = new System.Drawing.Size(140, 31);
            this.RefreshLicensesButton.TabIndex = 7;
            this.RefreshLicensesButton.Text = "Refresh Licenses";
            this.RefreshLicensesButton.UseVisualStyleBackColor = true;
            this.RefreshLicensesButton.Click += new System.EventHandler(this.RefreshLicensesButton_Click);
            // 
            // OptionalLabel1
            // 
            this.OptionalLabel1.AutoSize = true;
            this.OptionalLabel1.Location = new System.Drawing.Point(368, 59);
            this.OptionalLabel1.Name = "OptionalLabel1";
            this.OptionalLabel1.Size = new System.Drawing.Size(71, 17);
            this.OptionalLabel1.TabIndex = 6;
            this.OptionalLabel1.Text = "(Optional)";
            // 
            // NuixManagementServerPasswordLabel
            // 
            this.NuixManagementServerPasswordLabel.AutoSize = true;
            this.NuixManagementServerPasswordLabel.Location = new System.Drawing.Point(47, 87);
            this.NuixManagementServerPasswordLabel.Name = "NuixManagementServerPasswordLabel";
            this.NuixManagementServerPasswordLabel.Size = new System.Drawing.Size(103, 17);
            this.NuixManagementServerPasswordLabel.TabIndex = 5;
            this.NuixManagementServerPasswordLabel.Text = "NMS Password";
            // 
            // NuixManagementServerUsernameLabel
            // 
            this.NuixManagementServerUsernameLabel.AutoSize = true;
            this.NuixManagementServerUsernameLabel.Location = new System.Drawing.Point(43, 59);
            this.NuixManagementServerUsernameLabel.Name = "NuixManagementServerUsernameLabel";
            this.NuixManagementServerUsernameLabel.Size = new System.Drawing.Size(107, 17);
            this.NuixManagementServerUsernameLabel.TabIndex = 4;
            this.NuixManagementServerUsernameLabel.Text = "NMS Username";
            // 
            // NuixManagementServerPassword
            // 
            this.NuixManagementServerPassword.Location = new System.Drawing.Point(156, 84);
            this.NuixManagementServerPassword.Name = "NuixManagementServerPassword";
            this.NuixManagementServerPassword.PasswordChar = '*';
            this.NuixManagementServerPassword.Size = new System.Drawing.Size(206, 22);
            this.NuixManagementServerPassword.TabIndex = 3;
            // 
            // NuixManagementServerUsername
            // 
            this.NuixManagementServerUsername.Location = new System.Drawing.Point(156, 56);
            this.NuixManagementServerUsername.Name = "NuixManagementServerUsername";
            this.NuixManagementServerUsername.Size = new System.Drawing.Size(206, 22);
            this.NuixManagementServerUsername.TabIndex = 2;
            // 
            // AvailableNuixLicensesLabel
            // 
            this.AvailableNuixLicensesLabel.AutoSize = true;
            this.AvailableNuixLicensesLabel.Location = new System.Drawing.Point(21, 28);
            this.AvailableNuixLicensesLabel.Name = "AvailableNuixLicensesLabel";
            this.AvailableNuixLicensesLabel.Size = new System.Drawing.Size(88, 17);
            this.AvailableNuixLicensesLabel.TabIndex = 1;
            this.AvailableNuixLicensesLabel.Text = "Nuix License";
            // 
            // AvailableNuixLicenseComboBox
            // 
            this.AvailableNuixLicenseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvailableNuixLicenseComboBox.FormattingEnabled = true;
            this.AvailableNuixLicenseComboBox.Location = new System.Drawing.Point(115, 25);
            this.AvailableNuixLicenseComboBox.Name = "AvailableNuixLicenseComboBox";
            this.AvailableNuixLicenseComboBox.Size = new System.Drawing.Size(563, 24);
            this.AvailableNuixLicenseComboBox.TabIndex = 0;
            this.AvailableNuixLicenseComboBox.SelectedIndexChanged += new System.EventHandler(this.AvailableNuixLicenseComboBox_SelectedIndexChanged);
            // 
            // SettingsButtonsPanel
            // 
            this.SettingsButtonsPanel.Controls.Add(this.SettingsRestoreDefaultsButton);
            this.SettingsButtonsPanel.Controls.Add(this.SettingsSaveButton);
            this.SettingsButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsButtonsPanel.Name = "SettingsButtonsPanel";
            this.SettingsButtonsPanel.Size = new System.Drawing.Size(830, 45);
            this.SettingsButtonsPanel.TabIndex = 6;
            // 
            // SettingsRestoreDefaultsButton
            // 
            this.SettingsRestoreDefaultsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsRestoreDefaultsButton.Location = new System.Drawing.Point(415, 0);
            this.SettingsRestoreDefaultsButton.Name = "SettingsRestoreDefaultsButton";
            this.SettingsRestoreDefaultsButton.Size = new System.Drawing.Size(415, 45);
            this.SettingsRestoreDefaultsButton.TabIndex = 3;
            this.SettingsRestoreDefaultsButton.Text = "Restore Default Settings";
            this.SettingsRestoreDefaultsButton.UseVisualStyleBackColor = true;
            this.SettingsRestoreDefaultsButton.Click += new System.EventHandler(this.SettingsRestoreDefaultsButton_Click);
            // 
            // SettingsSaveButton
            // 
            this.SettingsSaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsSaveButton.Location = new System.Drawing.Point(0, 0);
            this.SettingsSaveButton.Name = "SettingsSaveButton";
            this.SettingsSaveButton.Size = new System.Drawing.Size(415, 45);
            this.SettingsSaveButton.TabIndex = 4;
            this.SettingsSaveButton.Text = "Save Settings";
            this.SettingsSaveButton.UseVisualStyleBackColor = true;
            this.SettingsSaveButton.Click += new System.EventHandler(this.SettingsSaveButton_Click);
            // 
            // DataClassificationTab
            // 
            this.DataClassificationTab.BackColor = System.Drawing.SystemColors.Control;
            this.DataClassificationTab.Controls.Add(this.dataClassificationSplitContainer);
            this.DataClassificationTab.Location = new System.Drawing.Point(4, 25);
            this.DataClassificationTab.Name = "DataClassificationTab";
            this.DataClassificationTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataClassificationTab.Size = new System.Drawing.Size(836, 570);
            this.DataClassificationTab.TabIndex = 2;
            this.DataClassificationTab.Text = "Data Classification";
            // 
            // dataClassificationSplitContainer
            // 
            this.dataClassificationSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataClassificationSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.dataClassificationSplitContainer.Name = "dataClassificationSplitContainer";
            // 
            // dataClassificationSplitContainer.Panel1
            // 
            this.dataClassificationSplitContainer.Panel1.Controls.Add(this.dataClassificationTaxonomyTree);
            this.dataClassificationSplitContainer.Panel1.Controls.Add(this.dataClassificationMenuStrip);
            // 
            // dataClassificationSplitContainer.Panel2
            // 
            this.dataClassificationSplitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.dataClassificationSplitContainer.Size = new System.Drawing.Size(830, 564);
            this.dataClassificationSplitContainer.SplitterDistance = 239;
            this.dataClassificationSplitContainer.TabIndex = 0;
            // 
            // dataClassificationTaxonomyTree
            // 
            this.dataClassificationTaxonomyTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataClassificationTaxonomyTree.Location = new System.Drawing.Point(0, 28);
            this.dataClassificationTaxonomyTree.Name = "dataClassificationTaxonomyTree";
            treeNode8.Name = "dataClassificationTaxonomyTreeNode";
            treeNode8.Text = "Taxonomy";
            this.dataClassificationTaxonomyTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.dataClassificationTaxonomyTree.Size = new System.Drawing.Size(239, 536);
            this.dataClassificationTaxonomyTree.TabIndex = 1;
            // 
            // dataClassificationMenuStrip
            // 
            this.dataClassificationMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dataClassificationMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataClassificationTaxonomyMenu,
            this.dataClassificationViewMenu,
            this.reportsToolStripMenuItem});
            this.dataClassificationMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.dataClassificationMenuStrip.Name = "dataClassificationMenuStrip";
            this.dataClassificationMenuStrip.Size = new System.Drawing.Size(239, 28);
            this.dataClassificationMenuStrip.TabIndex = 0;
            this.dataClassificationMenuStrip.Text = "Data Classification Menu Strip";
            // 
            // dataClassificationTaxonomyMenu
            // 
            this.dataClassificationTaxonomyMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveTaxonomyToolStripMenuItem});
            this.dataClassificationTaxonomyMenu.Name = "dataClassificationTaxonomyMenu";
            this.dataClassificationTaxonomyMenu.Size = new System.Drawing.Size(70, 24);
            this.dataClassificationTaxonomyMenu.Text = "Actions";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.fileToolStripMenuItem.Text = "Load Taxonomy";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveTaxonomyToolStripMenuItem
            // 
            this.saveTaxonomyToolStripMenuItem.Name = "saveTaxonomyToolStripMenuItem";
            this.saveTaxonomyToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveTaxonomyToolStripMenuItem.Text = "Save Taxonomy";
            // 
            // dataClassificationViewMenu
            // 
            this.dataClassificationViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metadataProfileToolStripMenuItem});
            this.dataClassificationViewMenu.Name = "dataClassificationViewMenu";
            this.dataClassificationViewMenu.Size = new System.Drawing.Size(53, 24);
            this.dataClassificationViewMenu.Text = "View";
            // 
            // metadataProfileToolStripMenuItem
            // 
            this.metadataProfileToolStripMenuItem.Name = "metadataProfileToolStripMenuItem";
            this.metadataProfileToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.metadataProfileToolStripMenuItem.Text = "Metadata Profile";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryReportToolStripMenuItem,
            this.historyReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // summaryReportToolStripMenuItem
            // 
            this.summaryReportToolStripMenuItem.Name = "summaryReportToolStripMenuItem";
            this.summaryReportToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.summaryReportToolStripMenuItem.Text = "Summary Report";
            // 
            // historyReportToolStripMenuItem
            // 
            this.historyReportToolStripMenuItem.Name = "historyReportToolStripMenuItem";
            this.historyReportToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.historyReportToolStripMenuItem.Text = "History Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameColumn,
            this.mimeTypeColumn,
            this.fileSizeColumn,
            this.auditedSizeColumn,
            this.modifiedDateColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(587, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemNameColumn.HeaderText = "Item Name";
            this.itemNameColumn.Name = "itemNameColumn";
            // 
            // mimeTypeColumn
            // 
            this.mimeTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mimeTypeColumn.HeaderText = "MIME-Type";
            this.mimeTypeColumn.Name = "mimeTypeColumn";
            // 
            // fileSizeColumn
            // 
            this.fileSizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileSizeColumn.HeaderText = "File Size";
            this.fileSizeColumn.Name = "fileSizeColumn";
            // 
            // auditedSizeColumn
            // 
            this.auditedSizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.auditedSizeColumn.HeaderText = "Audited Size";
            this.auditedSizeColumn.Name = "auditedSizeColumn";
            // 
            // modifiedDateColumn
            // 
            this.modifiedDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modifiedDateColumn.HeaderText = "Date Modified";
            this.modifiedDateColumn.Name = "modifiedDateColumn";
            // 
            // nuixRESTNodesTableAdapter
            // 
            this.nuixRESTNodesTableAdapter.ClearBeforeFill = true;
            // 
            // NuixCommandConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 853);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.dataClassificationMenuStrip;
            this.Name = "NuixCommandConsole";
            this.Text = "Nuix Command Console";
            this.Load += new System.EventHandler(this.NuixCommandConsole_Load);
            this.Tabs.ResumeLayout(false);
            this.ActivitiesTab.ResumeLayout(false);
            this.ActivitiesSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActivitiesSplitContainer)).EndInit();
            this.ActivitiesSplitContainer.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTopSplitContainer.Panel1.ResumeLayout(false);
            this.SettingsTopSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTopSplitContainer)).EndInit();
            this.SettingsTopSplitContainer.ResumeLayout(false);
            this.SettingsTopNestedSplitContainer.Panel1.ResumeLayout(false);
            this.SettingsTopNestedSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsTopNestedSplitContainer)).EndInit();
            this.SettingsTopNestedSplitContainer.ResumeLayout(false);
            this.LocalEnvironmentSettingsGroupBox.ResumeLayout(false);
            this.LocalEnvironmentSettingsGroupBox.PerformLayout();
            this.RemoteOrchestrationSettingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remoteNuixRESTGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuixRESTNodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nccDataSet)).EndInit();
            this.SettingsBottomNestedSplitContainer.Panel1.ResumeLayout(false);
            this.SettingsBottomNestedSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBottomNestedSplitContainer)).EndInit();
            this.SettingsBottomNestedSplitContainer.ResumeLayout(false);
            this.LicenseSettingsGroupBox.ResumeLayout(false);
            this.LicenseSettingsGroupBox.PerformLayout();
            this.SettingsButtonsPanel.ResumeLayout(false);
            this.DataClassificationTab.ResumeLayout(false);
            this.dataClassificationSplitContainer.Panel1.ResumeLayout(false);
            this.dataClassificationSplitContainer.Panel1.PerformLayout();
            this.dataClassificationSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClassificationSplitContainer)).EndInit();
            this.dataClassificationSplitContainer.ResumeLayout(false);
            this.dataClassificationMenuStrip.ResumeLayout(false);
            this.dataClassificationMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ActivitiesTab;
        private System.Windows.Forms.SplitContainer ActivitiesSplitContainer;
        private System.Windows.Forms.TreeView ActivityTree;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.GroupBox LicenseSettingsGroupBox;
        private System.Windows.Forms.GroupBox RemoteOrchestrationSettingsGroupBox;
        private System.Windows.Forms.GroupBox LocalEnvironmentSettingsGroupBox;
        private System.Windows.Forms.Button SettingsSaveButton;
        private System.Windows.Forms.Button SettingsRestoreDefaultsButton;
        private System.Windows.Forms.ComboBox LocalEnvironmentSettingsLocalLogLevelComboBox;
        private System.Windows.Forms.TextBox LocalEnvironmentSettingsLocalTempDirectoryTextBox;
        private System.Windows.Forms.TextBox LocalEnvironmentSettingsLocalLogDirectoryTextBox;
        private System.Windows.Forms.TextBox LocalEnvironmentSettingsNuixWorkstationDirectoryTextBox;
        private System.Windows.Forms.Label LocalEnvironmentSettingsLocalTempDirectoryLabel;
        private System.Windows.Forms.Label LocalEnvironmentSettingsNuixLogDirectoryLabel;
        private System.Windows.Forms.Label LocalEnvironmentSettingsNuixWorkstationDirectoryLabel;
        private System.Windows.Forms.Label LocalEnvironmentSettingsLogLevelLabel;
        private System.Windows.Forms.Button LocalEnvironmentSettingsTempDirBrowseButton;
        private System.Windows.Forms.Button LocalEnvironmentSettingsLogDirBrowseButton;
        private System.Windows.Forms.Button LocalEnvironmentSettingsNuixWorkstationDirBrowseButton;
        private System.Windows.Forms.SplitContainer SettingsTopSplitContainer;
        private System.Windows.Forms.SplitContainer SettingsTopNestedSplitContainer;
        private System.Windows.Forms.SplitContainer SettingsBottomNestedSplitContainer;
        private System.Windows.Forms.Panel SettingsButtonsPanel;
        private System.Windows.Forms.TabPage DataClassificationTab;
        private System.Windows.Forms.SplitContainer dataClassificationSplitContainer;
        private System.Windows.Forms.MenuStrip dataClassificationMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dataClassificationTaxonomyMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTaxonomyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyReportToolStripMenuItem;
        private System.Windows.Forms.TreeView dataClassificationTaxonomyTree;
        private System.Windows.Forms.ToolStripMenuItem dataClassificationViewMenu;
        private System.Windows.Forms.ToolStripMenuItem metadataProfileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mimeTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditedSizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateColumn;
        private System.Windows.Forms.DataGridView remoteNuixRESTGrid;
        private System.Windows.Forms.ComboBox AvailableNuixLicenseComboBox;
        private System.Windows.Forms.Button RefreshLicensesButton;
        private System.Windows.Forms.Label OptionalLabel1;
        private System.Windows.Forms.Label NuixManagementServerPasswordLabel;
        private System.Windows.Forms.Label NuixManagementServerUsernameLabel;
        private System.Windows.Forms.TextBox NuixManagementServerPassword;
        private System.Windows.Forms.TextBox NuixManagementServerUsername;
        private System.Windows.Forms.Label AvailableNuixLicensesLabel;
        private System.Windows.Forms.Button LocalNuixEngineDirectoryBrowseButton;
        private System.Windows.Forms.TextBox LocalNuixEngineDirectoryTextBox;
        private System.Windows.Forms.Label LocalNuixEngineDirectoryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NuixRegistryServerLabel;
        private System.Windows.Forms.TextBox NuixManagementServerRegistryServersSystemProperty;
        private nccDataSet nccDataSet;
        private System.Windows.Forms.BindingSource nuixRESTNodesBindingSource;
        private nccDataSetTableAdapters.NuixRESTNodesTableAdapter nuixRESTNodesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteNodeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteNodeBaseUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteNodeUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteNodePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteNodeLicenseShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteNodeLicenseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteNodeWorkersDataGridViewTextBoxColumn;
    }
}

