using PracticeGridView.Entities;
namespace PracticeGridView
{
    public partial class frmUsersCRUD : Form
    {
        public frmUsersCRUD()
        {
            InitializeComponent();

            bindingSource = new BindingSource();
            //dtgvGridUser.AutoGenerateColumns = true;
            //dtgvGridUser.DataSource = bindingSource;
            LoadData();
            InitializeContextualMenu();
        }

        #region variables
        DataGridView.HitTestInfo rowRightClickLocation;
        List<User> userList = new List<User>();
        List<User> filterUsersList = new List<User>();
        private BindingSource bindingSource;
        frmAddOrUpdate frmAddOrUpdate;
        TextBox txtTexBoxName;
        Label lblLabelName;
        Label lblLabelAge;
        ComboBox cmbAge;
        RadioButton rdbMale, rdbFemale;
        GroupBox gbrGroupBox;

        public string name, lastName, gender;
        public int age;
        #endregion variables

        #region Methods
        public void LoadData()
        {
            bindingSource.DataSource = userList;
            bindingSource.ResetBindings(false);
        }

        public void AddUserToList()
        {
            User user = new User(name, lastName, gender, age);
            userList.Add(user);
            LoadData();
        }

        public void InitializeContextualMenu()
        {
            contextMenuStrip1.Items.Add("Delete", null, new EventHandler(DeleteContextualMenu_click));
            contextMenuStrip1.Items.Add("Update", null, new EventHandler(UpdateContextualManu_Click));
        }
        void CallFormAddOrUpdate()
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmAddOrUpdate = new frmAddOrUpdate();
                frmAddOrUpdate.Owner = this;
                frmAddOrUpdate.ShowDialog();

            }
        }
        int GetIndex()
        {
            if (filterUsersList.Count != 0)

            {
                int selectedIndex = rowRightClickLocation.RowIndex;
                for (int i = 0; i < userList.Count; i++)
                {
                    try
                    {
                        if (userList[i].Id == filterUsersList[selectedIndex].Id)
                        {
                            txtSearch.Text = "";
                            return i;

                        }
                    }
                    catch (ArgumentOutOfRangeException exception)
                    {
                        MessageBox.Show("Algo salio mal");
                    }
                }

            }
            else
            {
                txtSearch.Text = "";
                return rowRightClickLocation.RowIndex;

            }
            return 0;
        }
        #endregion Methods

        #region events
        private void btnDisplayAddUserForm_Click(object sender, EventArgs e)
        {
            CallFormAddOrUpdate();
            if (frmAddOrUpdate.isOperationIsSuccessufull)
            {
                return;
            }
            else
            {
                AddUserToList();
            }

        }

        private void dtgvGridUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rowRightClickLocation = dtgvGridUser.HitTest(e.X, e.Y);

                if (rowRightClickLocation.RowIndex >= 0)
                {
                    dtgvGridUser.ClearSelection();
                    dtgvGridUser.Rows[rowRightClickLocation.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dtgvGridUser, e.Location);
                }
            }
        }
        private void DeleteContextualMenu_click(object sender, EventArgs e)
        {
            int index = GetIndex();

            userList.RemoveAt(index);
            filterUsersList.Clear();
            LoadData();
        }
        private void UpdateContextualManu_Click(object sender, EventArgs e)
        {
            CallFormAddOrUpdate();
            int index = GetIndex();
            userList[index].Name = name;
            userList[index].LastName = lastName;
            userList[index].Age = age;
            userList[index].Gender = gender;
            filterUsersList.Clear();
            LoadData();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            CkeckData.CheckTextBox(e);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 3)
            {
                filterUsersList = userList.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                bindingSource.DataSource = filterUsersList;
            }
            else
            {
                bindingSource.DataSource = userList;
            }
        }
        #endregion events

    }
}
