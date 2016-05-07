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
            this.mcalPriorityDate = new System.Windows.Forms.MonthCalendar();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtLocalization = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPriorityDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLocalization = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.gbContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.mcalPriorityDate);
            this.gbContainer.Controls.Add(this.lblId);
            this.gbContainer.Controls.Add(this.lblCode);
            this.gbContainer.Controls.Add(this.txtLocalization);
            this.gbContainer.Controls.Add(this.lblName);
            this.gbContainer.Controls.Add(this.txtDescription);
            this.gbContainer.Controls.Add(this.lblPriorityDate);
            this.gbContainer.Controls.Add(this.lblDescription);
            this.gbContainer.Controls.Add(this.txtName);
            this.gbContainer.Controls.Add(this.lblLocalization);
            this.gbContainer.Controls.Add(this.txtCode);
            this.gbContainer.Controls.Add(this.txtId);
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(567, 274);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Task Data";
            // 
            // mcalPriorityDate
            // 
            this.mcalPriorityDate.Location = new System.Drawing.Point(333, 98);
            this.mcalPriorityDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.mcalPriorityDate.Name = "mcalPriorityDate";
            this.mcalPriorityDate.ShowTodayCircle = false;
            this.mcalPriorityDate.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(156, 26);
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
            this.lblPriorityDate.Location = new System.Drawing.Point(330, 82);
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
            this.txtName.Location = new System.Drawing.Point(47, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(493, 20);
            this.txtName.TabIndex = 3;
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
            this.txtCode.Location = new System.Drawing.Point(193, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(47, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(483, 292);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(93, 292);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteTask.TabIndex = 8;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(12, 292);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(75, 39);
            this.btnUpdateTask.TabIndex = 7;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // frmTaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 339);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnDeleteTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTaskManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Task Management ";
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
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
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.MonthCalendar mcalPriorityDate;
    }
}