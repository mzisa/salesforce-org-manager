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
            this.picNewProject.Location = new System.Drawing.Point(31, 5);
            this.picNewProject.Margin = new System.Windows.Forms.Padding(2);
            this.picNewProject.Name = "picNewProject";
            this.picNewProject.Size = new System.Drawing.Size(116, 108);
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
            this.picOpenProject.Location = new System.Drawing.Point(30, 5);
            this.picOpenProject.Margin = new System.Windows.Forms.Padding(2);
            this.picOpenProject.Name = "picOpenProject";
            this.picOpenProject.Size = new System.Drawing.Size(116, 108);
            this.picOpenProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpenProject.TabIndex = 2;
            this.picOpenProject.TabStop = false;
            this.picOpenProject.Click += new System.EventHandler(this.picOpenProject_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPEN PROJECT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NEW PROJECT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "SETTINGS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbWorkspace
            // 
            this.cmbWorkspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkspace.FormattingEnabled = true;
            this.cmbWorkspace.Location = new System.Drawing.Point(4, 184);
            this.cmbWorkspace.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWorkspace.Name = "cmbWorkspace";
            this.cmbWorkspace.Size = new System.Drawing.Size(709, 33);
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
            this.lstProject.ItemHeight = 25;
            this.lstProject.Location = new System.Drawing.Point(4, 249);
            this.lstProject.Margin = new System.Windows.Forms.Padding(2);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(709, 104);
            this.lstProject.TabIndex = 8;
            this.lstProject.Visible = false;
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenProject.Location = new System.Drawing.Point(2, 446);
            this.btnOpenProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(710, 62);
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
            this.panel1.Location = new System.Drawing.Point(7, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 145);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.picNewProject);
            this.panel2.Location = new System.Drawing.Point(278, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 145);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.picSettings);
            this.panel3.Location = new System.Drawing.Point(548, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 145);
            this.panel3.TabIndex = 12;
            // 
            // picSettings
            // 
            this.picSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSettings.Image = ((System.Drawing.Image)(resources.GetObject("picSettings.Image")));
            this.picSettings.Location = new System.Drawing.Point(25, 5);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(110, 108);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 0;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.Location = new System.Drawing.Point(4, 249);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(709, 38);
            this.txtProjectName.TabIndex = 1;
            this.txtProjectName.Text = "Project name...";
            this.txtProjectName.Visible = false;
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 523);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesforce Org Manager v. 1.5.0";
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

