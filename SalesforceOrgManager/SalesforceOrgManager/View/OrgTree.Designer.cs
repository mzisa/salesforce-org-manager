namespace SalesforceOrgManager.View
{
    partial class OrgTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrgTree));
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnRefreshMetadata = new System.Windows.Forms.Button();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNewStaticResource = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewVisualforce = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewTrigger = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNewLightningInterface = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewLightEvent = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewLightComponent = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewLightApp = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeployToServer = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDebugLogs = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnApiUsage = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnNewClass = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewStaticResource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewVisualforce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTrigger)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightningInterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightApp)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeployToServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDebugLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApiUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.CheckBoxes = true;
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(177, 83);
            this.treeView.Name = "treeView";
            this.treeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView.Size = new System.Drawing.Size(454, 562);
            this.treeView.TabIndex = 0;
            // 
            // btnRefreshMetadata
            // 
            this.btnRefreshMetadata.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshMetadata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshMetadata.Location = new System.Drawing.Point(177, 39);
            this.btnRefreshMetadata.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshMetadata.Name = "btnRefreshMetadata";
            this.btnRefreshMetadata.Size = new System.Drawing.Size(214, 37);
            this.btnRefreshMetadata.TabIndex = 1;
            this.btnRefreshMetadata.Text = "REFRESH METADATA INDEX";
            this.btnRefreshMetadata.UseVisualStyleBackColor = false;
            this.btnRefreshMetadata.Click += new System.EventHandler(this.btnRefreshMetadata_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProject.Location = new System.Drawing.Point(417, 39);
            this.btnUpdateProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(212, 37);
            this.btnUpdateProject.TabIndex = 2;
            this.btnUpdateProject.Text = "UPDATE PROJECT";
            this.btnUpdateProject.UseVisualStyleBackColor = false;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.Location = new System.Drawing.Point(177, -1);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(214, 37);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "SELECT ALL";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectNone.Location = new System.Drawing.Point(417, -1);
            this.btnSelectNone.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(212, 37);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "SELECT NONE";
            this.btnSelectNone.UseVisualStyleBackColor = false;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(156, 649);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.Scheda_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.btnNewStaticResource);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnNewVisualforce);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnNewTrigger);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnNewClass);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(148, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "M";
            // 
            // btnNewStaticResource
            // 
            this.btnNewStaticResource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewStaticResource.Image = ((System.Drawing.Image)(resources.GetObject("btnNewStaticResource.Image")));
            this.btnNewStaticResource.Location = new System.Drawing.Point(21, 479);
            this.btnNewStaticResource.Name = "btnNewStaticResource";
            this.btnNewStaticResource.Size = new System.Drawing.Size(106, 108);
            this.btnNewStaticResource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewStaticResource.TabIndex = 8;
            this.btnNewStaticResource.TabStop = false;
            this.btnNewStaticResource.Click += new System.EventHandler(this.btnNewStaticResource_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 590);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "NEW STATIC RESOURCE";
            // 
            // btnNewVisualforce
            // 
            this.btnNewVisualforce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewVisualforce.Image = ((System.Drawing.Image)(resources.GetObject("btnNewVisualforce.Image")));
            this.btnNewVisualforce.Location = new System.Drawing.Point(21, 322);
            this.btnNewVisualforce.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewVisualforce.Name = "btnNewVisualforce";
            this.btnNewVisualforce.Size = new System.Drawing.Size(106, 114);
            this.btnNewVisualforce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewVisualforce.TabIndex = 6;
            this.btnNewVisualforce.TabStop = false;
            this.btnNewVisualforce.Click += new System.EventHandler(this.btnNewVisualforce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NEW VISUALFORCE";
            // 
            // btnNewTrigger
            // 
            this.btnNewTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewTrigger.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTrigger.Image")));
            this.btnNewTrigger.Location = new System.Drawing.Point(21, 166);
            this.btnNewTrigger.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewTrigger.Name = "btnNewTrigger";
            this.btnNewTrigger.Size = new System.Drawing.Size(106, 114);
            this.btnNewTrigger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewTrigger.TabIndex = 4;
            this.btnNewTrigger.TabStop = false;
            this.btnNewTrigger.Click += new System.EventHandler(this.btnNewTrigger_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "NEW APEX TRIGGER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEW APEX CLASS";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.tabPage2.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnNewLightningInterface);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnNewLightEvent);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnNewLightComponent);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnNewLightApp);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(148, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 583);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "NEW INTERFACE";
            // 
            // btnNewLightningInterface
            // 
            this.btnNewLightningInterface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLightningInterface.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLightningInterface.Image")));
            this.btnNewLightningInterface.Location = new System.Drawing.Point(20, 468);
            this.btnNewLightningInterface.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewLightningInterface.Name = "btnNewLightningInterface";
            this.btnNewLightningInterface.Size = new System.Drawing.Size(106, 114);
            this.btnNewLightningInterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewLightningInterface.TabIndex = 8;
            this.btnNewLightningInterface.TabStop = false;
            this.btnNewLightningInterface.Click += new System.EventHandler(this.btnNewLightningInterface_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "NEW EVENT";
            // 
            // btnNewLightEvent
            // 
            this.btnNewLightEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLightEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLightEvent.Image")));
            this.btnNewLightEvent.Location = new System.Drawing.Point(21, 311);
            this.btnNewLightEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewLightEvent.Name = "btnNewLightEvent";
            this.btnNewLightEvent.Size = new System.Drawing.Size(106, 114);
            this.btnNewLightEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewLightEvent.TabIndex = 6;
            this.btnNewLightEvent.TabStop = false;
            this.btnNewLightEvent.Click += new System.EventHandler(this.btnNewLightEvent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "NEW COMPONENT";
            // 
            // btnNewLightComponent
            // 
            this.btnNewLightComponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLightComponent.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLightComponent.Image")));
            this.btnNewLightComponent.Location = new System.Drawing.Point(21, 158);
            this.btnNewLightComponent.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewLightComponent.Name = "btnNewLightComponent";
            this.btnNewLightComponent.Size = new System.Drawing.Size(106, 114);
            this.btnNewLightComponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewLightComponent.TabIndex = 4;
            this.btnNewLightComponent.TabStop = false;
            this.btnNewLightComponent.Click += new System.EventHandler(this.btnNewLightComponent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "NEW APP";
            // 
            // btnNewLightApp
            // 
            this.btnNewLightApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLightApp.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLightApp.Image")));
            this.btnNewLightApp.Location = new System.Drawing.Point(21, 13);
            this.btnNewLightApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewLightApp.Name = "btnNewLightApp";
            this.btnNewLightApp.Size = new System.Drawing.Size(106, 114);
            this.btnNewLightApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewLightApp.TabIndex = 2;
            this.btnNewLightApp.TabStop = false;
            this.btnNewLightApp.Click += new System.EventHandler(this.btnNewLightApp_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnDeployToServer);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnDebugLogs);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnApiUsage);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(148, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "T";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 479);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "DEPLOY TO SERVER";
            // 
            // btnDeployToServer
            // 
            this.btnDeployToServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeployToServer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeployToServer.Image")));
            this.btnDeployToServer.Location = new System.Drawing.Point(20, 363);
            this.btnDeployToServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeployToServer.Name = "btnDeployToServer";
            this.btnDeployToServer.Size = new System.Drawing.Size(106, 114);
            this.btnDeployToServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeployToServer.TabIndex = 16;
            this.btnDeployToServer.TabStop = false;
            this.btnDeployToServer.Click += new System.EventHandler(this.btnDeployToServer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "DEBUG LOGS";
            // 
            // btnDebugLogs
            // 
            this.btnDebugLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebugLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnDebugLogs.Image")));
            this.btnDebugLogs.Location = new System.Drawing.Point(20, 15);
            this.btnDebugLogs.Margin = new System.Windows.Forms.Padding(2);
            this.btnDebugLogs.Name = "btnDebugLogs";
            this.btnDebugLogs.Size = new System.Drawing.Size(106, 114);
            this.btnDebugLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDebugLogs.TabIndex = 12;
            this.btnDebugLogs.TabStop = false;
            this.btnDebugLogs.Click += new System.EventHandler(this.btnDebugLogs_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 307);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "API USAGE";
            // 
            // btnApiUsage
            // 
            this.btnApiUsage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApiUsage.Image = ((System.Drawing.Image)(resources.GetObject("btnApiUsage.Image")));
            this.btnApiUsage.Location = new System.Drawing.Point(20, 191);
            this.btnApiUsage.Margin = new System.Windows.Forms.Padding(2);
            this.btnApiUsage.Name = "btnApiUsage";
            this.btnApiUsage.Size = new System.Drawing.Size(106, 114);
            this.btnApiUsage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnApiUsage.TabIndex = 10;
            this.btnApiUsage.TabStop = false;
            this.btnApiUsage.Click += new System.EventHandler(this.btnApiUsage_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(236, 257);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // btnNewClass
            // 
            this.btnNewClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClass.Image = ((System.Drawing.Image)(resources.GetObject("btnNewClass.Image")));
            this.btnNewClass.Location = new System.Drawing.Point(25, 22);
            this.btnNewClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(102, 105);
            this.btnNewClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNewClass.TabIndex = 0;
            this.btnNewClass.TabStop = false;
            this.btnNewClass.Click += new System.EventHandler(this.btnNewClass_Click);
            // 
            // OrgTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 649);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnUpdateProject);
            this.Controls.Add(this.btnRefreshMetadata);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "OrgTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrgTree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrgTree_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewStaticResource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewVisualforce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTrigger)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightningInterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLightApp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeployToServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDebugLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApiUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefreshMetadata;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnNewVisualforce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnNewTrigger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnNewLightEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnNewLightComponent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnNewLightApp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnNewStaticResource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnNewLightningInterface;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btnDebugLogs;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox btnApiUsage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btnDeployToServer;
        private System.Windows.Forms.PictureBox btnNewClass;
    }
}