using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nuix.ActivityTemplates.IntelligentMigrationActivitiesNode
{
    public partial class IntelligentMigrationActivitiesNode : UserControl
    {
        private IntelligentMigrationActivitiesNode() { }
        private NuixCommandConsole NuixCommandConsole;
        public IntelligentMigrationActivitiesNode(NuixCommandConsole NuixCommandConsole)
        {
            InitializeComponent();
            this.NuixCommandConsole = NuixCommandConsole;
        }
    }
}
