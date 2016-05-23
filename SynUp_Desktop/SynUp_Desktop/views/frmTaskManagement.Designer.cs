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
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(535, 302);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Task Data";
            // 
            // txtState
            // 
            this.txtState.AutoSize = true;
            this.txtState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtState.Location = new System.Drawing.Point(448, 78);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(73, 13);
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
            this.cbImportance.Location = new System.Drawing.Point(111, 268);
            this.cbImportance.Name = "cbImportance";
            this.cbImportance.Size = new System.Drawing.Size(125, 21);
            this.cbImportance.TabIndex = 15;
            // 
            // lblImportance
            // 
            this.lblImportance.Location = new System.Drawing.Point(6, 271);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(64, 13);
            this.lblImportance.TabIndex = 14;
            this.lblImportance.Text = "Importance";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(357, 78);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(85, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State of the task";
            // 
            // cbIdTeams
            // 
            this.cbIdTeams.FormattingEnabled = true;
            this.cbIdTeams.Location = new System.Drawing.Point(203, 21);
            this.cbIdTeams.Name = "cbIdTeams";
            this.cbIdTeams.Size = new System.Drawing.Size(97, 21);
            this.cbIdTeams.TabIndex = 10;
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
            this.txtProject.Location = new System.Drawing.Point(360, 23);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(161, 20);
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
            this.mcalPriorityDate.Location = new System.Drawing.Point(9, 100);
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
            this.lblCode.Size = new System.Drawing.Size(36, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code*";
            // 
            // txtLocalization
            // 
            this.txtLocalization.Location = new System.Drawing.Point(360, 49);
            this.txtLocalization.Name = "txtLocalization";
            this.txtLocalization.Size = new System.Drawing.Size(161, 20);
            this.txtLocalization.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name*";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(248, 100);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(273, 160);
            this.txtDescription.TabIndex = 4;
            // 
            // lblPriorityDate
            // 
            this.lblPriorityDate.AutoSize = true;
            this.lblPriorityDate.Location = new System.Drawing.Point(6, 78);
            this.lblPriorityDate.Name = "lblPriorityDate";
            this.lblPriorityDate.Size = new System.Drawing.Size(68, 13);
            this.lblPriorityDate.TabIndex = 0;
            this.lblPriorityDate.Text = "Priority Date*";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(245, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblLocalization
            // 
            this.lblLocalization.AutoSize = true;
            this.lblLocalization.Location = new System.Drawing.Point(306, 52);
            this.lblLocalization.Name = "lblLocalization";
            this.lblLocalization.Size = new System.Drawing.Size(48, 13);
            this.lblLocalization.TabIndex = 0;
            this.lblLocalization.Text = "Location";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(57, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(86, 20);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(174, 320);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteTask.TabIndex = 8;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(93, 320);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(75, 39);
            this.btnUpdateTask.TabIndex = 7;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(12, 320);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 39);
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
            this.btnClear.Location = new System.Drawing.Point(252, 320);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Parent = this;
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(472, 320);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 12;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(441, 336);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 23);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHelp_MouseClick);
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.pbxIconMessage);
            this.gbHelp.Controls.Add(this.lblHelpMessage);
            this.gbHelp.Location = new System.Drawing.Point(12, 365);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Size = new System.Drawing.Size(533, 55);
            this.gbHelp.TabIndex = 15;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Help";
            // 
            // pbxIconMessage
            // 
            this.pbxIconMessage.Location = new System.Drawing.Point(5, 15);
            this.pbxIconMessage.Name = "pbxIconMessage";
            this.pbxIconMessage.Size = new System.Drawing.Size(25, 25);
            this.pbxIconMessage.TabIndex = 1;
            this.pbxIconMessage.TabStop = false;
            // 
            // lblHelpMessage
            // 
            this.lblHelpMessage.AutoSize = true;
            this.lblHelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpMessage.Location = new System.Drawing.Point(35, 16);
            this.lblHelpMessage.MaximumSize = new System.Drawing.Size(430, 40);
            this.lblHelpMessage.Name = "lblHelpMessage";
            this.lblHelpMessage.Size = new System.Drawing.Size(82, 13);
            this.lblHelpMessage.TabIndex = 0;
            this.lblHelpMessage.Text = "Message help...";
            // 
            // frmTaskManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 367);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.btnDeleteTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(575, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(575, 405);
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
    }
}