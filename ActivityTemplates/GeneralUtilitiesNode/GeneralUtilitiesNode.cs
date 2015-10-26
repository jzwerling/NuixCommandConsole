using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuix.ActivityTemplates.GeneralUtilitiesNode
{
    public partial class GeneralUtilitiesNode : UserControl
    {
        private GeneralUtilitiesNode() { }
        private NuixCommandConsole NuixCommandConsole;
        public GeneralUtilitiesNode(NuixCommandConsole NuixCommandConsole)
        {
            InitializeComponent();
            this.NuixCommandConsole = NuixCommandConsole;
        }
    }
}
