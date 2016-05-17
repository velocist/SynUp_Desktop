namespace SynUp_Desktop.views
{
    partial class frmEmployees
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnManagementEmployee = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.cmbTeamsToAdd = new System.Windows.Forms.ComboBox();
            this.btnAddToTeam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gbContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(9, 51);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(787, 360);
            this.dgvEmployees.TabIndex = 0;            
            this.dgvEmployees.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvEmployees_RowStateChanged);
            // 
            // btnManagementEmployee
            // 
            this.btnManagementEmployee.Location = new System.Drawing.Point(18, 442);
            this.btnManagementEmployee.Name = "btnManagementEmployee";
            this.btnManagementEmployee.Size = new System.Drawing.Size(86, 49);
            this.btnManagementEmployee.TabIndex = 2;
            this.btnManagementEmployee.Text = "Management";
            this.btnManagementEmployee.UseVisualStyleBackColor = true;
            this.btnManagementEmployee.Click += new System.EventHandler(this.btnManagementEmployee_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(733, 442);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 49);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(41, 24);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(152, 21);
            this.cmbFilter.TabIndex = 1;
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
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.lblTeams);
            this.gbContainer.Controls.Add(this.cmbTeamsToAdd);
            this.gbContainer.Controls.Add(this.btnAddToTeam);
            this.gbContainer.Controls.Add(this.lblFilter);
            this.gbContainer.Controls.Add(this.cmbFilter);
            this.gbContainer.Controls.Add(this.dgvEmployees);
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(802, 424);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "List of Employees";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(474, 27);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(39, 13);
            this.lblTeams.TabIndex = 6;
            this.lblTeams.Text = "Teams";
            // 
            // cmbTeamsToAdd
            // 
            this.cmbTeamsToAdd.FormattingEnabled = true;
            this.cmbTeamsToAdd.Location = new System.Drawing.Point(519, 24);
            this.cmbTeamsToAdd.Name = "cmbTeamsToAdd";
            this.cmbTeamsToAdd.Size = new System.Drawing.Size(177, 21);
            this.cmbTeamsToAdd.TabIndex = 5;
            // 
            // btnAddToTeam
            // 
            this.btnAddToTeam.Enabled = false;
            this.btnAddToTeam.Location = new System.Drawing.Point(702, 22);
            this.btnAddToTeam.Name = "btnAddToTeam";
            this.btnAddToTeam.Size = new System.Drawing.Size(94, 23);
            this.btnAddToTeam.TabIndex = 4;
            this.btnAddToTeam.Text = "Add to Team";
            this.btnAddToTeam.UseVisualStyleBackColor = true;
            this.btnAddToTeam.Click += new System.EventHandler(this.btnAddToTeam_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 495);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnManagementEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(640, 510);
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Employees ";
            this.Activated += new System.EventHandler(this.frmEmployees_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnManagementEmployee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Button btnAddToTeam;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.ComboBox cmbTeamsToAdd;
    }
}