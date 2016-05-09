namespace SynUp_Desktop.views
{
    partial class frmTaskManagement
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
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.lblIdTeam = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.mcalPriorityDate = new System.Windows.Forms.MonthCalendar();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtLocalization = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPriorityDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLocalization = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbIdTeams = new System.Windows.Forms.ComboBox();
            this.gbContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.cbIdTeams);
            this.gbContainer.Controls.Add(this.lblIdTeam);
            this.gbContainer.Controls.Add(this.txtProject);
            this.gbContainer.Controls.Add(this.lblProject);
            this.gbContainer.Controls.Add(this.mcalPriorityDate);
            this.gbContainer.Controls.Add(this.lblCode);
            this.gbContainer.Controls.Add(this.txtLocalization);
            this.gbContainer.Controls.Add(this.lblName);
            this.gbContainer.Controls.Add(this.txtDescription);
            this.gbContainer.Controls.Add(this.lblPriorityDate);
            this.gbContainer.Controls.Add(this.lblDescription);
            this.gbContainer.Controls.Add(this.txtName);
            this.gbContainer.Controls.Add(this.lblLocalization);
            this.gbContainer.Controls.Add(this.txtCode);
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(535, 274);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Task Data";
            // 
            // lblIdTeam
            // 
            this.lblIdTeam.AutoSize = true;
            this.lblIdTeam.Location = new System.Drawing.Point(149, 26);
            this.lblIdTeam.Name = "lblIdTeam";
            this.lblIdTeam.Size = new System.Drawing.Size(48, 13);
            this.lblIdTeam.TabIndex = 9;
            this.lblIdTeam.Text = "ID Team";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(351, 23);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(170, 20);
            this.txtProject.TabIndex = 8;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(306, 26);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 7;
            this.lblProject.Text = "Project";
            // 
            // mcalPriorityDate
            // 
            this.mcalPriorityDate.Location = new System.Drawing.Point(329, 98);
            this.mcalPriorityDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.mcalPriorityDate.Name = "mcalPriorityDate";
            this.mcalPriorityDate.ShowTodayCircle = false;
            this.mcalPriorityDate.TabIndex = 5;
            this.mcalPriorityDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcalPriorityDate_DateChanged);
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
            // txtLocalization
            // 
            this.txtLocalization.Location = new System.Drawing.Point(72, 240);
            this.txtLocalization.Name = "txtLocalization";
            this.txtLocalization.Size = new System.Drawing.Size(240, 20);
            this.txtLocalization.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 98);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(303, 130);
            this.txtDescription.TabIndex = 4;
            // 
            // lblPriorityDate
            // 
            this.lblPriorityDate.AutoSize = true;
            this.lblPriorityDate.Location = new System.Drawing.Point(326, 82);
            this.lblPriorityDate.Name = "lblPriorityDate";
            this.lblPriorityDate.Size = new System.Drawing.Size(64, 13);
            this.lblPriorityDate.TabIndex = 0;
            this.lblPriorityDate.Text = "Priority Date";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(44, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(477, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblLocalization
            // 
            this.lblLocalization.AutoSize = true;
            this.lblLocalization.Location = new System.Drawing.Point(6, 244);
            this.lblLocalization.Name = "lblLocalization";
            this.lblLocalization.Size = new System.Drawing.Size(63, 13);
            this.lblLocalization.TabIndex = 0;
            this.lblLocalization.Text = "Localization";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(44, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(99, 20);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(472, 292);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(174, 292);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteTask.TabIndex = 8;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(93, 292);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(75, 39);
            this.btnUpdateTask.TabIndex = 7;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(12, 292);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 39);
            this.btnCreateTask.TabIndex = 10;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(255, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbIdTeams
            // 
            this.cbIdTeams.FormattingEnabled = true;
            this.cbIdTeams.Location = new System.Drawing.Point(203, 21);
            this.cbIdTeams.Name = "cbIdTeams";
            this.cbIdTeams.Size = new System.Drawing.Size(97, 21);
            this.cbIdTeams.TabIndex = 10;
            // 
            // frmTaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 339);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnDeleteTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTaskManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Task Management ";
            this.Load += new System.EventHandler(this.frmTaskManagement_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblLocalization;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPriorityDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.TextBox txtLocalization;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.MonthCalendar mcalPriorityDate;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblIdTeam;
        private System.Windows.Forms.ComboBox cbIdTeams;
    }
}