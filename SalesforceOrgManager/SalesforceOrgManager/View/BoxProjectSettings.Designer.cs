namespace SalesforceOrgManager.View
{
    partial class BoxProjectSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxProjectSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRightToLeft = new System.Windows.Forms.Button();
            this.btnLeftToRight = new System.Windows.Forms.Button();
            this.lstBoxRight = new System.Windows.Forms.ListBox();
            this.lstBoxLeft = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkShowAllMetadata = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRightToLeft);
            this.groupBox1.Controls.Add(this.btnLeftToRight);
            this.groupBox1.Controls.Add(this.lstBoxRight);
            this.groupBox1.Controls.Add(this.lstBoxLeft);
            this.groupBox1.Location = new System.Drawing.Point(15, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(461, 283);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metadata to show for this project by these controls";
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.Location = new System.Drawing.Point(191, 129);
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
            this.btnLeftToRight.Location = new System.Drawing.Point(191, 69);
            this.btnLeftToRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeftToRight.Name = "btnLeftToRight";
            this.btnLeftToRight.Size = new System.Drawing.Size(75, 36);
            this.btnLeftToRight.TabIndex = 7;
            this.btnLeftToRight.Text = ">>";
            this.btnLeftToRight.UseVisualStyleBackColor = true;
            this.btnLeftToRight.Click += new System.EventHandler(this.btnLeftToRight_Click);
            // 
            // lstBoxRight
            // 
            this.lstBoxRight.FormattingEnabled = true;
            this.lstBoxRight.Location = new System.Drawing.Point(280, 22);
            this.lstBoxRight.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxRight.Name = "lstBoxRight";
            this.lstBoxRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxRight.Size = new System.Drawing.Size(167, 238);
            this.lstBoxRight.TabIndex = 9;
            // 
            // lstBoxLeft
            // 
            this.lstBoxLeft.FormattingEnabled = true;
            this.lstBoxLeft.Location = new System.Drawing.Point(13, 22);
            this.lstBoxLeft.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxLeft.Name = "lstBoxLeft";
            this.lstBoxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxLeft.Size = new System.Drawing.Size(167, 238);
            this.lstBoxLeft.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Changes are saved automatically after closing this window";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkShowAllMetadata);
            this.groupBox2.Location = new System.Drawing.Point(15, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 46);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cache settings";
            // 
            // chkShowAllMetadata
            // 
            this.chkShowAllMetadata.AutoSize = true;
            this.chkShowAllMetadata.Location = new System.Drawing.Point(13, 19);
            this.chkShowAllMetadata.Name = "chkShowAllMetadata";
            this.chkShowAllMetadata.Size = new System.Drawing.Size(113, 17);
            this.chkShowAllMetadata.TabIndex = 0;
            this.chkShowAllMetadata.Text = "Show all metadata";
            this.chkShowAllMetadata.UseVisualStyleBackColor = true;
            this.chkShowAllMetadata.CheckedChanged += new System.EventHandler(this.chkShowAllMetadata_CheckedChanged);
            // 
            // BoxProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoxProjectSettings";
            this.Text = "Project settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoxProjectSettings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRightToLeft;
        private System.Windows.Forms.Button btnLeftToRight;
        private System.Windows.Forms.ListBox lstBoxRight;
        private System.Windows.Forms.ListBox lstBoxLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShowAllMetadata;
    }
}