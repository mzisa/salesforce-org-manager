using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesforceOrgManager.View
{
    public partial class BoxDeployToServer : Form
    {
        public BoxDeployToServer()
        {
            InitializeComponent();
        }

        private void btnRunDeploy_Click(object sender, EventArgs e)
        {
            Program.deployToServer(this);
        }
    }
}
