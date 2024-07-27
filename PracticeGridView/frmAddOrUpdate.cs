using PracticeGridView.Entities;

namespace PracticeGridView
{
    public partial class frmAddOrUpdate : Form
    {
        public frmAddOrUpdate()
        {
            InitializeComponent();
        }

        #region variables

        public string name, lastName, gender;
        public int age;
        public bool isOperationIsSuccessufull = true;

        #endregion variables
        private void frmAddOrUpdate_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 111; i++)
            {
                cmbAge.Items.Add(i);
            }
        }

        private void btnSendUserInfo_Click(object sender, EventArgs e)
        {
            if (!CheckControlsEmpty(ref name, ref lastName, ref age, ref gender))
            {
                return;
            }
            else
            {
                frmUsersCRUD frmUsersCRUD = this.Owner as frmUsersCRUD;
                if (frmUsersCRUD != null)
                {
                    frmUsersCRUD.name = name;
                    frmUsersCRUD.lastName = lastName;
                    frmUsersCRUD.gender = gender;
                    frmUsersCRUD.age = age;
                }
                isOperationIsSuccessufull = false;
                this.Close();
                this.Dispose();
            }

        }

        private void txtTexBox_Keypress(object sender, KeyPressEventArgs e)
        {
            CkeckData.CheckTextBox(e);
        }

        #region methods

        string GetGender()
        {
            if (rdbMale.Checked)
            {
                return rdbMale.Text;
            }
            else if (rdbFemale.Checked)
            {
                return rdbFemale.Text;
            }
            return string.Empty;
        }

        public bool CheckControlsEmpty(ref string name, ref string lastName, ref int age, ref string gender)
        {
            name = txtName.Text;
            lastName = txtLastName.Text;

            if (int.TryParse(cmbAge.GetItemText(cmbAge.SelectedItem), out int val))
            {
                age = val;
            }
            else
            {
                age = 0;
            }
            gender = GetGender();

            if (name == "" || lastName == "" || age == 0 || gender == string.Empty)
            {
                MessageBox.Show("there can be no empty spaces", "Aler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion methods


        private void frmAddOrUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }

}