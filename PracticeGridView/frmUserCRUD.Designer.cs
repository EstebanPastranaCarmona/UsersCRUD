namespace PracticeGridView
{
    partial class frmUsersCRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dtgvGridUser = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource1 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            btnDisplayAddUserForm = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblMenu = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dtgvGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgvGridUser
            // 
            dtgvGridUser.AutoGenerateColumns = false;
            dtgvGridUser.BackgroundColor = SystemColors.ActiveCaption;
            dtgvGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvGridUser.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn });
            dtgvGridUser.DataSource = userBindingSource1;
            dtgvGridUser.GridColor = SystemColors.MenuHighlight;
            dtgvGridUser.Location = new Point(12, 31);
            dtgvGridUser.Name = "dtgvGridUser";
            dtgvGridUser.ReadOnly = true;
            dtgvGridUser.RowHeadersWidth = 51;
            dtgvGridUser.Size = new Size(696, 409);
            dtgvGridUser.TabIndex = 0;
            dtgvGridUser.MouseDown += dtgvGridUser_MouseDown;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(Entities.User);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Entities.User);
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(802, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnDisplayAddUserForm
            // 
            btnDisplayAddUserForm.BackColor = SystemColors.Menu;
            btnDisplayAddUserForm.ForeColor = SystemColors.ActiveCaptionText;
            btnDisplayAddUserForm.Location = new Point(769, 64);
            btnDisplayAddUserForm.Name = "btnDisplayAddUserForm";
            btnDisplayAddUserForm.Size = new Size(201, 50);
            btnDisplayAddUserForm.TabIndex = 2;
            btnDisplayAddUserForm.Text = "New User";
            btnDisplayAddUserForm.UseVisualStyleBackColor = false;
            btnDisplayAddUserForm.Click += btnDisplayAddUserForm_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = SystemColors.GradientActiveCaption;
            lblMenu.Location = new Point(725, 38);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(53, 20);
            lblMenu.TabIndex = 3;
            lblMenu.Text = "Search";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmUsersCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1014, 466);
            Controls.Add(lblMenu);
            Controls.Add(btnDisplayAddUserForm);
            Controls.Add(txtSearch);
            Controls.Add(dtgvGridUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUsersCRUD";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserCRUD";
            ((System.ComponentModel.ISupportInitialize)dtgvGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Button btnDisplayAddUserForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblMenu;
        public DataGridView dtgvGridUser;
        private BindingSource userBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private BindingSource userBindingSource1;
    }
}
