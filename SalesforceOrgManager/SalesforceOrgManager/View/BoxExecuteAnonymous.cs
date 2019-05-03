using System;
using System.Windows.Forms;
using SalesforceOrgManager.Model;

namespace SalesforceOrgManager.View
{
    public partial class BoxExecuteAnonymous : Form
    {
        public BoxExecuteAnonymous()
        {
            InitializeComponent();
            txtExecuteAnonymous.Text = "";
        }
        private void btnRunApex_Click(object sender, EventArgs e)
        {
            ApexExecutionResult result = Program.runApexCode(txtExecuteAnonymous.Text);
            if (result.Success)
            {
                txtExecutionResult.Text = "Apex code run successfully. Check Apex Log for further details";
                txtExecutionLog.Text = (result.LogBody == null) ? "Log file missing..." : result.LogBody;
            }
            else
            {
                txtExecutionLog.Text = "";
                txtExecutionResult.Text = "Apex code FAILED. See stack trace below for further details\r\n";
                txtExecutionResult.Text += result.CompileProblem + "\r\n";
            }
        }
    }
}
