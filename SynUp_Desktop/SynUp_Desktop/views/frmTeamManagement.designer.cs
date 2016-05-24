namespace SynUp_Desktop.views
{
    partial class frmTeamManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamManagement));
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.lblMandatory = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteToTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployeesOnTeam = new System.Windows.Forms.DataGridView();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.pbxIconMessage = new System.Windows.Forms.PictureBox();
            this.lblHelpMessage = new System.Windows.Forms.Label();
            this.btnClear = new SynUp_Desktop.utilities.GenericButton();
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            this.gbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesOnTeam)).BeginInit();
            this.gbHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContainer
            // 
            this.gbContainer.BackColor = System.Drawing.Color.Transparent;
            this.gbContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbContainer.Controls.Add(this.lblMandatory);
            this.gbContainer.Controls.Add(this.btnAdd);
            this.gbContainer.Controls.Add(this.btnDeleteToTeam);
            this.gbContainer.Controls.Add(this.label1);
            this.gbContainer.Controls.Add(this.dgvEmployeesOnTeam);
            this.gbContainer.Controls.Add(this.lblCode);
            this.gbContainer.Controls.Add(this.lblName);
            this.gbContainer.Controls.Add(this.txtName);
            this.gbContainer.Controls.Add(this.txtCode);
            this.gbContainer.Location = new System.Drawing.Point(16, 15);
            this.gbContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbContainer.Size = new System.Drawing.Size(816, 442);
            this.gbContainer.TabIndex = 17;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Team";
            // 
            // lblMandatory
            // 
            this.lblMandatory.AutoSize = true;
            this.lblMandatory.Location = new System.Drawing.Point(9, 412);
            this.lblMandatory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMandatory.Name = "lblMandatory";
            this.lblMandatory.Size = new System.Drawing.Size(121, 17);
            this.lblMandatory.TabIndex = 10;
            this.lblMandatory.Text = "* Mandatory fields";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(675, 406);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Employees";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteToTeam
            // 
            this.btnDeleteToTeam.Location = new System.Drawing.Point(533, 406);
            this.btnDeleteToTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteToTeam.Name = "btnDeleteToTeam";
            this.btnDeleteToTeam.Size = new System.Drawing.Size(133, 28);
            this.btnDeleteToTeam.TabIndex = 6;
            this.btnDeleteToTeam.Text = "Delete Employee";
            this.btnDeleteToTeam.UseVisualStyleBackColor = true;
            this.btnDeleteToTeam.Click += new System.EventHandler(this.btnDeleteToTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of employees";
            // 
            // dgvEmployeesOnTeam
            // 
            this.dgvEmployeesOnTeam.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvEmployeesOnTeam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEmployeesOnTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesOnTeam.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvEmployeesOnTeam.Location = new System.Drawing.Point(8, 81);
            this.dgvEmployeesOnTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmployeesOnTeam.Name = "dgvEmployeesOnTeam";
            this.dgvEmployeesOnTeam.Size = new System.Drawing.Size(799, 318);
            this.dgvEmployeesOnTeam.TabIndex = 3;
            this.dgvEmployeesOnTeam.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvEmployeesOnTeam_RowStateChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(8, 32);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(293, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(348, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(457, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(59, 28);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(225, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(232, 468);
            this.btnDeleteTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(100, 49);
            this.btnDeleteTeam.TabIndex = 19;
            this.btnDeleteTeam.Text = "Delete";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Location = new System.Drawing.Point(124, 468);
            this.btnUpdateTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(100, 49);
            this.btnUpdateTeam.TabIndex = 18;
            this.btnUpdateTeam.Text = "Update";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(16, 468);
            this.btnCreateTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(100, 49);
            this.btnCreateTeam.TabIndex = 21;
            this.btnCreateTeam.Text = "Create";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(691, 489);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 28);
            this.btnHelp.TabIndex = 25;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_MouseClick);
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.pbxIconMessage);
            this.gbHelp.Controls.Add(this.lblHelpMessage);
            this.gbHelp.Location = new System.Drawing.Point(16, 521);
            this.gbHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbHelp.Size = new System.Drawing.Size(816, 64);
            this.gbHelp.TabIndex = 26;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Help";
            // 
            // pbxIconMessage
            // 
            this.pbxIconMessage.Location = new System.Drawing.Point(7, 18);
            this.pbxIconMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxIconMessage.Name = "pbxIconMessage";
            this.pbxIconMessage.Size = new System.Drawing.Size(33, 31);
            this.pbxIconMessage.TabIndex = 1;
            this.pbxIconMessage.TabStop = false;
            // 
            // lblHelpMessage
            // 
            this.lblHelpMessage.AutoSize = true;
            this.lblHelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpMessage.Location = new System.Drawing.Point(47, 20);
            this.lblHelpMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelpMessage.MaximumSize = new System.Drawing.Size(573, 49);
            this.lblHelpMessage.Name = "lblHelpMessage";
            this.lblHelpMessage.Size = new System.Drawing.Size(82, 13);
            this.lblHelpMessage.TabIndex = 0;
            this.lblHelpMessage.Text = "Message help...";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.isExit = false;
            this.btnClear.Location = new System.Drawing.Point(336, 468);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Parent = this;
            this.btnClear.Size = new System.Drawing.Size(100, 49);
            this.btnClear.TabIndex = 10;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(732, 468);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(100, 49);
            this.btnBack.TabIndex = 12;
            // 
            // frmTeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SynUp_Desktop.Properties.Resources.SynUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(840, 521);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.btnUpdateTeam);
            this.Controls.Add(this.gbContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 630);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(860, 562);
            this.Name = "frmTeamManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Team Management ";
            this.Activated += new System.EventHandler(this.frmTeamManagement_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeamManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmTeamManagement_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesOnTeam)).EndInit();
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dgvEmployeesOnTeam;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteToTeam;
        private System.Windows.Forms.Button btnCreateTeam;
        private utilities.GenericButton btnBack;
        private utilities.GenericButton btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.PictureBox pbxIconMessage;
        private System.Windows.Forms.Label lblHelpMessage;
        private System.Windows.Forms.Label lblMandatory;
    }
}