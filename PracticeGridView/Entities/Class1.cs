using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGridView.Entities
{
    public class User
    {
        private static int lastId = 0;

        private int id = 0;

        public int Id =>  id;
        public string Name { get; set; }   
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public User (string name, string lastName, string gender, int age)
        {
            id = ++lastId;
            Name = name;
            LastName = lastName;
            Gender = gender;
            Age = age;
        }
    }
    public class CkeckData
    {
        public static void CheckTextBox(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Only are allowed letters", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}   
