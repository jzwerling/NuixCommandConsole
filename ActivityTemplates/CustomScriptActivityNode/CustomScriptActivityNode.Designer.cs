namespace Nuix.ActivityTemplates.CustomScriptActivityNode
{
    partial class CustomScriptActivityNode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomScriptActivitySplitContainer = new System.Windows.Forms.SplitContainer();
            this.DigitalRuneScriptEditor = new DigitalRune.Windows.TextEditor.TextEditorControl();
            this.CustomScriptActivityConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomScriptActivitySaveButton = new System.Windows.Forms.Button();
            this.CustomScriptActivityRunActivityButton = new System.Windows.Forms.Button();
            this.CustomScriptActivityRemoteTargetComboBox = new System.Windows.Forms.ComboBox();
            this.CustomScriptActivityRunRemoteRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomScriptActivityRunLocalRadioButton = new System.Windows.Forms.RadioButton();
            this.CustomScriptActivityCommandLineSwitchesLabel = new System.Windows.Forms.Label();
            this.CustomScriptActivityCommandLineSwitches = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomScriptActivitySplitContainer)).BeginInit();
            this.CustomScriptActivitySplitContainer.Panel1.SuspendLayout();
            this.CustomScriptActivitySplitContainer.Panel2.SuspendLayout();
            this.CustomScriptActivitySplitContainer.SuspendLayout();
            this.CustomScriptActivityConfigurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomScriptActivitySplitContainer
            // 
            this.CustomScriptActivitySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomScriptActivitySplitContainer.Location = new System.Drawing.Point(0, 0);
            this.CustomScriptActivitySplitContainer.Name = "CustomScriptActivitySplitContainer";
            this.CustomScriptActivitySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // CustomScriptActivitySplitContainer.Panel1
            // 
            this.CustomScriptActivitySplitContainer.Panel1.Controls.Add(this.DigitalRuneScriptEditor);
            // 
            // CustomScriptActivitySplitContainer.Panel2
            // 
            this.CustomScriptActivitySplitContainer.Panel2.Controls.Add(this.CustomScriptActivityConfigurationGroupBox);
            this.CustomScriptActivitySplitContainer.Size = new System.Drawing.Size(546, 462);
            this.CustomScriptActivitySplitContainer.SplitterDistance = 305;
            this.CustomScriptActivitySplitContainer.TabIndex = 1;
            // 
            // DigitalRuneScriptEditor
            // 
            this.DigitalRuneScriptEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DigitalRuneScriptEditor.LineViewerStyle = DigitalRune.Windows.TextEditor.Properties.LineViewerStyle.FullRow;
            this.DigitalRuneScriptEditor.Location = new System.Drawing.Point(0, 0);
            this.DigitalRuneScriptEditor.Name = "DigitalRuneScriptEditor";
            this.DigitalRuneScriptEditor.Size = new System.Drawing.Size(546, 305);
            this.DigitalRuneScriptEditor.TabIndex = 0;
            // 
            // CustomScriptActivityConfigurationGroupBox
            // 
            this.CustomScriptActivityConfigurationGroupBox.Controls.Add(this.CustomScriptActivityCommandLineSwitches);
            this.CustomScriptActivityConfigurationGroupBox.Controls.Add(this.CustomScriptActivityCommandLineSwitchesLabel);
            this.CustomScriptActivityConfigurationGroupBox.Controls.Add(this.CustomScriptActivitySaveButton);
            this.CustomScriptActivityConfigurationGroupBox.Controls.Add(this.CustomScriptActivityRunActivityButton);
            this.CustomScriptActivityConfigurationGroupBox.Controls.Add(this.CustomScriptActivityRemoteTargetComboBox);
            this.CustomScriptActivityConfigurationGroupBox.Controls.Add(this.CustomScriptActivityRunRemoteRadioButton);
            this.CustomScriptActivityConfigurationGroupBox.Controls.Add(this.CustomScriptActivityRunLocalRadioButton);
            this.CustomScriptActivityConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomScriptActivityConfigurationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomScriptActivityConfigurationGroupBox.Name = "CustomScriptActivityConfigurationGroupBox";
            this.CustomScriptActivityConfigurationGroupBox.Size = new System.Drawing.Size(546, 153);
            this.CustomScriptActivityConfigurationGroupBox.TabIndex = 0;
            this.CustomScriptActivityConfigurationGroupBox.TabStop = false;
            this.CustomScriptActivityConfigurationGroupBox.Text = "Custom Script Activity Configuation";
            // 
            // CustomScriptActivitySaveButton
            // 
            this.CustomScriptActivitySaveButton.Location = new System.Drawing.Point(269, 106);
            this.CustomScriptActivitySaveButton.Name = "CustomScriptActivitySaveButton";
            this.CustomScriptActivitySaveButton.Size = new System.Drawing.Size(210, 33);
            this.CustomScriptActivitySaveButton.TabIndex = 4;
            this.CustomScriptActivitySaveButton.Text = "Save Script";
            this.CustomScriptActivitySaveButton.UseVisualStyleBackColor = true;
            this.CustomScriptActivitySaveButton.Click += new System.EventHandler(this.CustomScriptActivitySaveButton_Click);
            // 
            // CustomScriptActivityRunActivityButton
            // 
            this.CustomScriptActivityRunActivityButton.Location = new System.Drawing.Point(54, 106);
            this.CustomScriptActivityRunActivityButton.Name = "CustomScriptActivityRunActivityButton";
            this.CustomScriptActivityRunActivityButton.Size = new System.Drawing.Size(210, 33);
            this.CustomScriptActivityRunActivityButton.TabIndex = 3;
            this.CustomScriptActivityRunActivityButton.Text = "Execute Script";
            this.CustomScriptActivityRunActivityButton.UseVisualStyleBackColor = true;
            this.CustomScriptActivityRunActivityButton.Click += new System.EventHandler(this.CustomScriptActivityRunActivityButton_Click);
            // 
            // CustomScriptActivityRemoteTargetComboBox
            // 
            this.CustomScriptActivityRemoteTargetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomScriptActivityRemoteTargetComboBox.FormattingEnabled = true;
            this.CustomScriptActivityRemoteTargetComboBox.Location = new System.Drawing.Point(135, 50);
            this.CustomScriptActivityRemoteTargetComboBox.Name = "CustomScriptActivityRemoteTargetComboBox";
            this.CustomScriptActivityRemoteTargetComboBox.Size = new System.Drawing.Size(366, 24);
            this.CustomScriptActivityRemoteTargetComboBox.TabIndex = 2;
            // 
            // CustomScriptActivityRunRemoteRadioButton
            // 
            this.CustomScriptActivityRunRemoteRadioButton.AutoSize = true;
            this.CustomScriptActivityRunRemoteRadioButton.Location = new System.Drawing.Point(7, 50);
            this.CustomScriptActivityRunRemoteRadioButton.Name = "CustomScriptActivityRunRemoteRadioButton";
            this.CustomScriptActivityRunRemoteRadioButton.Size = new System.Drawing.Size(108, 21);
            this.CustomScriptActivityRunRemoteRadioButton.TabIndex = 1;
            this.CustomScriptActivityRunRemoteRadioButton.TabStop = true;
            this.CustomScriptActivityRunRemoteRadioButton.Text = "Run Remote";
            this.CustomScriptActivityRunRemoteRadioButton.UseVisualStyleBackColor = true;
            this.CustomScriptActivityRunRemoteRadioButton.CheckedChanged += new System.EventHandler(this.CustomScriptActivityTargetChanged);
            // 
            // CustomScriptActivityRunLocalRadioButton
            // 
            this.CustomScriptActivityRunLocalRadioButton.AutoSize = true;
            this.CustomScriptActivityRunLocalRadioButton.Location = new System.Drawing.Point(7, 22);
            this.CustomScriptActivityRunLocalRadioButton.Name = "CustomScriptActivityRunLocalRadioButton";
            this.CustomScriptActivityRunLocalRadioButton.Size = new System.Drawing.Size(93, 21);
            this.CustomScriptActivityRunLocalRadioButton.TabIndex = 0;
            this.CustomScriptActivityRunLocalRadioButton.TabStop = true;
            this.CustomScriptActivityRunLocalRadioButton.Text = "Run Local";
            this.CustomScriptActivityRunLocalRadioButton.UseVisualStyleBackColor = true;
            this.CustomScriptActivityRunLocalRadioButton.CheckedChanged += new System.EventHandler(this.CustomScriptActivityTargetChanged);
            // 
            // CustomScriptActivityCommandLineSwitchesLabel
            // 
            this.CustomScriptActivityCommandLineSwitchesLabel.AutoSize = true;
            this.CustomScriptActivityCommandLineSwitchesLabel.Location = new System.Drawing.Point(16, 81);
            this.CustomScriptActivityCommandLineSwitchesLabel.Name = "CustomScriptActivityCommandLineSwitchesLabel";
            this.CustomScriptActivityCommandLineSwitchesLabel.Size = new System.Drawing.Size(63, 17);
            this.CustomScriptActivityCommandLineSwitchesLabel.TabIndex = 5;
            this.CustomScriptActivityCommandLineSwitchesLabel.Text = "Switches";
            // 
            // CustomScriptActivityCommandLineSwitches
            // 
            this.CustomScriptActivityCommandLineSwitches.Location = new System.Drawing.Point(85, 78);
            this.CustomScriptActivityCommandLineSwitches.Name = "CustomScriptActivityCommandLineSwitches";
            this.CustomScriptActivityCommandLineSwitches.Size = new System.Drawing.Size(416, 22);
            this.CustomScriptActivityCommandLineSwitches.TabIndex = 6;
            // 
            // CustomScriptActivityNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomScriptActivitySplitContainer);
            this.Name = "CustomScriptActivityNode";
            this.Size = new System.Drawing.Size(546, 462);
            this.CustomScriptActivitySplitContainer.Panel1.ResumeLayout(false);
            this.CustomScriptActivitySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomScriptActivitySplitContainer)).EndInit();
            this.CustomScriptActivitySplitContainer.ResumeLayout(false);
            this.CustomScriptActivityConfigurationGroupBox.ResumeLayout(false);
            this.CustomScriptActivityConfigurationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer CustomScriptActivitySplitContainer;
        private DigitalRune.Windows.TextEditor.TextEditorControl DigitalRuneScriptEditor;
        private System.Windows.Forms.GroupBox CustomScriptActivityConfigurationGroupBox;
        private System.Windows.Forms.ComboBox CustomScriptActivityRemoteTargetComboBox;
        private System.Windows.Forms.RadioButton CustomScriptActivityRunRemoteRadioButton;
        private System.Windows.Forms.RadioButton CustomScriptActivityRunLocalRadioButton;
        private System.Windows.Forms.Button CustomScriptActivitySaveButton;
        private System.Windows.Forms.Button CustomScriptActivityRunActivityButton;
        private System.Windows.Forms.TextBox CustomScriptActivityCommandLineSwitches;
        private System.Windows.Forms.Label CustomScriptActivityCommandLineSwitchesLabel;
    }
}
