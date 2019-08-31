using System;
using System.Windows.Forms;

namespace SalesforceOrgManager.View
{
    public partial class BoxCreazioneVisualforce : Form
    {
        public BoxCreazioneVisualforce()
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
                MessageBox.Show("Name cannnot be empty", "Trigger creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.createApexPageAsync(this);
            }
        }
    }
}
