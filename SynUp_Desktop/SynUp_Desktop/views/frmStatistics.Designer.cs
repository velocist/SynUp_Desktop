namespace SynUp_Desktop.views
{
    partial class frmStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.dgvStadistics = new System.Windows.Forms.DataGridView();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.chtStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            this.cmbRanking = new System.Windows.Forms.ComboBox();
            this.cmbStates = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.pbxIconMessage = new System.Windows.Forms.PictureBox();
            this.lblHelpMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadistics)).BeginInit();
            this.gbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtStatistics)).BeginInit();
            this.gbHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(8, 33);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 17);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "",
            "Active tasks in a period",
            "Tasks by team",
            "Task by employee",
            "Task by state",
            "Ranking"});
            this.cmbFilter.Location = new System.Drawing.Point(55, 30);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(191, 24);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // dgvStadistics
            // 
            this.dgvStadistics.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvStadistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStadistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStadistics.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvStadistics.Location = new System.Drawing.Point(8, 321);
            this.dgvStadistics.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStadistics.Name = "dgvStadistics";
            this.dgvStadistics.Size = new System.Drawing.Size(975, 200);
            this.dgvStadistics.TabIndex = 0;
            // 
            // gbContainer
            // 
            this.gbContainer.BackgroundImage = global::SynUp_Desktop.Properties.Resources.SynUp;
            this.gbContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbContainer.Controls.Add(this.chtStatistics);
            this.gbContainer.Controls.Add(this.btnHelp);
            this.gbContainer.Controls.Add(this.btnBack);
            this.gbContainer.Controls.Add(this.cmbRanking);
            this.gbContainer.Controls.Add(this.cmbStates);
            this.gbContainer.Controls.Add(this.cmbEmployee);
            this.gbContainer.Controls.Add(this.cmbTeams);
            this.gbContainer.Controls.Add(this.lblInstructions);
            this.gbContainer.Controls.Add(this.lblDate2);
            this.gbContainer.Controls.Add(this.lblDate1);
            this.gbContainer.Controls.Add(this.dtpEnd);
            this.gbContainer.Controls.Add(this.dtpBegin);
            this.gbContainer.Controls.Add(this.btnSearch);
            this.gbContainer.Controls.Add(this.lblFilter);
            this.gbContainer.Controls.Add(this.cmbFilter);
            this.gbContainer.Controls.Add(this.dgvStadistics);
            this.gbContainer.Location = new System.Drawing.Point(16, 40);
            this.gbContainer.Margin = new System.Windows.Forms.Padding(4);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Padding = new System.Windows.Forms.Padding(4);
            this.gbContainer.Size = new System.Drawing.Size(996, 529);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "List of Statistics";
            // 
            // chtStatistics
            // 
            this.chtStatistics.BorderlineColor = System.Drawing.Color.Black;
            this.chtStatistics.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chtStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtStatistics.Legends.Add(legend1);
            this.chtStatistics.Location = new System.Drawing.Point(460, 23);
            this.chtStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.chtStatistics.Name = "chtStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtStatistics.Series.Add(series1);
            this.chtStatistics.Size = new System.Drawing.Size(523, 290);
            this.chtStatistics.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(311, 286);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 28);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHelp_MouseClick);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(352, 265);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(100, 49);
            this.btnBack.TabIndex = 7;
            // 
            // cmbRanking
            // 
            this.cmbRanking.FormattingEnabled = true;
            this.cmbRanking.Items.AddRange(new object[] {
            "Teams",
            "Employees"});
            this.cmbRanking.Location = new System.Drawing.Point(291, 66);
            this.cmbRanking.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRanking.Name = "cmbRanking";
            this.cmbRanking.Size = new System.Drawing.Size(160, 24);
            this.cmbRanking.TabIndex = 2;
            // 
            // cmbStates
            // 
            this.cmbStates.FormattingEnabled = true;
            this.cmbStates.Items.AddRange(new object[] {
            "Not selected",
            "Ongoing",
            "Finished",
            "Abandoned",
            "Cancelled"});
            this.cmbStates.Location = new System.Drawing.Point(291, 66);
            this.cmbStates.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(160, 24);
            this.cmbStates.TabIndex = 2;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(291, 66);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(160, 24);
            this.cmbEmployee.TabIndex = 2;
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(291, 66);
            this.cmbTeams.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(160, 24);
            this.cmbTeams.TabIndex = 2;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(8, 70);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(71, 17);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select the";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(8, 151);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(37, 17);
            this.lblDate2.TabIndex = 0;
            this.lblDate2.Text = "End:";
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(8, 111);
            this.lblDate1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(100, 17);
            this.lblDate1.TabIndex = 0;
            this.lblDate1.Text = "Between Start:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(185, 151);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(265, 23);
            this.dtpEnd.TabIndex = 4;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(185, 111);
            this.dtpBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(265, 23);
            this.dtpBegin.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 265);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 49);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbHelp
            // 
            this.gbHelp.Controls.Add(this.pbxIconMessage);
            this.gbHelp.Controls.Add(this.lblHelpMessage);
            this.gbHelp.Location = new System.Drawing.Point(16, 576);
            this.gbHelp.Margin = new System.Windows.Forms.Padding(4);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Padding = new System.Windows.Forms.Padding(4);
            this.gbHelp.Size = new System.Drawing.Size(997, 59);
            this.gbHelp.TabIndex = 0;
            this.gbHelp.TabStop = false;
            this.gbHelp.Text = "Help";
            // 
            // pbxIconMessage
            // 
            this.pbxIconMessage.Location = new System.Drawing.Point(7, 22);
            this.pbxIconMessage.Margin = new System.Windows.Forms.Padding(4);
            this.pbxIconMessage.Name = "pbxIconMessage";
            this.pbxIconMessage.Size = new System.Drawing.Size(33, 31);
            this.pbxIconMessage.TabIndex = 0;
            this.pbxIconMessage.TabStop = false;
            // 
            // lblHelpMessage
            // 
            this.lblHelpMessage.AutoSize = true;
            this.lblHelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpMessage.Location = new System.Drawing.Point(47, 27);
            this.lblHelpMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelpMessage.MaximumSize = new System.Drawing.Size(573, 49);
            this.lblHelpMessage.Name = "lblHelpMessage";
            this.lblHelpMessage.Size = new System.Drawing.Size(82, 13);
            this.lblHelpMessage.TabIndex = 0;
            this.lblHelpMessage.Text = "Message help...";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 575);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.gbContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1040, 685);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1040, 618);
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadistics)).EndInit();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtStatistics)).EndInit();
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DataGridView dgvStadistics;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ComboBox cmbStates;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbRanking;
        private utilities.GenericButton btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtStatistics;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbHelp;
        private System.Windows.Forms.PictureBox pbxIconMessage;
        private System.Windows.Forms.Label lblHelpMessage;
    }
}