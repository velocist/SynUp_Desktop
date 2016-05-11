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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteToTeam = new System.Windows.Forms.Button();
            this.btnAddToTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmployeesOnTeam = new System.Windows.Forms.DataGridView();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesOnTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteToTeam);
            this.groupBox1.Controls.Add(this.btnAddToTeam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvEmployeesOnTeam);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 359);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team";
            // 
            // btnDeleteToTeam
            // 
            this.btnDeleteToTeam.Location = new System.Drawing.Point(313, 330);
            this.btnDeleteToTeam.Name = "btnDeleteToTeam";
            this.btnDeleteToTeam.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteToTeam.TabIndex = 6;
            this.btnDeleteToTeam.Text = "Delete to team";
            this.btnDeleteToTeam.UseVisualStyleBackColor = true;
            // 
            // btnAddToTeam
            // 
            this.btnAddToTeam.Location = new System.Drawing.Point(193, 330);
            this.btnAddToTeam.Name = "btnAddToTeam";
            this.btnAddToTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddToTeam.Size = new System.Drawing.Size(114, 23);
            this.btnAddToTeam.TabIndex = 5;
            this.btnAddToTeam.Text = "Add to team";
            this.btnAddToTeam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of employees";
            // 
            // dgvEmployeesOnTeam
            // 
            this.dgvEmployeesOnTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesOnTeam.Location = new System.Drawing.Point(6, 78);
            this.dgvEmployeesOnTeam.Name = "dgvEmployeesOnTeam";
            this.dgvEmployeesOnTeam.Size = new System.Drawing.Size(599, 168);
            this.dgvEmployeesOnTeam.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 26);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(220, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(44, 23);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(170, 20);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(549, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 43);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(174, 377);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(75, 43);
            this.btnDeleteTeam.TabIndex = 19;
            this.btnDeleteTeam.Text = "Delete";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Location = new System.Drawing.Point(93, 377);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(75, 43);
            this.btnUpdateTeam.TabIndex = 18;
            this.btnUpdateTeam.Text = "Update";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(12, 377);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(75, 43);
            this.btnCreateTeam.TabIndex = 21;
            this.btnCreateTeam.Text = "Create";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(255, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 43);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmTeamManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 432);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteTeam);
            this.Controls.Add(this.btnUpdateTeam);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTeamManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Team Management ";
            this.Activated += new System.EventHandler(this.frmTeamManagement_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesOnTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dgvEmployeesOnTeam;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteToTeam;
        private System.Windows.Forms.Button btnAddToTeam;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Button btnClear;
    }
}