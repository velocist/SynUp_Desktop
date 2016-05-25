namespace SynUp_Desktop.views
{
    partial class frmEmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManagement));
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.lblMessageMandatory = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblHelpMessage = new System.Windows.Forms.Label();
            this.gbHelp = new System.Windows.Forms.GroupBox();
            this.pbxIconMessage = new System.Windows.Forms.PictureBox();
            this.btnBack = new SynUp_Desktop.utilities.GenericButton();
            this.btnClear = new SynUp_Desktop.utilities.GenericButton();
            this.gbContainer.SuspendLayout();
            this.gbHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(119, 254);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(100, 49);
            this.btnUpdateEmployee.TabIndex = 8;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(227, 254);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(100, 49);
            this.btnDeleteEmployee.TabIndex = 9;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(23, 38);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(34, 17);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 70);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(209, 70);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(9, 107);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 17);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 140);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email*";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(8, 175);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 17);
            this.lblAdress.TabIndex = 0;
            this.lblAdress.Text = "Adress";
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(67, 34);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(132, 23);
            this.txtNif.TabIndex = 1;
            this.txtNif.TextChanged += new System.EventHandler(this.txtNif_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 66);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(291, 66);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(295, 23);
            this.txtSurname.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(67, 103);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 23);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(67, 137);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(519, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(67, 169);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(519, 23);
            this.txtAdress.TabIndex = 6;
            // 
            // gbContainer
            // 
            this.gbContainer.BackColor = System.Drawing.Color.Transparent;
            this.gbContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbContainer.Controls.Add(this.lblMessageMandatory);
            this.gbContainer.Controls.Add(this.txtUsername);
            this.gbContainer.Controls.Add(this.lblUsername);
            this.gbContainer.Controls.Add(this.lblNif);
            this.gbContainer.Controls.Add(this.lblName);
            this.gbContainer.Controls.Add(this.txtAdress);
            this.gbContainer.Controls.Add(this.lblSurname);
            this.gbContainer.Controls.Add(this.txtEmail);
            this.gbContainer.Controls.Add(this.lblPhone);
            this.gbContainer.Controls.Add(this.txtPhone);
            this.gbContainer.Controls.Add(this.lblEmail);
            this.gbContainer.Controls.Add(this.txtSurname);
            this.gbContainer.Controls.Add(this.lblAdress);
            this.gbContainer.Controls.Add(this.txtName);
            this.gbContainer.Controls.Add(this.txtNif);
            this.gbContainer.Location = new System.Drawing.Point(16, 28);
            this.gbContainer.Margin = new System.Windows.Forms.Padding(4);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Padding = new System.Windows.Forms.Padding(4);
            this.gbContainer.Size = new System.Drawing.Size(593, 222);
            this.gbContainer.TabIndex = 0;
            this.gbContainer.TabStop = false;
            this.gbContainer.Text = "Employee Data";
            // 
            // lblMessageMandatory
            // 
            this.lblMessageMandatory.AutoSize = true;
            this.lblMessageMandatory.Location = new System.Drawing.Point(463, 201);
            this.lblMessageMandatory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageMandatory.Name = "lblMessageMandatory";
            this.lblMessageMandatory.Size = new System.Drawing.Size(121, 17);
            this.lblMessageMandatory.TabIndex = 0;
            this.lblMessageMandatory.Text = "* Mandatory fields";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(291, 34);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 500;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(293, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(209, 38);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 254);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 49);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(470, 275);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 28);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHelp_MouseClick);
            // 
            // lblHelpMessage
            // 
            this.lblHelpMessage.AutoSize = true;
            this.lblHelpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHelpMessage.Location = new System.Drawing.Point(47, 20);
            this.lblHelpMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelpMessage.MaximumSize = new System.Drawing.Size(573, 49);
            this.lblHelpMessage.Name = "lblHelpMessage";
            this.lblHelpMessage.Size = new System.Drawing.Size(108, 17);
            this.lblHelpMessage.TabIndex = 0;
            this.lblHelpMessage.Text = "Message help...";
            // 
            // gbHelp
            // 
            this.gbHelp.BackColor = System.Drawing.Color.Transparent;
            this.gbHelp.Controls.Add(this.pbxIconMessage);
            this.gbHelp.Controls.Add(this.lblHelpMessage);
            this.gbHelp.Location = new System.Drawing.Point(11, 314);
            this.gbHelp.Margin = new System.Windows.Forms.Padding(4);
            this.gbHelp.Name = "gbHelp";
            this.gbHelp.Padding = new System.Windows.Forms.Padding(4);
            this.gbHelp.Size = new System.Drawing.Size(600, 68);
            this.gbHelp.TabIndex = 0;
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
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.ButtonText = "Back";
            this.btnBack.isExit = true;
            this.btnBack.Location = new System.Drawing.Point(511, 254);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Parent = this;
            this.btnBack.Size = new System.Drawing.Size(100, 49);
            this.btnBack.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.isExit = false;
            this.btnClear.Location = new System.Drawing.Point(335, 254);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Parent = this;
            this.btnClear.Size = new System.Drawing.Size(100, 49);
            this.btnClear.TabIndex = 10;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SynUp_Desktop.Properties.Resources.SynUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(620, 312);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 355);
            this.Name = "frmEmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SynUp - Employee Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployeeManagement_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            this.gbHelp.ResumeLayout(false);
            this.gbHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIconMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblHelpMessage;
        private System.Windows.Forms.GroupBox gbHelp;
        private utilities.GenericButton btnClear;
        private utilities.GenericButton btnBack;
        private System.Windows.Forms.Label lblMessageMandatory;
        private System.Windows.Forms.PictureBox pbxIconMessage;
    }
}