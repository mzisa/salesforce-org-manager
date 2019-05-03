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
            Program.createApexTriggerAsync(this);
        }
    }
}
