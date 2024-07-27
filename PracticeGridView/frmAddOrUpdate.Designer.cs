namespace PracticeGridView
{
    partial class frmAddOrUpdate
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
            lblName = new Label();
            txtName = new TextBox();
            lblAge = new Label();
            cmbAge = new ComboBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            gbxGender = new GroupBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            btnAddUser = new Button();
            gbxGender.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(61, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 26);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // txtName
            // 
            txtName.AllowDrop = true;
            txtName.Location = new Point(208, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 27);
            txtName.TabIndex = 1;
            txtName.KeyPress += txtTexBox_Keypress;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.ForeColor = SystemColors.ControlText;
            lblAge.Location = new Point(61, 158);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(55, 26);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // cmbAge
            // 
            cmbAge.DropDownHeight = 100;
            cmbAge.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAge.FormattingEnabled = true;
            cmbAge.IntegralHeight = false;
            cmbAge.ItemHeight = 20;
            cmbAge.Location = new Point(208, 156);
            cmbAge.Name = "cmbAge";
            cmbAge.Size = new Size(45, 28);
            cmbAge.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(61, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(116, 26);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(208, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(173, 27);
            txtLastName.TabIndex = 5;
            txtLastName.KeyPress += txtTexBox_Keypress;
            // 
            // gbxGender
            // 
            gbxGender.Controls.Add(rdbFemale);
            gbxGender.Controls.Add(rdbMale);
            gbxGender.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxGender.Location = new Point(61, 223);
            gbxGender.Name = "gbxGender";
            gbxGender.Size = new Size(229, 132);
            gbxGender.TabIndex = 6;
            gbxGender.TabStop = false;
            gbxGender.Text = "Gender:";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(25, 96);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(100, 30);
            rdbFemale.TabIndex = 1;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(25, 47);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(78, 30);
            rdbMale.TabIndex = 0;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = SystemColors.MenuBar;
            btnAddUser.Location = new Point(86, 392);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(239, 37);
            btnAddUser.TabIndex = 7;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnSendUserInfo_Click;
            // 
            // frmAddOrUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(429, 462);
            Controls.Add(btnAddUser);
            Controls.Add(gbxGender);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cmbAge);
            Controls.Add(lblAge);
            Controls.Add(txtName);
            Controls.Add(lblName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddOrUpdate";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frmAddOrUpdate_FormClosing;
            Load += frmAddOrUpdate_Load;
            gbxGender.ResumeLayout(false);
            gbxGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private ComboBox cmbAge;
        private Label lblLastName;
        private TextBox txtLastName;
        private GroupBox gbxGender;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Button btnAddUser;
    }
}