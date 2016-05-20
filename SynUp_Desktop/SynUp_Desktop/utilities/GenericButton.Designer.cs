namespace SynUp_Desktop.utilities
{
    partial class GenericButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGeneric = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneric
            // 
            this.btnGeneric.Location = new System.Drawing.Point(0, 0);
            this.btnGeneric.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Size = new System.Drawing.Size(75, 40);
            this.btnGeneric.TabIndex = 0;
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // GenericButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnGeneric);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GenericButton";
            this.Size = new System.Drawing.Size(75, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneric;
    }
}
