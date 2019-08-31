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
    public partial class BoxCreazioneLwc : Form
    {
        public BoxCreazioneLwc()
        {
            InitializeComponent();
        }
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtItemName.Text) || String.IsNullOrWhiteSpace(txtItemDescription.Text))
            {
                MessageBox.Show("Name or description cannnot be empty", "Lightning web item creation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                Program.createLwcAsync(this);
            }
        }
        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
