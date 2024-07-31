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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fullName= txtFullName.Text;
            if (Data.PhoneBook.ContainsKey(fullName))
            {
                var person= Data.PhoneBook[fullName];
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtMobilePhone.Text = person.MobilePhone;
                txtWorkPhone.Text = person.WorkPhone;
                txtAddress.Text = person.Address;

            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }
    }
}
