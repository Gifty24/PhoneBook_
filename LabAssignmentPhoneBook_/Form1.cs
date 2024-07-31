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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            //Loading the phonebook to the gridview and binding it
            var bindingList=new BindingList<Person>(Data.PhoneBook.Values.ToList());
            var source=new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddDelete_Click(object sender, EventArgs e)
        {
            var addDeleteForm = new AddDeleteForm();
            addDeleteForm.ShowDialog();
            LoadData(); //reloading the phonebook after adding/deleting
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
