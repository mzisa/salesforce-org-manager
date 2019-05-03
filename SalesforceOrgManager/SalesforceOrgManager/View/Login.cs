using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using SalesforceOrgManager.Model;

namespace SalesforceOrgManager.View
{
    public partial class frmLogin : Form
    {
        bool sandbox = true;
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public bool Sandbox
        {
            get { return sandbox; }
            set { sandbox = value; }
        }
        public frmLogin()
        {
            InitializeComponent();

            // if a default login is set we can try to log automatically in the selected project -- START
            Dictionary<string, object> logins = ShoppingList.logins;
            string[] loginGroupKeys = new string[logins.Keys.Count];
            logins.Keys.CopyTo(loginGroupKeys,0);
            cmbLoginGroup.Items.AddRange(loginGroupKeys);

            foreach (string key in logins.Keys)
            {
                List<dynamic> group = ((IEnumerable<object>)logins[key]).ToList<object>();
                foreach (object grp in group)
                {
                    Dictionary<string, object> loginOccurrence = (Dictionary<string, object>)grp;
                    if ((bool)loginOccurrence["default"])
                    {
                        Username = loginOccurrence["username"].ToString();
                        Password = loginOccurrence["password"].ToString() + loginOccurrence["token"].ToString();
                        Sandbox = (bool) loginOccurrence["sandbox"];
                        btnLogin_Click(this, null);
                    }
                }
            }
            // if a default login is set we can try to log automatically in the selected project -- END
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            startAnimation();
            bool result = await Task<bool>.Run(() => runLoginProcedure());

            if (result)
            {
                OrgTree orgTree = await Task<OrgTree>.Run(() => new OrgTree());
                ShoppingList.orgTreePointer = orgTree;
                orgTree.Show();
                endAnimation();
                this.Close();
            }
            else
            {
                endAnimation();
                lblLoginFailed.Show();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShoppingList.destroy();
            this.Close();
            ShoppingList.principalePointer.Show();
        }
        private void startAnimation()
        {
            lblLoginFailed.Hide();
            btnLogin.Enabled = false;
            btnCancel.Enabled = false;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
        }
        private void endAnimation()
        {
            btnLogin.Enabled = true;
            btnCancel.Enabled = true;
            progressBar1.Visible = false;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }
        private bool runLoginProcedure()
        {
            if (Program.doConnect(Username, Password, Sandbox))
            {
                if (ShoppingList.currentOperation == (int)ShoppingList.currentOp.Create)
                {
                    Program.createNewProject();
                    Program.createManifestForNewProject();
                    Directory.CreateDirectory(ShoppingList.projectRootDir + "\\config");
                }
                // Write login credentials to project
                Dictionary<string, object> credRecord = new Dictionary<string, object>();
                credRecord.Add("user", Username);
                credRecord.Add("secret", Password);
                credRecord.Add("sandbox", Sandbox);

                JavaScriptSerializer jss = new JavaScriptSerializer();
                jss.MaxJsonLength = Int32.MaxValue;
                byte[] encodedContent = System.Text.Encoding.UTF8.GetBytes(jss.Serialize(credRecord));
                File.WriteAllBytes(ShoppingList.projectRootDir + "\\config\\cred.json", encodedContent);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void cmbLoginGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLogin.Items.Clear();
            cmbLogin.Text = "Select login";
            List<dynamic> loginsIntoGroup = ((IEnumerable<object>)ShoppingList.logins[cmbLoginGroup.SelectedItem.ToString()]).ToList<object>();
            for (int counter = 0; counter < loginsIntoGroup.Count; counter++)
            {
                Dictionary<string, object> loginEntry = (Dictionary<string, object>)loginsIntoGroup[counter];
                cmbLogin.Items.Add(loginsIntoGroup[counter]["username"]);
            }
        }
        private void cmbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<dynamic> loginEntries = ((IEnumerable<object>)ShoppingList.logins[cmbLoginGroup.SelectedItem.ToString()]).ToList<object>();
            List<object> selectedLogin = ((IEnumerable<object>)from object x in loginEntries
                where ((Dictionary<string, object>)x)["username"].Equals(cmbLogin.SelectedItem)
                select x).ToList<object>();

            Dictionary<string, object> myLogin = selectedLogin[0] as Dictionary<string, object>;

            Username = myLogin["username"].ToString();
            Password = myLogin["password"].ToString() + myLogin["token"].ToString();
            Sandbox = (bool) myLogin["sandbox"];
        }
    }
}
