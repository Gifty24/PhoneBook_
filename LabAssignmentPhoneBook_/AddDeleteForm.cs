using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAssignmentPhoneBook_
{
    public partial class AddDeleteForm : Form
    {
        public AddDeleteForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //method to add people to the phone book 
            var person = new Person()
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                MobilePhone = txtMobilePhone.Text.Trim(),
                WorkPhone = txtWorkPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };
            string fullName = person.FullName;
            if (!Data.PhoneBook.ContainsKey(fullName))
            {
                Data.PhoneBook.Add(fullName, person);
                MessageBox.Show("Person added successfully!");
            }
            else
            {
                MessageBox.Show("A person with the same name already exists.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            var person = new Person()
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                MobilePhone = txtMobilePhone.Text.Trim(),
                WorkPhone = txtWorkPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };
            string fullName = $"{txtFirstName.Text.Trim()} {txtLastName.Text.Trim()}";
            //string fullName = txtFirstName.Text + " " + txtLastName.Text;
            if (Data.PhoneBook.ContainsKey(fullName))
            {
                var result = MessageBox.Show("Are you sure you want to delete this person?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Data.PhoneBook.Remove(fullName);
                    MessageBox.Show("Person deleted successfully");
                }
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }

        private void AddDeleteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
