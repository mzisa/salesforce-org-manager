namespace SalesforceOrgManager.View
{
    partial class BoxExecuteAnonymous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxExecuteAnonymous));
            this.txtExecuteAnonymous = new System.Windows.Forms.TextBox();
            this.txtExecutionResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRunApex = new System.Windows.Forms.Button();
            this.txtExecutionLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExecuteAnonymous
            // 
            this.txtExecuteAnonymous.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtExecuteAnonymous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExecuteAnonymous.ForeColor = System.Drawing.SystemColors.Window;
            this.txtExecuteAnonymous.Location = new System.Drawing.Point(11, 116);
            this.txtExecuteAnonymous.Margin = new System.Windows.Forms.Padding(2);
            this.txtExecuteAnonymous.Multiline = true;
            this.txtExecuteAnonymous.Name = "txtExecuteAnonymous";
            this.txtExecuteAnonymous.Size = new System.Drawing.Size(488, 204);
            this.txtExecuteAnonymous.TabIndex = 7;
            this.txtExecuteAnonymous.Text = "Execute Anonymous";
            // 
            // txtExecutionResult
            // 
            this.txtExecutionResult.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtExecutionResult.ForeColor = System.Drawing.Color.Gold;
            this.txtExecutionResult.Location = new System.Drawing.Point(9, 346);
            this.txtExecutionResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtExecutionResult.Multiline = true;
            this.txtExecutionResult.Name = "txtExecutionResult";
            this.txtExecutionResult.ReadOnly = true;
            this.txtExecutionResult.Size = new System.Drawing.Size(491, 224);
            this.txtExecutionResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result";
            // 
            // btnRunApex
            // 
            this.btnRunApex.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRunApex.Location = new System.Drawing.Point(11, 8);
            this.btnRunApex.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunApex.Name = "btnRunApex";
            this.btnRunApex.Size = new System.Drawing.Size(998, 62);
            this.btnRunApex.TabIndex = 10;
            this.btnRunApex.Text = "RUN";
            this.btnRunApex.UseVisualStyleBackColor = false;
            this.btnRunApex.Click += new System.EventHandler(this.btnRunApex_Click);
            // 
            // txtExecutionLog
            // 
            this.txtExecutionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExecutionLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtExecutionLog.Location = new System.Drawing.Point(518, 116);
            this.txtExecutionLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtExecutionLog.Multiline = true;
            this.txtExecutionLog.Name = "txtExecutionLog";
            this.txtExecutionLog.ReadOnly = true;
            this.txtExecutionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExecutionLog.Size = new System.Drawing.Size(488, 454);
            this.txtExecutionLog.TabIndex = 11;
            this.txtExecutionLog.Text = "execute anonymous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apex code to execute";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label3.Location = new System.Drawing.Point(515, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Log";
            this.label3.UseWaitCursor = true;
            // 
            // BoxExecuteAnonymous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExecutionLog);
            this.Controls.Add(this.btnRunApex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExecutionResult);
            this.Controls.Add(this.txtExecuteAnonymous);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BoxExecuteAnonymous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoxExecuteAnonymous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExecuteAnonymous;
        private System.Windows.Forms.TextBox txtExecutionResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRunApex;
        private System.Windows.Forms.TextBox txtExecutionLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}