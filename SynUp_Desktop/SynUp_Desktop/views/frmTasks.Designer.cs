namespace SynUp_Desktop.views
{
    partial class frmTasks
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnManagementTasks = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.gbContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(6, 27);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(41, 24);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(152, 21);
            this.cmbFilter.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(519, 418);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnManagementTasks
            // 
            this.btnManagementTasks.Location = new System.Drawing.Point(6, 418);
            this.btnManagementTasks.Name = "btnManagementTasks";
            this.btnManagementTasks.Size = new System.Drawing.Size(86, 23);
            this.btnManagementTasks.TabIndex = 2;
            this.btnManagementTasks.Text = "Management";
            this.btnManagementTasks.UseVisualStyleBackColor = true;
            this.btnManagementTasks.Click += new System.EventHandler(this.btnManagementTasks_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToOrderColumns = true;
            this.dgvTasks.AllowUserToResizeColumns = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTasks.Location = new System.Drawing.Point(9, 51);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowTemplate.ReadOnly = true;
            this.dgvTasks.Size = new System.Drawing.Size(585, 360);
            this.dgvTasks.TabIndex = 0;
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.lblFilter);
            this.gbContainer.Controls.Add(this.btnBack);
            this.gbContainer.Controls.Add(this.cmbFilter);
            this.gbContainer.Controls.Add(this.btnManagementTasks);
            this.gbContainer.Controls.Add(this.dgvTasks);
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(600, 450);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "List of Tasks";
            // 
            // frmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 472);
            this.Controls.Add(this.gbContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(640, 510);
            this.Name = "frmTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Tasks ";
            this.Activated += new System.EventHandler(this.frmTasks_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnManagementTasks;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.GroupBox gbContainer;
    }
}