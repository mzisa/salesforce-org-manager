namespace SalesforceOrgManager.View
{
    partial class BoxCreazioneRisorsaStatica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxCreazioneRisorsaStatica));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkZippedBundle = new System.Windows.Forms.RadioButton();
            this.chkSingleFile = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(88, 10);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(344, 26);
            this.txtItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateItem.Location = new System.Drawing.Point(10, 143);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(209, 59);
            this.btnCreateItem.TabIndex = 4;
            this.btnCreateItem.Text = "CREATE";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(224, 143);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(209, 59);
            this.btnCancelItem.TabIndex = 5;
            this.btnCancelItem.Text = "CANCEL";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Gold;
            this.txtLog.Location = new System.Drawing.Point(10, 207);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(422, 71);
            this.txtLog.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkZippedBundle);
            this.groupBox1.Controls.Add(this.chkSingleFile);
            this.groupBox1.Location = new System.Drawing.Point(10, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resource format";
            // 
            // chkZippedBundle
            // 
            this.chkZippedBundle.AutoSize = true;
            this.chkZippedBundle.Location = new System.Drawing.Point(214, 31);
            this.chkZippedBundle.Name = "chkZippedBundle";
            this.chkZippedBundle.Size = new System.Drawing.Size(135, 17);
            this.chkZippedBundle.TabIndex = 1;
            this.chkZippedBundle.Text = "zipped resource bundle";
            this.chkZippedBundle.UseVisualStyleBackColor = true;
            // 
            // chkSingleFile
            // 
            this.chkSingleFile.AutoSize = true;
            this.chkSingleFile.Checked = true;
            this.chkSingleFile.Location = new System.Drawing.Point(19, 31);
            this.chkSingleFile.Name = "chkSingleFile";
            this.chkSingleFile.Size = new System.Drawing.Size(68, 17);
            this.chkSingleFile.TabIndex = 0;
            this.chkSingleFile.TabStop = true;
            this.chkSingleFile.Text = "single file";
            this.chkSingleFile.UseVisualStyleBackColor = true;
            // 
            // BoxCreazioneRisorsaStatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BoxCreazioneRisorsaStatica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Static Resource";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnCancelItem;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton chkZippedBundle;
        public System.Windows.Forms.RadioButton chkSingleFile;
    }
}