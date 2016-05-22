namespace SynUp_Desktop.views
{
    partial class frmTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTasks));
            this.btnManagementTasks = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.pbxIconMessage = new System.Windows.Forms.PictureBox();
            this.lblHelpMessage = new System.Windows.Forms.Label();
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.gbContainer.SuspendLayout();
            this.gbHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManagementTasks
            // 
            this.btnManagementTasks.Location = new System.Drawing.Point(12, 459);
            this.btnManagementTasks.Name = "btnManagementTasks";
            this.btnManagementTasks.Size = new System.Drawing.Size(85, 40);
            this.btnManagementTasks.TabIndex = 2;
            this.btnManagementTasks.Text = "Management";
            this.btnManagementTasks.UseVisualStyleBackColor = true;
            this.btnManagementTasks.Click += new System.EventHandler(this.btnManagementTasks_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToOrderColumns = true;
            this.dgvTasks.AllowUserToResizeColumns = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTasks.Location = new System.Drawing.Point(9, 21);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowTemplate.ReadOnly = true;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(581, 404);
            this.dgvTasks.TabIndex = 1;
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.dgvTasks);
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(596, 431);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "List of Tasks";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(502, 476);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(28, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_MouseClick);
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.pbxIconMessage);
            this.gbHelp.Controls.Add(this.lblHelpMessage);
            this.gbHelp.Location = new System.Drawing.Point(103, 446);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Size = new System.Drawing.Size(393, 54);
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
            this.lblHelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpMessage.Location = new System.Drawing.Point(35, 22);
            this.lblHelpMessage.MaximumSize = new System.Drawing.Size(430, 40);
            this.lblHelpMessage.Name = "lblHelpMessage";
            this.lblHelpMessage.Size = new System.Drawing.Size(82, 13);
            this.lblHelpMessage.TabIndex = 0;
            this.lblHelpMessage.Text = "Message help...";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(533, 459);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 4;
            // 
            // frmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 504);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnManagementTasks);
            this.Controls.Add(this.gbContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 510);
            this.Name = "frmTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Tasks ";
            //this.Activated += new System.EventHandler(this.frmTasks_Activated);
            this.Load += new System.EventHandler(this.frmTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.gbContainer.ResumeLayout(false);
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManagementTasks;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.GroupBox gbContainer;
        private utilities.GenericButton btnBack;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.PictureBox pbxIconMessage;
        private System.Windows.Forms.Label lblHelpMessage;
    }
}