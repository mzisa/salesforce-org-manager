using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SalesforceOrgManager.Model;

namespace SalesforceOrgManager.View
{
    public partial class BoxSettings : Form
    {
        public BoxSettings()
        {
            InitializeComponent();
            if (ShoppingList.workspaces != null) {lstWorkspace.Items.AddRange(ShoppingList.workspaces);}
            lstBoxRight.Items.AddRange(ShoppingList.defaultProjectContent);
            cmbLoginGroup.Items.AddRange(ShoppingList.logins.Keys.ToArray());

            if (File.Exists(Application.StartupPath + "\\logins.crypt"))
            {
                chkUseEncryption.Checked = true;
            }
            else
            {
                chkUseEncryption.Checked = false;
            }
        }

        // Events management
        private void btnLeftToRight_Click(object sender, EventArgs e)
        {
            foreach(int index in lstBoxLeft.SelectedIndices)
            {
                lstBoxRight.Items.Add(lstBoxLeft.Items[index]);
                lstBoxLeft.Items.RemoveAt(index);
            }
        }
        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            foreach (int index in lstBoxRight.SelectedIndices)
            {
                lstBoxLeft.Items.Add(lstBoxRight.Items[index]);
                lstBoxRight.Items.RemoveAt(index);
            }
        }
        private void btnAddWorkspace_Click(object sender, EventArgs e)
        {
            if (!lstWorkspace.Items.Contains(txtItemName.Text))
            {
                if (Program.directoryExists(txtItemName.Text))
                {
                    object[] backup = ShoppingList.workspaces;
                    List<object> workspacesList = ShoppingList.workspaces.ToList<object>();
                    workspacesList.Add(txtItemName.Text);
                    ShoppingList.workspaces = workspacesList.ToArray();

                    if (Program.setConfigRecord(ShoppingList.workspaces, "workspaces", "orgConfig", false, null))
                    {
                        lstWorkspace.Items.Add(txtItemName.Text);
                        ShoppingList.principalePointer.cmbWorkspace.DataSource = ShoppingList.workspaces;
                    }
                    else
                    {
                        ShoppingList.workspaces = backup;
                    }
                }
                else
                {
                    MessageBox.Show("Workspace path does not exist",
                      "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Workspace already present in the list",
                    "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRemoveWorkspace_Click(object sender, EventArgs e)
        {
            if (Program.directoryExists(lstWorkspace.SelectedItem.ToString()))
            {
                object[] backup = ShoppingList.workspaces;
                List<object> workspacesList = ShoppingList.workspaces.ToList<object>();
                workspacesList.Remove(lstWorkspace.SelectedItem.ToString());
                ShoppingList.workspaces = workspacesList.ToArray();

                if (Program.setConfigRecord(ShoppingList.workspaces, "workspaces", "orgConfig", false, null))
                {
                    lstWorkspace.Items.Remove(lstWorkspace.SelectedItem);
                    ShoppingList.principalePointer.mainInit();
                }
                else
                {
                    ShoppingList.workspaces = backup;
                }
            }
            else
            {
                MessageBox.Show("Workspace path does not exist",
                  "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void lstWorkspace_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveWorkspace.Enabled = (lstWorkspace.SelectedItems.Count > 0) ? true : false;
        }
        private void cmbLoginGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLoginGroup.Enabled = true;
            txtLoginGroup.Text = cmbLoginGroup.SelectedItem.ToString();

            cmdCancelLoginGroup.Enabled = true;
            cmdSaveLoginGroup.Enabled = false;
            cmdDeleteLoginGroup.Enabled = true;
            cmdManageLogins.Enabled = true;
        }
        private void cmdCancelLogin_Click(object sender, EventArgs e)
        {
            disableLoginManagement();
        }
        private void cmdCancelLoginGroup_Click(object sender, EventArgs e)
        {
            resetLoginGroup();
        }
        private void cmdCreateNewLoginGroup_Click(object sender, EventArgs e)
        {
            cmdDeleteLoginGroup.Enabled = false;
            cmdManageLogins.Enabled = false;
            cmdCancelLoginGroup.Enabled = true;
            cmdSaveLoginGroup.Enabled = true;
            cmbLoginGroup.Text = "Select login group";
            cmbLoginGroup.Enabled = false;
            txtLoginGroup.Enabled = true;
        }
        private void cmdSaveLoginGroup_Click(object sender, EventArgs e)
        {
            if (txtLoginGroup.Text == "")
            {
                MessageBox.Show("Please provide login group name",
                    "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (chkUseEncryption.Checked && txtEncryptKey.Text == "")
                {
                    MessageBox.Show("Please provide password to encrypt credentials",
                        "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Dictionary<string, object> temp = ShoppingList.logins;
                    temp.Add(txtLoginGroup.Text, new List<dynamic>());
                    if (Program.setConfigRecord(temp, "loginGroups", "logins", chkUseEncryption.Checked, txtEncryptKey.Text))
                    {
                        ShoppingList.logins = temp;
                        resetLoginGroup();
                        MessageBox.Show("Login group was created successfully",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login group was not created successfully",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        private void cmdDeleteLoginGroup_Click(object sender, EventArgs e)
        {
            if (txtLoginGroup.Text == "")
            {
                MessageBox.Show("Please provide login group name",
                    "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (chkUseEncryption.Checked && txtEncryptKey.Text == "")
                {
                    MessageBox.Show("Please provide password to encrypt credentials",
                        "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Dictionary<string, object> temp = ShoppingList.logins;
                    temp.Remove(cmbLoginGroup.SelectedItem.ToString());
                    if (Program.setConfigRecord(temp, "loginGroups", "logins", chkUseEncryption.Checked, txtEncryptKey.Text))
                    {
                        ShoppingList.logins = temp;
                        resetLoginGroup();
                        MessageBox.Show("Login group was deleted successfully",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login group was not deleted successfully",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        private void cmdManageLogins_Click(object sender, EventArgs e)
        {
            resetLoginManagement();
        }
        private void cmbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            object[] loginEntries = ((IEnumerable<object>)ShoppingList.logins[cmbLoginGroup.SelectedItem.ToString()]).ToArray();
            foreach (object o in loginEntries)
            {
                Dictionary<string, object> loginEntry = (Dictionary<string, object>)o;
                if (loginEntry.Values.Contains(cmbLogin.SelectedItem))
                {
                    txtUsername.Text = loginEntry["username"].ToString();
                    txtPassword.Text = loginEntry["password"].ToString();
                    txtToken.Text = loginEntry["token"].ToString();
                    chkIsDefault.Checked = (bool)loginEntry["default"];
                    chkIsSandbox.Checked = (bool)loginEntry["sandbox"];
                }
            }
            cmdCreateNewLogin.Enabled = false;
            cmdSaveLogin.Enabled = true;
            cmdDeleteLogin.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtToken.Enabled = true;
            chkIsDefault.Enabled = true;
            chkIsSandbox.Enabled = true;
        }
        private void cmdDeleteLogin_Click(object sender, EventArgs e)
        {
            if (chkUseEncryption.Checked && txtEncryptKey.Text == "")
            {
                MessageBox.Show("Please provide password to encrypt credentials",
                    "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dictionary<string, object> backup = ShoppingList.logins;
                Dictionary<string, object> workingCopy = ShoppingList.logins;

                object[] loginEntries = ((IEnumerable<object>)workingCopy[cmbLoginGroup.SelectedItem.ToString()]).ToArray();

                object loginsToKeep = from object x in loginEntries
                                      where !((Dictionary<string, object>)x)["username"].Equals(cmbLogin.SelectedItem)
                                      select x;

                workingCopy[cmbLoginGroup.SelectedItem.ToString()] = ((IEnumerable<object>)loginsToKeep).ToArray();

                if (Program.setConfigRecord(workingCopy, "loginGroups", "logins", chkUseEncryption.Checked, txtEncryptKey.Text))
                {
                    cmbLogin.Items.Clear();
                    object[] loginsIntoGroup = (object[])workingCopy[cmbLoginGroup.SelectedItem.ToString()];
                    foreach (object o in loginsIntoGroup)
                    {
                        Dictionary<string, object> loginEntry = (Dictionary<string, object>)o;
                        cmbLogin.Items.Add(loginEntry["username"]);
                    }
                    resetLoginManagement();
                    MessageBox.Show("Login entry was deleted successfully",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShoppingList.logins = backup;
                    MessageBox.Show("An error occurred while trying to delete the login entry",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void cmdSaveLogin_Click(object sender, EventArgs e)
        {
            if (chkUseEncryption.Checked && txtEncryptKey.Text == "")
            {
                MessageBox.Show("Please provide password to encrypt credentials",
                    "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtUsername.Text == "" || txtPassword.Text == "" || txtToken.Text == "")
                {
                    MessageBox.Show("Username, password or token is missing",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool isInsert = (cmbLogin.Enabled == false) ? true : false;
                Dictionary<string, object> workingCopy = ShoppingList.logins;
                Dictionary<string, object> loginEntry = new Dictionary<string, object>();
                loginEntry.Add("username", txtUsername.Text);
                loginEntry.Add("password", txtPassword.Text);
                loginEntry.Add("token", txtToken.Text);
                loginEntry.Add("default", chkIsDefault.Checked);
                loginEntry.Add("sandbox", chkIsSandbox.Checked);

                // if a default login credentials is set we need to reset the default attribute to FALSE for all login occurrences -- START
                if (chkIsDefault.Checked)
                {
                    foreach (string key in workingCopy.Keys)
                    {
                        object[] group = ((IEnumerable<object>)workingCopy[key]).ToArray();
                        foreach (object grp in group)
                        {
                            Dictionary<string, object> loginOccurrence = (Dictionary<string, object>)grp;
                            loginOccurrence["default"] = false;
                        }
                    }
                }
                // if a default login credentials is set we need to reset the default attribute to FALSE for all login occurrences -- END
                List<object> loginEntries = ((IEnumerable<object>)workingCopy[cmbLoginGroup.SelectedItem.ToString()]).ToList<object>();

                if (cmbLogin.Enabled == false)
                {
                    // we are creating a new login entry
                    loginEntries.Add(loginEntry);
                    workingCopy[cmbLoginGroup.SelectedItem.ToString()] = loginEntries;
                }
                else
                {
                    // we are editing an existing login entry
                    object loginsToKeep = from object x in loginEntries
                                          where !((Dictionary<string, object>)x)["username"].Equals(cmbLogin.SelectedItem)
                                          select x;

                    object[] loginsK = ((IEnumerable<object>)loginsToKeep).ToArray();

                    if (loginsK.Count() > 0)
                    {
                        workingCopy.Remove(cmbLoginGroup.SelectedItem.ToString());
                        workingCopy.Add(cmbLoginGroup.SelectedItem.ToString(), new List<dynamic>());
                        List<dynamic> temp = (List<dynamic>)workingCopy[cmbLoginGroup.SelectedItem.ToString()];
                        temp.AddRange(loginsK);
                        temp.Add(loginEntry);
                        workingCopy[cmbLoginGroup.SelectedItem.ToString()] = temp;
                    }
                    else
                    {
                        workingCopy.Remove(cmbLoginGroup.SelectedItem.ToString());
                        workingCopy.Add(cmbLoginGroup.SelectedItem.ToString(), new List<dynamic>());
                        List<dynamic> temp = (List<dynamic>)workingCopy[cmbLoginGroup.SelectedItem.ToString()];
                        temp.Add(loginEntry);
                        workingCopy[cmbLoginGroup.SelectedItem.ToString()] = temp;
                    }
                }

                // Sync file
                if (Program.setConfigRecord(workingCopy, "loginGroups", "logins", chkUseEncryption.Checked, txtEncryptKey.Text))
                {
                    if (isInsert)
                    {
                        MessageBox.Show("Login entry was added successfully",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login entry was updated successfully",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // All Ok so sync the project variable
                    ShoppingList.logins = workingCopy;
                }
                else
                {
                    // Ko so rollback project variabile to previous value
                    workingCopy = ShoppingList.logins;
                    MessageBox.Show("An error occurred while trying to update the login entry",
                            "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void cmdCreateNewLogin_Click(object sender, EventArgs e)
        {
            cmdCreateNewLogin.Enabled = false;
            cmdSaveLogin.Enabled = true;
            cmbLogin.Enabled = false;
            cmbLogin.Text = "Select login";
            txtUsername.Enabled = true;
            txtUsername.Text = "";
            txtPassword.Enabled = true;
            txtPassword.Text = "";
            txtToken.Enabled = true;
            txtToken.Text = "";
            chkIsDefault.Enabled = true;
            chkIsDefault.Checked = false;
            chkIsSandbox.Checked = true;
        }

        // Additional logic
        private void resetLoginGroup()
        {
            txtLoginGroup.Enabled = false;
            txtLoginGroup.Text = "";
            cmdSaveLoginGroup.Enabled = false;
            cmdDeleteLoginGroup.Enabled = false;
            cmdManageLogins.Enabled = false;
            cmdCancelLoginGroup.Enabled = false;

            cmbLoginGroup.Items.Clear();
            cmbLoginGroup.Items.AddRange(ShoppingList.logins.Keys.ToArray());
            cmbLoginGroup.Enabled = true;
            cmbLoginGroup.Text = "Select login group";
        }
        private void disableLoginManagement()
        {
            cmdCreateNewLogin.Enabled = true;
            cmdSaveLogin.Enabled = false;
            cmdDeleteLogin.Enabled = false;
            cmbLogin.Text = "Select login";
            txtUsername.Text = "";
            txtUsername.Enabled = false;
            txtPassword.Text = "";
            txtPassword.Enabled = false;
            txtToken.Text = "";
            txtToken.Enabled = false;
            chkIsDefault.Enabled = false;
            chkIsDefault.Checked = false;
            chkIsSandbox.Enabled = false;
            chkIsSandbox.Checked = false;
            grpLoginManagement.Text = "Login management";
            grpLoginManagement.Enabled = false;
            grpLoginGroupManagement.Enabled = true;
        }
        private void resetLoginManagement()
        {
            grpLoginGroupManagement.Enabled = false;
            grpLoginManagement.Enabled = true;
            grpLoginManagement.Text += " " + cmbLoginGroup.SelectedItem.ToString();
            cmbLogin.Items.Clear();

            object[] loginsIntoGroup = ((IEnumerable<object>)ShoppingList.logins[cmbLoginGroup.SelectedItem.ToString()]).ToArray();
            foreach (object o in loginsIntoGroup)
            {
                Dictionary<string, object> loginEntry = (Dictionary<string, object>)o;
                cmbLogin.Items.Add(loginEntry["username"]);
            }
            cmbLogin.Text = "Select login";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtToken.Text = "";
            chkIsSandbox.Checked = true;
            chkIsDefault.Checked = false;

            if (cmbLogin.Items.Count == 0)
            {
                cmbLogin.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtToken.Enabled = false;
                chkIsDefault.Enabled = false;
                chkIsSandbox.Enabled = false;
            }
            else
            {
                cmbLogin.Enabled = true;
            }
        }
        private void chkUseEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseEncryption.Checked == false)
            {
                MessageBox.Show("Warning: your credentials will be stored unencrypted", "Workspace manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}