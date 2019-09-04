namespace SalesforceOrgManager.View
{
    partial class Principale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principale));
            this.picNewProject = new System.Windows.Forms.PictureBox();
            this.picOpenProject = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWorkspace = new System.Windows.Forms.ComboBox();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNewProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenProject)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // picNewProject
            // 
            this.picNewProject.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.picNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNewProject.Image = ((System.Drawing.Image)(resources.GetObject("picNewProject.Image")));
            this.picNewProject.ImageLocation = "";
            this.picNewProject.Location = new System.Drawing.Point(46, 8);
            this.picNewProject.Name = "picNewProject";
            this.picNewProject.Size = new System.Drawing.Size(174, 166);
            this.picNewProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewProject.TabIndex = 0;
            this.picNewProject.TabStop = false;
            this.picNewProject.Click += new System.EventHandler(this.picNewProject_Click);
            // 
            // picOpenProject
            // 
            this.picOpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOpenProject.Image = ((System.Drawing.Image)(resources.GetObject("picOpenProject.Image")));
            this.picOpenProject.ImageLocation = "";
            this.picOpenProject.Location = new System.Drawing.Point(45, 8);
            this.picOpenProject.Name = "picOpenProject";
            this.picOpenProject.Size = new System.Drawing.Size(174, 166);
            this.picOpenProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpenProject.TabIndex = 2;
            this.picOpenProject.TabStop = false;
            this.picOpenProject.Click += new System.EventHandler(this.picOpenProject_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPEN PROJECT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NEW PROJECT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SETTINGS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbWorkspace
            // 
            this.cmbWorkspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkspace.FormattingEnabled = true;
            this.cmbWorkspace.Location = new System.Drawing.Point(6, 283);
            this.cmbWorkspace.Name = "cmbWorkspace";
            this.cmbWorkspace.Size = new System.Drawing.Size(1062, 45);
            this.cmbWorkspace.TabIndex = 0;
            this.cmbWorkspace.Text = "Select Workspace";
            this.cmbWorkspace.Visible = false;
            this.cmbWorkspace.SelectedIndexChanged += new System.EventHandler(this.cmbWorkspace_SelectedIndexChanged);
            this.cmbWorkspace.VisibleChanged += new System.EventHandler(this.cmbWorkspace_SelectedIndexChanged);
            // 
            // lstProject
            // 
            this.lstProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProject.FormattingEnabled = true;
            this.lstProject.ItemHeight = 37;
            this.lstProject.Location = new System.Drawing.Point(6, 383);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(1062, 152);
            this.lstProject.TabIndex = 8;
            this.lstProject.Visible = false;
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProject.Location = new System.Drawing.Point(3, 686);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(1065, 95);
            this.btnOpenProject.TabIndex = 2;
            this.btnOpenProject.Text = "OPEN";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Visible = false;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picOpenProject);
            this.panel1.Location = new System.Drawing.Point(10, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 223);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.picNewProject);
            this.panel2.Location = new System.Drawing.Point(417, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 223);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.picSettings);
            this.panel3.Location = new System.Drawing.Point(822, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 223);
            this.panel3.TabIndex = 12;
            // 
            // picSettings
            // 
            this.picSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSettings.Image = ((System.Drawing.Image)(resources.GetObject("picSettings.Image")));
            this.picSettings.Location = new System.Drawing.Point(38, 8);
            this.picSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(165, 166);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 0;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.Location = new System.Drawing.Point(6, 383);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(1062, 53);
            this.txtProjectName.TabIndex = 1;
            this.txtProjectName.Text = "Project name...";
            this.txtProjectName.Visible = false;
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 805);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.lstProject);
            this.Controls.Add(this.cmbWorkspace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesforce Org Manager v. 1.7.5";
            this.Load += new System.EventHandler(this.Principale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNewProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenProject)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNewProject;
        private System.Windows.Forms.PictureBox picOpenProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.Button btnOpenProject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picSettings;
        private System.Windows.Forms.TextBox txtProjectName;
        public System.Windows.Forms.ComboBox cmbWorkspace;
    }
}

