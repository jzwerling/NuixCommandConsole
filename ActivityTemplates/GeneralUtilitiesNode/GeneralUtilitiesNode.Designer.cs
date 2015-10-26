namespace Nuix.ActivityTemplates.GeneralUtilitiesNode
{
    partial class GeneralUtilitiesNode
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
            this.GeneralUtilitiesDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GeneralUtilitiesDescriptionRichTextBox
            // 
            this.GeneralUtilitiesDescriptionRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.GeneralUtilitiesDescriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneralUtilitiesDescriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralUtilitiesDescriptionRichTextBox.Enabled = false;
            this.GeneralUtilitiesDescriptionRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.GeneralUtilitiesDescriptionRichTextBox.Name = "GeneralUtilitiesDescriptionRichTextBox";
            this.GeneralUtilitiesDescriptionRichTextBox.Size = new System.Drawing.Size(319, 313);
            this.GeneralUtilitiesDescriptionRichTextBox.TabIndex = 0;
            this.GeneralUtilitiesDescriptionRichTextBox.Text = "The general activities are miscellaneous tools with broad application, not intend" +
    "ed for a specific use case.";
            // 
            // GeneralUtilitiesNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GeneralUtilitiesDescriptionRichTextBox);
            this.Name = "GeneralUtilitiesNode";
            this.Size = new System.Drawing.Size(319, 313);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox GeneralUtilitiesDescriptionRichTextBox;
    }
}
