using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesforceOrgManager.Model;

namespace SalesforceOrgManager.View
{
    public partial class TestManager : Form
    {
        public TestManager(List<TestResult> tr, List<ItemCodeCoverage> iccClass, List<ItemCodeCoverage> iccTrigger)
        {
            InitializeComponent();
            dataGridResults.DataSource = tr;
            dataGridResults.Columns["ApexTestClassId"].Visible = false;
            dataGridResults.CellFormatting += DataGridResults_CellFormatting;

            dataGridClassCoverage.DataSource = iccClass;
            dataGridClassCoverage.Columns["ItemId"].Visible = false;
            dataGridClassCoverage.Columns["Coverage"].Visible = false;
            dataGridClassCoverage.Columns["IsTrigger"].Visible = false;

            dataGridTriggerCoverage.DataSource = iccTrigger;
            dataGridTriggerCoverage.Columns["ItemId"].Visible = false;
            dataGridTriggerCoverage.Columns["Coverage"].Visible = false;
            dataGridTriggerCoverage.Columns["IsTrigger"].Visible = false;
        }
        private void DataGridResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.Equals("Pass"))
            {
                e.CellStyle.BackColor = Color.Green;
            }
            if (e.Value.Equals("Fail"))
            {
                e.CellStyle.BackColor = Color.DarkGray;
            }
        }
    }
}
