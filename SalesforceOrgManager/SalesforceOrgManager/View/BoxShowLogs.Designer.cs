namespace SalesforceOrgManager.View
{
    partial class BoxShowLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxShowLogs));
            this.dataGridLogs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExecutionLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLogs
            // 
            this.dataGridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLogs.Location = new System.Drawing.Point(9, 25);
            this.dataGridLogs.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridLogs.Name = "dataGridLogs";
            this.dataGridLogs.RowTemplate.Height = 24;
            this.dataGridLogs.Size = new System.Drawing.Size(718, 545);
            this.dataGridLogs.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Location = new System.Drawing.Point(748, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Log content";
            this.label3.UseWaitCursor = true;
            // 
            // txtExecutionLog
            // 
            this.txtExecutionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExecutionLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtExecutionLog.Location = new System.Drawing.Point(750, 25);
            this.txtExecutionLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtExecutionLog.Multiline = true;
            this.txtExecutionLog.Name = "txtExecutionLog";
            this.txtExecutionLog.ReadOnly = true;
            this.txtExecutionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExecutionLog.Size = new System.Drawing.Size(433, 546);
            this.txtExecutionLog.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Log list";
            this.label1.UseWaitCursor = true;
            // 
            // BoxShowLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExecutionLog);
            this.Controls.Add(this.dataGridLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "BoxShowLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show top 50 debug logs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLogs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExecutionLog;
        private System.Windows.Forms.Label label1;
    }
}