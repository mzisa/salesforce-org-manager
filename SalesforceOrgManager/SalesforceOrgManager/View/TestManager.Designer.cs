namespace SalesforceOrgManager.View
{
    partial class TestManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestManager));
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.tabControlResults = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridClassCoverage = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridTriggerCoverage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.tabControlResults.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassCoverage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTriggerCoverage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToOrderColumns = true;
            this.dataGridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Location = new System.Drawing.Point(5, 6);
            this.dataGridResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.RowTemplate.Height = 24;
            this.dataGridResults.Size = new System.Drawing.Size(1184, 329);
            this.dataGridResults.TabIndex = 0;
            // 
            // tabControlResults
            // 
            this.tabControlResults.Controls.Add(this.tabPage1);
            this.tabControlResults.Controls.Add(this.tabPage2);
            this.tabControlResults.Controls.Add(this.tabPage3);
            this.tabControlResults.Location = new System.Drawing.Point(4, 4);
            this.tabControlResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlResults.Name = "tabControlResults";
            this.tabControlResults.SelectedIndex = 0;
            this.tabControlResults.Size = new System.Drawing.Size(1219, 385);
            this.tabControlResults.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1211, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TEST RESULTS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridClassCoverage);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1211, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLASS COVERAGE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridClassCoverage
            // 
            this.dataGridClassCoverage.AllowUserToOrderColumns = true;
            this.dataGridClassCoverage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClassCoverage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridClassCoverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClassCoverage.Location = new System.Drawing.Point(5, 6);
            this.dataGridClassCoverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridClassCoverage.Name = "dataGridClassCoverage";
            this.dataGridClassCoverage.RowTemplate.Height = 24;
            this.dataGridClassCoverage.Size = new System.Drawing.Size(1004, 306);
            this.dataGridClassCoverage.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridTriggerCoverage);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1211, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TRIGGER COVERAGE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridTriggerCoverage
            // 
            this.dataGridTriggerCoverage.AllowUserToOrderColumns = true;
            this.dataGridTriggerCoverage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTriggerCoverage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTriggerCoverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTriggerCoverage.Location = new System.Drawing.Point(4, 2);
            this.dataGridTriggerCoverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridTriggerCoverage.Name = "dataGridTriggerCoverage";
            this.dataGridTriggerCoverage.RowTemplate.Height = 24;
            this.dataGridTriggerCoverage.Size = new System.Drawing.Size(997, 326);
            this.dataGridTriggerCoverage.TabIndex = 2;
            // 
            // TestManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 399);
            this.Controls.Add(this.tabControlResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TestManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.tabControlResults.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClassCoverage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTriggerCoverage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.TabControl tabControlResults;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridClassCoverage;
        private System.Windows.Forms.DataGridView dataGridTriggerCoverage;
    }
}