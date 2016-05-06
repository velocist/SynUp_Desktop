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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStadistics = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SynUp Application";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(12, 87);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(240, 23);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(12, 116);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(240, 23);
            this.btnTeams.TabIndex = 2;
            this.btnTeams.Text = "Teams";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(12, 145);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(240, 23);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStadistics
            // 
            this.btnStadistics.Location = new System.Drawing.Point(13, 175);
            this.btnStadistics.Name = "btnStadistics";
            this.btnStadistics.Size = new System.Drawing.Size(240, 23);
            this.btnStadistics.TabIndex = 4;
            this.btnStadistics.Text = "Stadistics";
            this.btnStadistics.UseVisualStyleBackColor = true;
            this.btnStadistics.Click += new System.EventHandler(this.btnStadistics_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 281);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(240, 23);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 345);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStadistics);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Main Menu";
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
    }
}

