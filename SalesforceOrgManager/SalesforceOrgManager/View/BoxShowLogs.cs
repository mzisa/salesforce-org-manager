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
    public partial class BoxShowLogs : Form
    {
        public BoxShowLogs()
        {
            InitializeComponent();
            dataGridLogs.DataSource = Program.retrieveApexDebugLogList();
            dataGridLogs.Columns["Body"].Visible = false;
            dataGridLogs.CellClick += DataGridLogs_CellClick;
        }
        private void DataGridLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                string logToDisplay = Convert.ToString(((DataGridView)sender).SelectedRows[0].Cells[6].Value);
                this.txtExecutionLog.Text = logToDisplay;
            }
        }
    }
}
