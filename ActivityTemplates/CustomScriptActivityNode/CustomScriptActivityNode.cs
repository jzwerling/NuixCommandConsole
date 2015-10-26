using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalRune.Windows.TextEditor.Highlighting;

namespace Nuix.ActivityTemplates.CustomScriptActivityNode
{
    public partial class CustomScriptActivityNode : UserControl
    {
        private CustomScriptActivityNode() { }
        private NuixCommandConsole NuixCommandConsole;
        public CustomScriptActivityNode(NuixCommandConsole NuixCommandConsole)
        {
            InitializeComponent();
            this.NuixCommandConsole = NuixCommandConsole;
            HighlightingManager.Manager.AddSyntaxModeFileProvider(new FileSyntaxModeProvider("Resources"));
            DigitalRuneScriptEditor.Document.HighlightingStrategy = HighlightingManager.Manager.FindHighlighter("Ruby");
            CustomScriptActivityRunLocalRadioButton.Checked = true;
        }

        private void CustomScriptActivityRunActivityButton_Click(object sender, EventArgs e)
        {
            //NuixCommandConsole.StartActivity(DigitalRuneScriptEditor.Text, CustomScriptActivityCommandLineSwitches.Text);
        }

        private void CustomScriptActivitySaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CustomScriptActivityTargetChanged(object sender, EventArgs e)
        {
            if(CustomScriptActivityRunLocalRadioButton.Checked) 
            {
                CustomScriptActivityRemoteTargetComboBox.Enabled = false;
            }
            else
            {
                CustomScriptActivityRemoteTargetComboBox.Enabled = true;
            }
        }
    }
}
