namespace SalesforceOrgManager.View
{
    partial class BoxDeployToServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxDeployToServer));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRunDeploy = new System.Windows.Forms.Button();
            this.txtDeployLog = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sf.marco.zisa.01@workshop.ideas"});
            this.comboBox1.Location = new System.Drawing.Point(92, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(724, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination org";
            // 
            // btnRunDeploy
            // 
            this.btnRunDeploy.Location = new System.Drawing.Point(11, 46);
            this.btnRunDeploy.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunDeploy.Name = "btnRunDeploy";
            this.btnRunDeploy.Size = new System.Drawing.Size(805, 41);
            this.btnRunDeploy.TabIndex = 2;
            this.btnRunDeploy.Text = "RUN DEPLOY";
            this.btnRunDeploy.UseVisualStyleBackColor = true;
            this.btnRunDeploy.Click += new System.EventHandler(this.btnRunDeploy_Click);
            // 
            // txtDeployLog
            // 
            this.txtDeployLog.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDeployLog.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDeployLog.Location = new System.Drawing.Point(12, 139);
            this.txtDeployLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeployLog.Multiline = true;
            this.txtDeployLog.Name = "txtDeployLog";
            this.txtDeployLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeployLog.Size = new System.Drawing.Size(804, 291);
            this.txtDeployLog.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(804, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // BoxDeployToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 441);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtDeployLog);
            this.Controls.Add(this.btnRunDeploy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BoxDeployToServer";
            this.Text = "BoxDeployToServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.TextBox txtDeployLog;
        public System.Windows.Forms.Button btnRunDeploy;
    }
}