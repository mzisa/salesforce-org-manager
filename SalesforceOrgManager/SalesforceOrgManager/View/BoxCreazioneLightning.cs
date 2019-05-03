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
    public partial class BoxCreazioneLightning : Form
    {
        public BoxCreazioneLightning()
        {
            InitializeComponent();
        }
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            if (radioApp.Checked) {Program.createLightningItemAsync(this,"APPLICATION");}
            if (radioComponent.Checked) {Program.createLightningItemAsync(this,"COMPONENT");}
            if (radioEvent.Checked) {Program.createLightningItemAsync(this,"EVENT");}
            if (radioInterface.Checked) {Program.createLightningItemAsync(this,"INTERFACE");}
        }
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
