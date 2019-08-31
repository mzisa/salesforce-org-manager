using System;
using System.Windows.Forms;

namespace SalesforceOrgManager.View
{
    public partial class BoxCreazioneTrigger : Form
    {
        public BoxCreazioneTrigger()
        {
            InitializeComponent();
            this.txtItemName.Text = "New Item name...";
            this.cmbObjects.DataSource = Program.retrieveOrgEntities();
        }
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Name cannnot be empty", "Trigger creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbObjects.SelectedIndex == -1)
            {
                MessageBox.Show("Trigger must be related to a given object", "Trigger creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.createApexTriggerAsync(this);
        }
    }
}
