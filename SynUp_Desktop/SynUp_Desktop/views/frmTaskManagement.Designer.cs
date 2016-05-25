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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskManagement));
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.lblMandatory = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.Label();
            this.cbImportance = new System.Windows.Forms.ComboBox();
            this.lblImportance = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cbIdTeams = new System.Windows.Forms.ComboBox();
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
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnClear = new SynUp_Desktop.utilities.GenericButton();
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.pbxIconMessage = new System.Windows.Forms.PictureBox();
            this.lblHelpMessage = new System.Windows.Forms.Label();
            this.gbContainer.SuspendLayout();
            this.gbHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContainer
            // 
            this.gbContainer.BackColor = System.Drawing.Color.Transparent;
            this.gbContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbContainer.Controls.Add(this.lblMandatory);
            this.gbContainer.Controls.Add(this.txtState);
            this.gbContainer.Controls.Add(this.cbImportance);
            this.gbContainer.Controls.Add(this.lblImportance);
            this.gbContainer.Controls.Add(this.lblState);
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
            this.gbContainer.Location = new System.Drawing.Point(16, 26);
            this.gbContainer.Margin = new System.Windows.Forms.Padding(4);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Padding = new System.Windows.Forms.Padding(4);
            this.gbContainer.Size = new System.Drawing.Size(713, 361);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Task Data";
            // 
            // lblMandatory
            // 
            this.lblMandatory.AutoSize = true;
            this.lblMandatory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMandatory.Location = new System.Drawing.Point(573, 334);
            this.lblMandatory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMandatory.Name = "lblMandatory";
            this.lblMandatory.Size = new System.Drawing.Size(121, 17);
            this.lblMandatory.TabIndex = 17;
            this.lblMandatory.Text = "* Mandatory fields";
            this.lblMandatory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            this.txtState.AutoSize = true;
            this.txtState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtState.Location = new System.Drawing.Point(145, 300);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(93, 17);
            this.txtState.TabIndex = 16;
            this.txtState.Text = "NULL STATE";
            this.txtState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbImportance
            // 
            this.cbImportance.FormattingEnabled = true;
            this.cbImportance.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbImportance.Location = new System.Drawing.Point(148, 330);
            this.cbImportance.Margin = new System.Windows.Forms.Padding(4);
            this.cbImportance.Name = "cbImportance";
            this.cbImportance.Size = new System.Drawing.Size(165, 24);
            this.cbImportance.TabIndex = 15;
            // 
            // lblImportance
            // 
            this.lblImportance.Location = new System.Drawing.Point(8, 334);
            this.lblImportance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(85, 16);
            this.lblImportance.TabIndex = 14;
            this.lblImportance.Text = "Importance";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(8, 300);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(111, 17);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State of the task";
            // 
            // cbIdTeams
            // 
            this.cbIdTeams.FormattingEnabled = true;
            this.cbIdTeams.Location = new System.Drawing.Point(271, 26);
            this.cbIdTeams.Margin = new System.Windows.Forms.Padding(4);
            this.cbIdTeams.Name = "cbIdTeams";
            this.cbIdTeams.Size = new System.Drawing.Size(128, 24);
            this.cbIdTeams.TabIndex = 10;
            // 
            // lblIdTeam
            // 
            this.lblIdTeam.AutoSize = true;
            this.lblIdTeam.Location = new System.Drawing.Point(199, 32);
            this.lblIdTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTeam.Name = "lblIdTeam";
            this.lblIdTeam.Size = new System.Drawing.Size(61, 17);
            this.lblIdTeam.TabIndex = 9;
            this.lblIdTeam.Text = "ID Team";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(480, 28);
            this.txtProject.Margin = new System.Windows.Forms.Padding(4);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(213, 23);
            this.txtProject.TabIndex = 8;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(408, 32);
            this.lblProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(52, 17);
            this.lblProject.TabIndex = 7;
            this.lblProject.Text = "Project";
            // 
            // mcalPriorityDate
            // 
            this.mcalPriorityDate.Location = new System.Drawing.Point(411, 124);
            this.mcalPriorityDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcalPriorityDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.mcalPriorityDate.Name = "mcalPriorityDate";
            this.mcalPriorityDate.ShowTodayCircle = false;
            this.mcalPriorityDate.TabIndex = 5;
            this.mcalPriorityDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcalPriorityDate_DateChanged);
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
            // txtLocalization
            // 
            this.txtLocalization.Location = new System.Drawing.Point(480, 60);
            this.txtLocalization.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalization.Name = "txtLocalization";
            this.txtLocalization.Size = new System.Drawing.Size(213, 23);
            this.txtLocalization.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 65);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name*";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(95, 93);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(304, 193);
            this.txtDescription.TabIndex = 4;
            // 
            // lblPriorityDate
            // 
            this.lblPriorityDate.AutoSize = true;
            this.lblPriorityDate.Location = new System.Drawing.Point(408, 96);
            this.lblPriorityDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriorityDate.Name = "lblPriorityDate";
            this.lblPriorityDate.Size = new System.Drawing.Size(91, 17);
            this.lblPriorityDate.TabIndex = 0;
            this.lblPriorityDate.Text = "Priority Date*";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 96);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblLocalization
            // 
            this.lblLocalization.AutoSize = true;
            this.lblLocalization.Location = new System.Drawing.Point(408, 64);
            this.lblLocalization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalization.Name = "lblLocalization";
            this.lblLocalization.Size = new System.Drawing.Size(62, 17);
            this.lblLocalization.TabIndex = 0;
            this.lblLocalization.Text = "Location";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(76, 27);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(113, 23);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(232, 394);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(100, 48);
            this.btnDeleteTask.TabIndex = 8;
            this.btnDeleteTask.Text = "Cancel Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(124, 394);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(100, 48);
            this.btnUpdateTask.TabIndex = 7;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(16, 394);
            this.btnCreateTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(100, 48);
            this.btnCreateTask.TabIndex = 10;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.isExit = false;
            this.btnClear.Location = new System.Drawing.Point(336, 394);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Parent = this;
            this.btnClear.Size = new System.Drawing.Size(100, 49);
            this.btnClear.TabIndex = 13;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(629, 394);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(100, 49);
            this.btnBack.TabIndex = 12;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(588, 414);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 28);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHelp_MouseClick);
            // 
            // gbHelp
            // 
            this.gbHelp.BackColor = System.Drawing.Color.Transparent;
            this.gbHelp.Controls.Add(this.pbxIconMessage);
            this.gbHelp.Controls.Add(this.lblHelpMessage);
            this.gbHelp.Location = new System.Drawing.Point(16, 449);
            this.gbHelp.Margin = new System.Windows.Forms.Padding(4);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Padding = new System.Windows.Forms.Padding(4);
            this.gbHelp.Size = new System.Drawing.Size(711, 68);
            this.gbHelp.TabIndex = 15;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Help";
            // 
            // pbxIconMessage
            // 
            this.pbxIconMessage.Location = new System.Drawing.Point(7, 18);
            this.pbxIconMessage.Margin = new System.Windows.Forms.Padding(4);
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
            // frmTaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SynUp_Desktop.Properties.Resources.SynUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(740, 447);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnDeleteTask);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 570);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 490);
            this.Name = "frmTaskManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Task Management ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTaskManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmTaskManagement_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.MonthCalendar mcalPriorityDate;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Label lblIdTeam;
        private System.Windows.Forms.ComboBox cbIdTeams;
        private System.Windows.Forms.ComboBox cbImportance;
        private System.Windows.Forms.Label lblImportance;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label txtState;
        private utilities.GenericButton btnBack;
        private utilities.GenericButton btnClear;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.PictureBox pbxIconMessage;
        private System.Windows.Forms.Label lblHelpMessage;
        private System.Windows.Forms.Label lblMandatory;
    }
}