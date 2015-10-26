namespace Nuix.ActivityTemplates.SearchNode
{
    partial class SearchNode
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
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.NuixQueryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NuixSearchTopSplitContainer = new System.Windows.Forms.SplitContainer();
            this.NuixSearchNestedSplitContainer = new System.Windows.Forms.SplitContainer();
            this.NuixSearchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.NuixSearchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuixSearchTopSplitContainer)).BeginInit();
            this.NuixSearchTopSplitContainer.Panel1.SuspendLayout();
            this.NuixSearchTopSplitContainer.Panel2.SuspendLayout();
            this.NuixSearchTopSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuixSearchNestedSplitContainer)).BeginInit();
            this.NuixSearchNestedSplitContainer.Panel1.SuspendLayout();
            this.NuixSearchNestedSplitContainer.Panel2.SuspendLayout();
            this.NuixSearchNestedSplitContainer.SuspendLayout();
            this.NuixSearchResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuixSearchResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.NuixSearchTopSplitContainer);
            this.SearchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(546, 524);
            this.SearchGroupBox.TabIndex = 0;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Nuix Indices";
            // 
            // NuixQueryRichTextBox
            // 
            this.NuixQueryRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuixQueryRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.NuixQueryRichTextBox.Name = "NuixQueryRichTextBox";
            this.NuixQueryRichTextBox.Size = new System.Drawing.Size(540, 153);
            this.NuixQueryRichTextBox.TabIndex = 0;
            this.NuixQueryRichTextBox.Text = "";
            // 
            // NuixSearchTopSplitContainer
            // 
            this.NuixSearchTopSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuixSearchTopSplitContainer.Location = new System.Drawing.Point(3, 18);
            this.NuixSearchTopSplitContainer.Name = "NuixSearchTopSplitContainer";
            this.NuixSearchTopSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // NuixSearchTopSplitContainer.Panel1
            // 
            this.NuixSearchTopSplitContainer.Panel1.Controls.Add(this.NuixQueryRichTextBox);
            // 
            // NuixSearchTopSplitContainer.Panel2
            // 
            this.NuixSearchTopSplitContainer.Panel2.Controls.Add(this.NuixSearchNestedSplitContainer);
            this.NuixSearchTopSplitContainer.Size = new System.Drawing.Size(540, 503);
            this.NuixSearchTopSplitContainer.SplitterDistance = 153;
            this.NuixSearchTopSplitContainer.TabIndex = 1;
            // 
            // NuixSearchNestedSplitContainer
            // 
            this.NuixSearchNestedSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuixSearchNestedSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.NuixSearchNestedSplitContainer.Name = "NuixSearchNestedSplitContainer";
            this.NuixSearchNestedSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // NuixSearchNestedSplitContainer.Panel1
            // 
            this.NuixSearchNestedSplitContainer.Panel1.Controls.Add(this.SearchOptionsGroupBox);
            // 
            // NuixSearchNestedSplitContainer.Panel2
            // 
            this.NuixSearchNestedSplitContainer.Panel2.Controls.Add(this.NuixSearchResultsGroupBox);
            this.NuixSearchNestedSplitContainer.Size = new System.Drawing.Size(540, 346);
            this.NuixSearchNestedSplitContainer.SplitterDistance = 123;
            this.NuixSearchNestedSplitContainer.TabIndex = 2;
            // 
            // NuixSearchResultsGroupBox
            // 
            this.NuixSearchResultsGroupBox.Controls.Add(this.NuixSearchResultsDataGridView);
            this.NuixSearchResultsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuixSearchResultsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.NuixSearchResultsGroupBox.Name = "NuixSearchResultsGroupBox";
            this.NuixSearchResultsGroupBox.Size = new System.Drawing.Size(540, 219);
            this.NuixSearchResultsGroupBox.TabIndex = 0;
            this.NuixSearchResultsGroupBox.TabStop = false;
            this.NuixSearchResultsGroupBox.Text = "Search Results";
            // 
            // NuixSearchResultsDataGridView
            // 
            this.NuixSearchResultsDataGridView.AllowUserToAddRows = false;
            this.NuixSearchResultsDataGridView.AllowUserToDeleteRows = false;
            this.NuixSearchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NuixSearchResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NuixSearchResultsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.NuixSearchResultsDataGridView.Name = "NuixSearchResultsDataGridView";
            this.NuixSearchResultsDataGridView.ReadOnly = true;
            this.NuixSearchResultsDataGridView.RowTemplate.Height = 24;
            this.NuixSearchResultsDataGridView.Size = new System.Drawing.Size(534, 198);
            this.NuixSearchResultsDataGridView.TabIndex = 0;
            // 
            // SearchOptionsGroupBox
            // 
            this.SearchOptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchOptionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SearchOptionsGroupBox.Name = "SearchOptionsGroupBox";
            this.SearchOptionsGroupBox.Size = new System.Drawing.Size(540, 123);
            this.SearchOptionsGroupBox.TabIndex = 0;
            this.SearchOptionsGroupBox.TabStop = false;
            this.SearchOptionsGroupBox.Text = "Search Options";
            // 
            // SearchNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchGroupBox);
            this.Name = "SearchNode";
            this.Size = new System.Drawing.Size(546, 524);
            this.SearchGroupBox.ResumeLayout(false);
            this.NuixSearchTopSplitContainer.Panel1.ResumeLayout(false);
            this.NuixSearchTopSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NuixSearchTopSplitContainer)).EndInit();
            this.NuixSearchTopSplitContainer.ResumeLayout(false);
            this.NuixSearchNestedSplitContainer.Panel1.ResumeLayout(false);
            this.NuixSearchNestedSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NuixSearchNestedSplitContainer)).EndInit();
            this.NuixSearchNestedSplitContainer.ResumeLayout(false);
            this.NuixSearchResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NuixSearchResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.SplitContainer NuixSearchTopSplitContainer;
        private System.Windows.Forms.RichTextBox NuixQueryRichTextBox;
        private System.Windows.Forms.SplitContainer NuixSearchNestedSplitContainer;
        private System.Windows.Forms.GroupBox SearchOptionsGroupBox;
        private System.Windows.Forms.GroupBox NuixSearchResultsGroupBox;
        private System.Windows.Forms.DataGridView NuixSearchResultsDataGridView;
    }
}
