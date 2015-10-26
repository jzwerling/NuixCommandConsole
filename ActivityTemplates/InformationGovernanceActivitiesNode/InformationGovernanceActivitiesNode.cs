using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuix.ActivityTemplates.InformationGovernanceActivitiesNode
{
    public partial class InformationGovernanceActivitiesNode : UserControl
    {
        private InformationGovernanceActivitiesNode() { }
        private NuixCommandConsole NuixCommandConsole;
        public InformationGovernanceActivitiesNode(NuixCommandConsole NuixCommandConsole)
        {
            InitializeComponent();
            this.NuixCommandConsole = NuixCommandConsole;
        }
    }
}
