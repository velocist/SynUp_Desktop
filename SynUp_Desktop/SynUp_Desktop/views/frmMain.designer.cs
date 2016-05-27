namespace SynUp_Desktop.views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStadistics = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.linkUserManuall = new System.Windows.Forms.LinkLabel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(114, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SynUp Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(13, 206);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(459, 58);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(13, 271);
            this.btnTeams.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(459, 58);
            this.btnTeams.TabIndex = 2;
            this.btnTeams.Text = "Teams";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(13, 336);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(4);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(459, 58);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 532);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(459, 58);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStadistics
            // 
            this.btnStadistics.Location = new System.Drawing.Point(13, 402);
            this.btnStadistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnStadistics.Name = "btnStadistics";
            this.btnStadistics.Size = new System.Drawing.Size(459, 58);
            this.btnStadistics.TabIndex = 4;
            this.btnStadistics.Text = "Statistics";
            this.btnStadistics.UseVisualStyleBackColor = true;
            this.btnStadistics.Click += new System.EventHandler(this.btnStadistics_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(13, 467);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(459, 58);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // linkUserManuall
            // 
            this.linkUserManuall.AutoSize = true;
            this.linkUserManuall.BackColor = System.Drawing.Color.Transparent;
            this.linkUserManuall.Location = new System.Drawing.Point(391, 601);
            this.linkUserManuall.Name = "linkUserManuall";
            this.linkUserManuall.Size = new System.Drawing.Size(87, 17);
            this.linkUserManuall.TabIndex = 7;
            this.linkUserManuall.TabStop = true;
            this.linkUserManuall.Text = "UserManuall";
            this.linkUserManuall.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkUserManuall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUserManuall_LinkClicked);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.Image = global::SynUp_Desktop.Properties.Resources.SynUpOriginal;
            this.pbxLogo.Location = new System.Drawing.Point(145, 48);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(196, 149);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 627);
            this.Controls.Add(this.linkUserManuall);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStadistics);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnAbout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 670);
            this.MinimumSize = new System.Drawing.Size(510, 670);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStadistics;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.LinkLabel linkUserManuall;
    }
}

