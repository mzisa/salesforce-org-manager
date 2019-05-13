namespace SalesforceOrgManager.View
{
    partial class BoxSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lstWorkspace = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddWorkspace = new System.Windows.Forms.Button();
            this.btnRemoveWorkspace = new System.Windows.Forms.Button();
            this.lstBoxLeft = new System.Windows.Forms.ListBox();
            this.lstBoxRight = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRightToLeft = new System.Windows.Forms.Button();
            this.btnLeftToRight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEncryptKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkUseEncryption = new System.Windows.Forms.CheckBox();
            this.grpLoginManagement = new System.Windows.Forms.GroupBox();
            this.chkIsSandbox = new System.Windows.Forms.CheckBox();
            this.chkIsDefault = new System.Windows.Forms.CheckBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.cmdDeleteLogin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdSaveLogin = new System.Windows.Forms.Button();
            this.cmdCancelLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCreateNewLogin = new System.Windows.Forms.Button();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLoginGroupManagement = new System.Windows.Forms.GroupBox();
            this.cmdDeleteLoginGroup = new System.Windows.Forms.Button();
            this.cmdManageLogins = new System.Windows.Forms.Button();
            this.cmdSaveLoginGroup = new System.Windows.Forms.Button();
            this.cmdCancelLoginGroup = new System.Windows.Forms.Button();
            this.txtLoginGroup = new System.Windows.Forms.TextBox();
            this.cmdCreateNewLoginGroup = new System.Windows.Forms.Button();
            this.cmbLoginGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpLoginManagement.SuspendLayout();
            this.grpLoginGroupManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Workspace Path";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(133, 22);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(294, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // lstWorkspace
            // 
            this.lstWorkspace.FormattingEnabled = true;
            this.lstWorkspace.Location = new System.Drawing.Point(14, 146);
            this.lstWorkspace.Margin = new System.Windows.Forms.Padding(2);
            this.lstWorkspace.Name = "lstWorkspace";
            this.lstWorkspace.Size = new System.Drawing.Size(461, 108);
            this.lstWorkspace.TabIndex = 4;
            this.lstWorkspace.SelectedIndexChanged += new System.EventHandler(this.lstWorkspace_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Workspace List";
            // 
            // btnAddWorkspace
            // 
            this.btnAddWorkspace.Location = new System.Drawing.Point(14, 59);
            this.btnAddWorkspace.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWorkspace.Name = "btnAddWorkspace";
            this.btnAddWorkspace.Size = new System.Drawing.Size(461, 41);
            this.btnAddWorkspace.TabIndex = 3;
            this.btnAddWorkspace.Text = "ADD NEW WORKSPACE";
            this.btnAddWorkspace.UseVisualStyleBackColor = true;
            this.btnAddWorkspace.Click += new System.EventHandler(this.btnAddWorkspace_Click);
            // 
            // btnRemoveWorkspace
            // 
            this.btnRemoveWorkspace.Enabled = false;
            this.btnRemoveWorkspace.Location = new System.Drawing.Point(14, 274);
            this.btnRemoveWorkspace.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveWorkspace.Name = "btnRemoveWorkspace";
            this.btnRemoveWorkspace.Size = new System.Drawing.Size(461, 41);
            this.btnRemoveWorkspace.TabIndex = 5;
            this.btnRemoveWorkspace.Text = "REMOVE SELECTED WORKSPACE";
            this.btnRemoveWorkspace.UseVisualStyleBackColor = true;
            this.btnRemoveWorkspace.Click += new System.EventHandler(this.btnRemoveWorkspace_Click);
            // 
            // lstBoxLeft
            // 
            this.lstBoxLeft.FormattingEnabled = true;
            this.lstBoxLeft.Location = new System.Drawing.Point(13, 35);
            this.lstBoxLeft.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxLeft.Name = "lstBoxLeft";
            this.lstBoxLeft.Size = new System.Drawing.Size(167, 121);
            this.lstBoxLeft.TabIndex = 6;
            // 
            // lstBoxRight
            // 
            this.lstBoxRight.FormattingEnabled = true;
            this.lstBoxRight.Location = new System.Drawing.Point(280, 35);
            this.lstBoxRight.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxRight.Name = "lstBoxRight";
            this.lstBoxRight.Size = new System.Drawing.Size(167, 121);
            this.lstBoxRight.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRightToLeft);
            this.groupBox1.Controls.Add(this.btnLeftToRight);
            this.groupBox1.Controls.Add(this.lstBoxRight);
            this.groupBox1.Controls.Add(this.lstBoxLeft);
            this.groupBox1.Location = new System.Drawing.Point(14, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(461, 169);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default metadata for new project";
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(191, 106);
            this.btnRightToLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(75, 36);
            this.btnRightToLeft.TabIndex = 8;
            this.btnRightToLeft.Text = "<<";
            this.btnRightToLeft.UseVisualStyleBackColor = true;
            this.btnRightToLeft.Click += new System.EventHandler(this.btnRightToLeft_Click);
            // 
            // btnLeftToRight
            // 
            this.btnLeftToRight.Location = new System.Drawing.Point(191, 46);
            this.btnLeftToRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(75, 36);
            this.btnLeftToRight.TabIndex = 7;
            this.btnLeftToRight.Text = ">>";
            this.btnLeftToRight.UseVisualStyleBackColor = true;
            this.btnLeftToRight.Click += new System.EventHandler(this.btnLeftToRight_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectPath);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRemoveWorkspace);
            this.groupBox2.Controls.Add(this.lstWorkspace);
            this.groupBox2.Controls.Add(this.btnAddWorkspace);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 511);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Workspaces configuration";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(433, 22);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(42, 23);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "-->";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEncryptKey);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.chkUseEncryption);
            this.groupBox3.Controls.Add(this.grpLoginManagement);
            this.groupBox3.Controls.Add(this.grpLoginGroupManagement);
            this.groupBox3.Location = new System.Drawing.Point(513, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 511);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keystore configuration";
            // 
            // txtEncryptKey
            // 
            this.txtEncryptKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptKey.Location = new System.Drawing.Point(301, 18);
            this.txtEncryptKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncryptKey.Name = "txtEncryptKey";
            this.txtEncryptKey.Size = new System.Drawing.Size(201, 26);
            this.txtEncryptKey.TabIndex = 12;
            this.txtEncryptKey.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Encrypt key";
            // 
            // chkUseEncryption
            // 
            this.chkUseEncryption.AutoSize = true;
            this.chkUseEncryption.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUseEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseEncryption.Location = new System.Drawing.Point(6, 22);
            this.chkUseEncryption.Name = "chkUseEncryption";
            this.chkUseEncryption.Size = new System.Drawing.Size(163, 24);
            this.chkUseEncryption.TabIndex = 11;
            this.chkUseEncryption.Text = "Encrypt credentials";
            this.chkUseEncryption.UseVisualStyleBackColor = true;
            this.chkUseEncryption.CheckedChanged += new System.EventHandler(this.chkUseEncryption_CheckedChanged);
            // 
            // grpLoginManagement
            // 
            this.grpLoginManagement.Controls.Add(this.chkIsSandbox);
            this.grpLoginManagement.Controls.Add(this.chkIsDefault);
            this.grpLoginManagement.Controls.Add(this.txtToken);
            this.grpLoginManagement.Controls.Add(this.cmdDeleteLogin);
            this.grpLoginManagement.Controls.Add(this.label7);
            this.grpLoginManagement.Controls.Add(this.cmdSaveLogin);
            this.grpLoginManagement.Controls.Add(this.cmdCancelLogin);
            this.grpLoginManagement.Controls.Add(this.txtPassword);
            this.grpLoginManagement.Controls.Add(this.label6);
            this.grpLoginManagement.Controls.Add(this.txtUsername);
            this.grpLoginManagement.Controls.Add(this.label5);
            this.grpLoginManagement.Controls.Add(this.cmdCreateNewLogin);
            this.grpLoginManagement.Controls.Add(this.cmbLogin);
            this.grpLoginManagement.Controls.Add(this.label4);
            this.grpLoginManagement.Enabled = false;
            this.grpLoginManagement.Location = new System.Drawing.Point(6, 187);
            this.grpLoginManagement.Name = "grpLoginManagement";
            this.grpLoginManagement.Size = new System.Drawing.Size(496, 281);
            this.grpLoginManagement.TabIndex = 21;
            this.grpLoginManagement.TabStop = false;
            this.grpLoginManagement.Text = "Login management";
            // 
            // chkIsSandbox
            // 
            this.chkIsSandbox.AutoSize = true;
            this.chkIsSandbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsSandbox.Checked = true;
            this.chkIsSandbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsSandbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsSandbox.Location = new System.Drawing.Point(390, 191);
            this.chkIsSandbox.Name = "chkIsSandbox";
            this.chkIsSandbox.Size = new System.Drawing.Size(91, 24);
            this.chkIsSandbox.TabIndex = 28;
            this.chkIsSandbox.Text = "Sandbox";
            this.chkIsSandbox.UseVisualStyleBackColor = true;
            // 
            // chkIsDefault
            // 
            this.chkIsDefault.AutoSize = true;
            this.chkIsDefault.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsDefault.Location = new System.Drawing.Point(6, 191);
            this.chkIsDefault.Name = "chkIsDefault";
            this.chkIsDefault.Size = new System.Drawing.Size(131, 24);
            this.chkIsDefault.TabIndex = 27;
            this.chkIsDefault.Text = "Use as default";
            this.chkIsDefault.UseVisualStyleBackColor = true;
            // 
            // txtToken
            // 
            this.txtToken.Enabled = false;
            this.txtToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.Location = new System.Drawing.Point(122, 146);
            this.txtToken.Margin = new System.Windows.Forms.Padding(2);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(361, 26);
            this.txtToken.TabIndex = 26;
            this.txtToken.UseSystemPasswordChar = true;
            // 
            // cmdDeleteLogin
            // 
            this.cmdDeleteLogin.Enabled = false;
            this.cmdDeleteLogin.Location = new System.Drawing.Point(378, 232);
            this.cmdDeleteLogin.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDeleteLogin.Name = "cmdDeleteLogin";
            this.cmdDeleteLogin.Size = new System.Drawing.Size(104, 21);
            this.cmdDeleteLogin.TabIndex = 31;
            this.cmdDeleteLogin.Text = "DELETE";
            this.cmdDeleteLogin.UseVisualStyleBackColor = true;
            this.cmdDeleteLogin.Click += new System.EventHandler(this.cmdDeleteLogin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Security token";
            // 
            // cmdSaveLogin
            // 
            this.cmdSaveLogin.Enabled = false;
            this.cmdSaveLogin.Location = new System.Drawing.Point(195, 232);
            this.cmdSaveLogin.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSaveLogin.Name = "cmdSaveLogin";
            this.cmdSaveLogin.Size = new System.Drawing.Size(104, 21);
            this.cmdSaveLogin.TabIndex = 30;
            this.cmdSaveLogin.Text = "SAVE";
            this.cmdSaveLogin.UseVisualStyleBackColor = true;
            this.cmdSaveLogin.Click += new System.EventHandler(this.cmdSaveLogin_Click);
            // 
            // cmdCancelLogin
            // 
            this.cmdCancelLogin.Location = new System.Drawing.Point(12, 232);
            this.cmdCancelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelLogin.Name = "cmdCancelLogin";
            this.cmdCancelLogin.Size = new System.Drawing.Size(104, 21);
            this.cmdCancelLogin.TabIndex = 29;
            this.cmdCancelLogin.Text = "CANCEL";
            this.cmdCancelLogin.UseVisualStyleBackColor = true;
            this.cmdCancelLogin.Click += new System.EventHandler(this.cmdCancelLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(122, 100);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(361, 26);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(122, 57);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(361, 26);
            this.txtUsername.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username";
            // 
            // cmdCreateNewLogin
            // 
            this.cmdCreateNewLogin.Location = new System.Drawing.Point(5, 19);
            this.cmdCreateNewLogin.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCreateNewLogin.Name = "cmdCreateNewLogin";
            this.cmdCreateNewLogin.Size = new System.Drawing.Size(172, 21);
            this.cmdCreateNewLogin.TabIndex = 22;
            this.cmdCreateNewLogin.Text = "CREATE NEW LOGIN";
            this.cmdCreateNewLogin.UseVisualStyleBackColor = true;
            this.cmdCreateNewLogin.Click += new System.EventHandler(this.cmdCreateNewLogin_Click);
            // 
            // cmbLogin
            // 
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(239, 19);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(244, 21);
            this.cmbLogin.TabIndex = 23;
            this.cmbLogin.Text = "Select login";
            this.cmbLogin.SelectedIndexChanged += new System.EventHandler(this.cmbLogin_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "-OR-";
            // 
            // grpLoginGroupManagement
            // 
            this.grpLoginGroupManagement.Controls.Add(this.cmdDeleteLoginGroup);
            this.grpLoginGroupManagement.Controls.Add(this.cmdManageLogins);
            this.grpLoginGroupManagement.Controls.Add(this.cmdSaveLoginGroup);
            this.grpLoginGroupManagement.Controls.Add(this.cmdCancelLoginGroup);
            this.grpLoginGroupManagement.Controls.Add(this.txtLoginGroup);
            this.grpLoginGroupManagement.Controls.Add(this.cmdCreateNewLoginGroup);
            this.grpLoginGroupManagement.Controls.Add(this.cmbLoginGroup);
            this.grpLoginGroupManagement.Controls.Add(this.label3);
            this.grpLoginGroupManagement.Location = new System.Drawing.Point(6, 56);
            this.grpLoginGroupManagement.Name = "grpLoginGroupManagement";
            this.grpLoginGroupManagement.Size = new System.Drawing.Size(496, 118);
            this.grpLoginGroupManagement.TabIndex = 13;
            this.grpLoginGroupManagement.TabStop = false;
            this.grpLoginGroupManagement.Text = "Login group management";
            // 
            // cmdDeleteLoginGroup
            // 
            this.cmdDeleteLoginGroup.Enabled = false;
            this.cmdDeleteLoginGroup.Location = new System.Drawing.Point(253, 88);
            this.cmdDeleteLoginGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDeleteLoginGroup.Name = "cmdDeleteLoginGroup";
            this.cmdDeleteLoginGroup.Size = new System.Drawing.Size(104, 21);
            this.cmdDeleteLoginGroup.TabIndex = 19;
            this.cmdDeleteLoginGroup.Text = "DELETE";
            this.cmdDeleteLoginGroup.UseVisualStyleBackColor = true;
            this.cmdDeleteLoginGroup.Click += new System.EventHandler(this.cmdDeleteLoginGroup_Click);
            // 
            // cmdManageLogins
            // 
            this.cmdManageLogins.Enabled = false;
            this.cmdManageLogins.Location = new System.Drawing.Point(377, 88);
            this.cmdManageLogins.Margin = new System.Windows.Forms.Padding(2);
            this.cmdManageLogins.Name = "cmdManageLogins";
            this.cmdManageLogins.Size = new System.Drawing.Size(104, 21);
            this.cmdManageLogins.TabIndex = 20;
            this.cmdManageLogins.Text = "MANAGE LOGINS";
            this.cmdManageLogins.UseVisualStyleBackColor = true;
            this.cmdManageLogins.Click += new System.EventHandler(this.cmdManageLogins_Click);
            // 
            // cmdSaveLoginGroup
            // 
            this.cmdSaveLoginGroup.Enabled = false;
            this.cmdSaveLoginGroup.Location = new System.Drawing.Point(129, 88);
            this.cmdSaveLoginGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSaveLoginGroup.Name = "cmdSaveLoginGroup";
            this.cmdSaveLoginGroup.Size = new System.Drawing.Size(104, 21);
            this.cmdSaveLoginGroup.TabIndex = 18;
            this.cmdSaveLoginGroup.Text = "SAVE";
            this.cmdSaveLoginGroup.UseVisualStyleBackColor = true;
            this.cmdSaveLoginGroup.Click += new System.EventHandler(this.cmdSaveLoginGroup_Click);
            // 
            // cmdCancelLoginGroup
            // 
            this.cmdCancelLoginGroup.Enabled = false;
            this.cmdCancelLoginGroup.Location = new System.Drawing.Point(5, 88);
            this.cmdCancelLoginGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelLoginGroup.Name = "cmdCancelLoginGroup";
            this.cmdCancelLoginGroup.Size = new System.Drawing.Size(104, 21);
            this.cmdCancelLoginGroup.TabIndex = 17;
            this.cmdCancelLoginGroup.Text = "CANCEL";
            this.cmdCancelLoginGroup.UseVisualStyleBackColor = true;
            this.cmdCancelLoginGroup.Click += new System.EventHandler(this.cmdCancelLoginGroup_Click);
            // 
            // txtLoginGroup
            // 
            this.txtLoginGroup.Enabled = false;
            this.txtLoginGroup.Location = new System.Drawing.Point(5, 54);
            this.txtLoginGroup.Name = "txtLoginGroup";
            this.txtLoginGroup.Size = new System.Drawing.Size(478, 20);
            this.txtLoginGroup.TabIndex = 16;
            // 
            // cmdCreateNewLoginGroup
            // 
            this.cmdCreateNewLoginGroup.Location = new System.Drawing.Point(5, 18);
            this.cmdCreateNewLoginGroup.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCreateNewLoginGroup.Name = "cmdCreateNewLoginGroup";
            this.cmdCreateNewLoginGroup.Size = new System.Drawing.Size(172, 21);
            this.cmdCreateNewLoginGroup.TabIndex = 14;
            this.cmdCreateNewLoginGroup.Text = "CREATE NEW LOGIN GROUP";
            this.cmdCreateNewLoginGroup.UseVisualStyleBackColor = true;
            this.cmdCreateNewLoginGroup.Click += new System.EventHandler(this.cmdCreateNewLoginGroup_Click);
            // 
            // cmbLoginGroup
            // 
            this.cmbLoginGroup.FormattingEnabled = true;
            this.cmbLoginGroup.ItemHeight = 13;
            this.cmbLoginGroup.Location = new System.Drawing.Point(239, 18);
            this.cmbLoginGroup.Name = "cmbLoginGroup";
            this.cmbLoginGroup.Size = new System.Drawing.Size(244, 21);
            this.cmbLoginGroup.TabIndex = 15;
            this.cmbLoginGroup.Text = "Select login group";
            this.cmbLoginGroup.SelectedIndexChanged += new System.EventHandler(this.cmbLoginGroup_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "-OR-";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // BoxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 529);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BoxSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpLoginManagement.ResumeLayout(false);
            this.grpLoginManagement.PerformLayout();
            this.grpLoginGroupManagement.ResumeLayout(false);
            this.grpLoginGroupManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ListBox lstWorkspace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddWorkspace;
        private System.Windows.Forms.Button btnRemoveWorkspace;
        private System.Windows.Forms.ListBox lstBoxLeft;
        private System.Windows.Forms.ListBox lstBoxRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRightToLeft;
        private System.Windows.Forms.Button btnLeftToRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpLoginManagement;
        private System.Windows.Forms.GroupBox grpLoginGroupManagement;
        private System.Windows.Forms.Button cmdManageLogins;
        private System.Windows.Forms.Button cmdDeleteLogin;
        private System.Windows.Forms.Button cmdSaveLogin;
        private System.Windows.Forms.Button cmdCancelLogin;
        private System.Windows.Forms.TextBox txtLoginGroup;
        private System.Windows.Forms.Button cmdCreateNewLoginGroup;
        private System.Windows.Forms.ComboBox cmbLoginGroup;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCreateNewLogin;
        private System.Windows.Forms.ComboBox cmbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdDeleteLoginGroup;
        private System.Windows.Forms.Button cmdSaveLoginGroup;
        private System.Windows.Forms.Button cmdCancelLoginGroup;
        private System.Windows.Forms.CheckBox chkIsDefault;
        private System.Windows.Forms.CheckBox chkUseEncryption;
        public System.Windows.Forms.TextBox txtEncryptKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIsSandbox;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}