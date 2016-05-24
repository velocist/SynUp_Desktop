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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnManagementEmployee = new System.Windows.Forms.Button();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.cmbTeamsToAdd = new System.Windows.Forms.ComboBox();
            this.btnAddToTeam = new System.Windows.Forms.Button();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.pbxIconMessage = new System.Windows.Forms.PictureBox();
            this.lblHelpMessage = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gbContainer.SuspendLayout();
            this.gbHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvEmployees.Location = new System.Drawing.Point(9, 51);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowTemplate.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(785, 368);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvEmployees_RowStateChanged);
            // 
            // btnManagementEmployee
            // 
            this.btnManagementEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementEmployee.Location = new System.Drawing.Point(12, 454);
            this.btnManagementEmployee.Name = "btnManagementEmployee";
            this.btnManagementEmployee.Size = new System.Drawing.Size(105, 49);
            this.btnManagementEmployee.TabIndex = 3;
            this.btnManagementEmployee.Text = "Management";
            this.btnManagementEmployee.UseVisualStyleBackColor = true;
            this.btnManagementEmployee.Click += new System.EventHandler(this.btnManagementEmployee_Click);
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.lblTeams);
            this.gbContainer.Controls.Add(this.cmbTeamsToAdd);
            this.gbContainer.Controls.Add(this.btnAddToTeam);
            this.gbContainer.Controls.Add(this.dgvEmployees);
            this.gbContainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(800, 425);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "List of Employees";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(6, 26);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(51, 17);
            this.lblTeams.TabIndex = 0;
            this.lblTeams.Text = "Teams";
            // 
            // cmbTeamsToAdd
            // 
            this.cmbTeamsToAdd.FormattingEnabled = true;
            this.cmbTeamsToAdd.Location = new System.Drawing.Point(63, 23);
            this.cmbTeamsToAdd.Name = "cmbTeamsToAdd";
            this.cmbTeamsToAdd.Size = new System.Drawing.Size(177, 24);
            this.cmbTeamsToAdd.TabIndex = 1;
            // 
            // btnAddToTeam
            // 
            this.btnAddToTeam.Enabled = false;
            this.btnAddToTeam.Location = new System.Drawing.Point(246, 23);
            this.btnAddToTeam.Name = "btnAddToTeam";
            this.btnAddToTeam.Size = new System.Drawing.Size(122, 23);
            this.btnAddToTeam.TabIndex = 2;
            this.btnAddToTeam.Text = "Add to Team";
            this.btnAddToTeam.UseVisualStyleBackColor = true;
            this.btnAddToTeam.Click += new System.EventHandler(this.btnAddToTeam_Click);
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.pbxIconMessage);
            this.gbHelp.Controls.Add(this.lblHelpMessage);
            this.gbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHelp.Location = new System.Drawing.Point(123, 446);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Size = new System.Drawing.Size(552, 57);
            this.gbHelp.TabIndex = 0;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Help";
            // 
            // pbxIconMessage
            // 
            this.pbxIconMessage.Location = new System.Drawing.Point(5, 18);
            this.pbxIconMessage.Name = "pbxIconMessage";
            this.pbxIconMessage.Size = new System.Drawing.Size(25, 25);
            this.pbxIconMessage.TabIndex = 0;
            this.pbxIconMessage.TabStop = false;
            // 
            // lblHelpMessage
            // 
            this.lblHelpMessage.AutoSize = true;
            this.lblHelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHelpMessage.Location = new System.Drawing.Point(35, 22);
            this.lblHelpMessage.MaximumSize = new System.Drawing.Size(430, 40);
            this.lblHelpMessage.Name = "lblHelpMessage";
            this.lblHelpMessage.Size = new System.Drawing.Size(108, 17);
            this.lblHelpMessage.TabIndex = 0;
            this.lblHelpMessage.Text = "Message help...";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(681, 477);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 26);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHelp_MouseClick);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(712, 454);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(100, 49);
            this.btnBack.TabIndex = 5;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 512);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnManagementEmployee);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gbContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(840, 555);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 555);
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Employees ";
            this.Activated += new System.EventHandler(this.frmEmployees_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployees_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnManagementEmployee;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Button btnAddToTeam;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.ComboBox cmbTeamsToAdd;
        private utilities.GenericButton btnBack;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.PictureBox pbxIconMessage;
        private System.Windows.Forms.Label lblHelpMessage;
        private System.Windows.Forms.Button btnHelp;
    }
}