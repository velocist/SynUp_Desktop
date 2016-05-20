namespace SynUp_Desktop.views
{
    partial class frmTeams
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
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnManagementTeams = new System.Windows.Forms.Button();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.gbContainer.SuspendLayout();
            this.SuspendLayout();
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
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(41, 24);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(152, 21);
            this.cmbFilter.TabIndex = 1;
            // 
            // btnManagementTeams
            // 
            this.btnManagementTeams.Location = new System.Drawing.Point(9, 407);
            this.btnManagementTeams.Name = "btnManagementTeams";
            this.btnManagementTeams.Size = new System.Drawing.Size(85, 40);
            this.btnManagementTeams.TabIndex = 2;
            this.btnManagementTeams.Text = "Management";
            this.btnManagementTeams.UseVisualStyleBackColor = true;
            this.btnManagementTeams.Click += new System.EventHandler(this.btnManagementTeams_Click);
            // 
            // dgvTeams
            // 
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Location = new System.Drawing.Point(9, 51);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.Size = new System.Drawing.Size(585, 347);
            this.dgvTeams.TabIndex = 0;
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.btnBack);
            this.gbContainer.Controls.Add(this.lblFilter);
            this.gbContainer.Controls.Add(this.cmbFilter);
            this.gbContainer.Controls.Add(this.btnManagementTeams);
            this.gbContainer.Controls.Add(this.dgvTeams);
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(600, 450);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "List of Teams";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(519, 407);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 3;
            // 
            // frmTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 472);
            this.Controls.Add(this.gbContainer);
            this.MinimumSize = new System.Drawing.Size(640, 510);
            this.Name = "frmTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Teams";
            this.Activated += new System.EventHandler(this.frmTeams_Activated);
            this.Load += new System.EventHandler(this.frmTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnManagementTeams;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.GroupBox gbContainer;
        private utilities.GenericButton btnBack;
    }
}