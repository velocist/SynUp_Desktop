namespace SynUp_Desktop.views
{
    partial class frmAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.tmrAbout = new System.Windows.Forms.Timer(this.components);
            this.pbxCredits = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAbout
            // 
            this.tmrAbout.Interval = 60;
            this.tmrAbout.Tick += new System.EventHandler(this.tmrAbout_Tick);
            // 
            // pbxCredits
            // 
            this.pbxCredits.BackColor = System.Drawing.Color.Transparent;
            this.pbxCredits.Image = global::SynUp_Desktop.Properties.Resources.Creditos;
            this.pbxCredits.Location = new System.Drawing.Point(45, 400);
            this.pbxCredits.Name = "pbxCredits";
            this.pbxCredits.Size = new System.Drawing.Size(353, 403);
            this.pbxCredits.TabIndex = 0;
            this.pbxCredits.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SynUp_Desktop.Properties.Resources.SynUpOriginal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 407);
            this.Controls.Add(this.pbxCredits);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 450);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - About";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAbout_FormClosing);
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAbout;
        private System.Windows.Forms.PictureBox pbxCredits;
    }
}