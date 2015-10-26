namespace Nuix.ActivityTemplates.IntelligentMigrationActivitiesNode
{
    partial class IntelligentMigrationActivitiesNode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntelligentMigrationActivitiesNode));
            this.IntelligentMigrationDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // IntelligentMigrationDescriptionRichTextBox
            // 
            this.IntelligentMigrationDescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IntelligentMigrationDescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntelligentMigrationDescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntelligentMigrationDescriptionRichTextBox.Enabled = false;
            this.IntelligentMigrationDescriptionRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.IntelligentMigrationDescriptionRichTextBox.Name = "IntelligentMigrationDescriptionRichTextBox";
            this.IntelligentMigrationDescriptionRichTextBox.Size = new System.Drawing.Size(319, 313);
            this.IntelligentMigrationDescriptionRichTextBox.TabIndex = 0;
            this.IntelligentMigrationDescriptionRichTextBox.Text = resources.GetString("IntelligentMigrationDescriptionRichTextBox.Text");
            // 
            // IntelligentMigrationActivitiesNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IntelligentMigrationDescriptionRichTextBox);
            this.Name = "IntelligentMigrationActivitiesNode";
            this.Size = new System.Drawing.Size(319, 313);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox IntelligentMigrationDescriptionRichTextBox;
    }
}
