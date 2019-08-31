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
            cmbVersions.SelectedIndex = cmbVersions.Items.Count - 1;
            chkDefinitionType.SetItemChecked(0, true);
            chkDefinitionType.SetItemChecked(1, true);
            chkDefinitionType.SetItemChecked(2, true);
        }
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtItemName.Text) || String.IsNullOrWhiteSpace(txtItemDescription.Text))
            {
                MessageBox.Show("Name or description cannnot be empty", "Lightning item creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radioApp.Checked) { Program.createLightningItemAsync(this, "APPLICATION"); }
                if (radioComponent.Checked) { Program.createLightningItemAsync(this, "COMPONENT"); }
                if (radioEvent.Checked) { Program.createLightningItemAsync(this, "EVENT"); }
                if (radioInterface.Checked) { Program.createLightningItemAsync(this, "INTERFACE"); }
            }
        }
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
