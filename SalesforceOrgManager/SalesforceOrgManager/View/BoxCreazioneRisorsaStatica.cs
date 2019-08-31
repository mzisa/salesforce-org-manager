using System;
using System.Windows.Forms;

namespace SalesforceOrgManager.View
{
    public partial class BoxCreazioneRisorsaStatica : Form
    {
        public BoxCreazioneRisorsaStatica()
        {
            InitializeComponent();
            this.txtItemName.Text = "New Item name...";
        }
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Name cannnot be empty", "Static resource creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.createApexStaticResourceAsync(this);
            }
        }
    }
}
