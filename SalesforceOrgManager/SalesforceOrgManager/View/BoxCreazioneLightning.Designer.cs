namespace SalesforceOrgManager.View
{
    partial class BoxCreazioneLightning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxCreazioneLightning));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.groupBoxBundleType = new System.Windows.Forms.GroupBox();
            this.chkDefinitionType = new System.Windows.Forms.CheckedListBox();
            this.radioInterface = new System.Windows.Forms.RadioButton();
            this.radioEvent = new System.Windows.Forms.RadioButton();
            this.radioComponent = new System.Windows.Forms.RadioButton();
            this.radioApp = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVersions = new System.Windows.Forms.ComboBox();
            this.groupBoxBundleType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(102, 11);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(344, 26);
            this.txtItemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateItem.Location = new System.Drawing.Point(8, 299);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(209, 59);
            this.btnCreateItem.TabIndex = 10;
            this.btnCreateItem.Text = "CREATE";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(222, 299);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(209, 59);
            this.btnCancelItem.TabIndex = 11;
            this.btnCancelItem.Text = "CANCEL";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Gold;
            this.txtLog.Location = new System.Drawing.Point(8, 363);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(422, 71);
            this.txtLog.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(102, 56);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(344, 26);
            this.txtItemDescription.TabIndex = 2;
            // 
            // groupBoxBundleType
            // 
            this.groupBoxBundleType.Controls.Add(this.chkDefinitionType);
            this.groupBoxBundleType.Controls.Add(this.radioInterface);
            this.groupBoxBundleType.Controls.Add(this.radioEvent);
            this.groupBoxBundleType.Controls.Add(this.radioComponent);
            this.groupBoxBundleType.Controls.Add(this.radioApp);
            this.groupBoxBundleType.Location = new System.Drawing.Point(11, 89);
            this.groupBoxBundleType.Name = "groupBoxBundleType";
            this.groupBoxBundleType.Size = new System.Drawing.Size(435, 152);
            this.groupBoxBundleType.TabIndex = 3;
            this.groupBoxBundleType.TabStop = false;
            this.groupBoxBundleType.Text = "Lightning bundle type";
            // 
            // chkDefinitionType
            // 
            this.chkDefinitionType.FormattingEnabled = true;
            this.chkDefinitionType.Items.AddRange(new object[] {
            "CONTROLLER",
            "HELPER",
            "STYLE",
            "DOCUMENTATION",
            "RENDERER",
            "SVG"});
            this.chkDefinitionType.Location = new System.Drawing.Point(169, 22);
            this.chkDefinitionType.Name = "chkDefinitionType";
            this.chkDefinitionType.Size = new System.Drawing.Size(236, 79);
            this.chkDefinitionType.TabIndex = 8;
            // 
            // radioInterface
            // 
            this.radioInterface.AutoSize = true;
            this.radioInterface.Location = new System.Drawing.Point(6, 100);
            this.radioInterface.Name = "radioInterface";
            this.radioInterface.Size = new System.Drawing.Size(67, 17);
            this.radioInterface.TabIndex = 7;
            this.radioInterface.TabStop = true;
            this.radioInterface.Text = "Interface";
            this.radioInterface.UseVisualStyleBackColor = true;
            // 
            // radioEvent
            // 
            this.radioEvent.AutoSize = true;
            this.radioEvent.Location = new System.Drawing.Point(6, 73);
            this.radioEvent.Name = "radioEvent";
            this.radioEvent.Size = new System.Drawing.Size(53, 17);
            this.radioEvent.TabIndex = 6;
            this.radioEvent.TabStop = true;
            this.radioEvent.Text = "Event";
            this.radioEvent.UseVisualStyleBackColor = true;
            // 
            // radioComponent
            // 
            this.radioComponent.AutoSize = true;
            this.radioComponent.Location = new System.Drawing.Point(6, 47);
            this.radioComponent.Name = "radioComponent";
            this.radioComponent.Size = new System.Drawing.Size(79, 17);
            this.radioComponent.TabIndex = 5;
            this.radioComponent.TabStop = true;
            this.radioComponent.Text = "Component";
            this.radioComponent.UseVisualStyleBackColor = true;
            // 
            // radioApp
            // 
            this.radioApp.AutoSize = true;
            this.radioApp.Location = new System.Drawing.Point(6, 22);
            this.radioApp.Name = "radioApp";
            this.radioApp.Size = new System.Drawing.Size(44, 17);
            this.radioApp.TabIndex = 4;
            this.radioApp.TabStop = true;
            this.radioApp.Text = "App";
            this.radioApp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Api version";
            // 
            // cmbVersions
            // 
            this.cmbVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVersions.FormattingEnabled = true;
            this.cmbVersions.Items.AddRange(new object[] {
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45"});
            this.cmbVersions.Location = new System.Drawing.Point(8, 263);
            this.cmbVersions.Name = "cmbVersions";
            this.cmbVersions.Size = new System.Drawing.Size(408, 28);
            this.cmbVersions.TabIndex = 9;
            this.cmbVersions.Text = "Version...";
            // 
            // BoxCreazioneLightning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVersions);
            this.Controls.Add(this.groupBoxBundleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoxCreazioneLightning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Lightning Item";
            this.groupBoxBundleType.ResumeLayout(false);
            this.groupBoxBundleType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnCancelItem;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.GroupBox groupBoxBundleType;
        public System.Windows.Forms.RadioButton radioInterface;
        public System.Windows.Forms.RadioButton radioEvent;
        public System.Windows.Forms.RadioButton radioComponent;
        public System.Windows.Forms.RadioButton radioApp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbVersions;
        public System.Windows.Forms.CheckedListBox chkDefinitionType;
    }
}