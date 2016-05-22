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
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.dgvStadistics = new System.Windows.Forms.DataGridView();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.chtStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadistics)).BeginInit();
            this.gbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtStatistics)).BeginInit();
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
            this.cmbFilter.Items.AddRange(new object[] {
            "",
            "Active tasks in a period",
            "Tasks by team",
            "Task by employee",
            "Task by state",
            "Ranking"});
            this.cmbFilter.Location = new System.Drawing.Point(41, 24);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(144, 21);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // dgvStadistics
            // 
            this.dgvStadistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStadistics.Location = new System.Drawing.Point(6, 261);
            this.dgvStadistics.Name = "dgvStadistics";
            this.dgvStadistics.Size = new System.Drawing.Size(731, 183);
            this.dgvStadistics.TabIndex = 0;
            // 
            // gbContainer
            // 
            this.gbContainer.Controls.Add(this.chtStatistics);
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
            this.gbContainer.Location = new System.Drawing.Point(12, 12);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Size = new System.Drawing.Size(750, 450);
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
            this.chtStatistics.Location = new System.Drawing.Point(345, 19);
            this.chtStatistics.Name = "chtStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtStatistics.Series.Add(series1);
            this.chtStatistics.Size = new System.Drawing.Size(392, 236);
            this.chtStatistics.TabIndex = 15;
            // 
            // cmbRanking
            // 
            this.cmbRanking.FormattingEnabled = true;
            this.cmbRanking.Items.AddRange(new object[] {
            "Teams",
            "Employees"});
            this.cmbRanking.Location = new System.Drawing.Point(218, 54);
            this.cmbRanking.Name = "cmbRanking";
            this.cmbRanking.Size = new System.Drawing.Size(121, 21);
            this.cmbRanking.TabIndex = 13;
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
            this.cmbStates.Location = new System.Drawing.Point(218, 54);
            this.cmbStates.Name = "cmbStates";
            this.cmbStates.Size = new System.Drawing.Size(121, 21);
            this.cmbStates.TabIndex = 12;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(218, 54);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployee.TabIndex = 11;
            // 
            // cmbTeams
            // 
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(218, 54);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(121, 21);
            this.cmbTeams.TabIndex = 10;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(6, 57);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(55, 13);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Select the";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(6, 123);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(29, 13);
            this.lblDate2.TabIndex = 8;
            this.lblDate2.Text = "End:";
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Location = new System.Drawing.Point(6, 90);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(77, 13);
            this.lblDate1.TabIndex = 7;
            this.lblDate1.Text = "Between Start:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(139, 123);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 6;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(139, 90);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(264, 215);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 14;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 472);
            this.Controls.Add(this.gbContainer);
            this.MinimumSize = new System.Drawing.Size(640, 510);
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadistics)).EndInit();
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtStatistics)).EndInit();
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
    }
}