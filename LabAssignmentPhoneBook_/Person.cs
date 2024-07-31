using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignmentPhoneBook_
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
    public static class Data
    {
        public static Dictionary<string, Person> PhoneBook = new Dictionary<string, Person>();

        static Data()
        {
            PhoneBook.Add("MarySmith", new Person { FirstName = "Mary", LastName = "Smith", MobilePhone = "410-837-7631", WorkPhone = "327-765-9764", Address = "873 Cali Street Tx" });
            PhoneBook.Add("Josh Wood", new Person { FirstName = "Josh", LastName = "Woods", MobilePhone = "871-333-5502", WorkPhone = "254-536-5879", Address = "254 Bark Street Tx" });
            PhoneBook.Add("Taylor Mugg", new Person { FirstName = "Taylor", LastName = "Mugg", MobilePhone = "510-837-7631", WorkPhone = "125-254-8545", Address = "111 Bar Street Md" });
            PhoneBook.Add("Shannon Gladstore", new Person { FirstName = "Shannon", LastName = "Gladstore", MobilePhone = "457-999-7631", WorkPhone = "443-765-8884", Address = " 777 Destiny Road Fl" });
            PhoneBook.Add("Tyrone Taylor", new Person { FirstName = "Tyrone", LastName = "Taylor", MobilePhone = "845-837-7631", WorkPhone = " 310-765-9842", Address = "444 Dog Street Az" });
        }
    }

}
