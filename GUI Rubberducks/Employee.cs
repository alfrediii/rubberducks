using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Registration
{
    public class Employee
    {
        //Automatic Properties
        public string UserID { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        //will give the user a random ID number that is unique
        //public readonly int UserId;
        //gives the user a random password that they are able to change
        public string Password { get; set; }
        public string Approved { get; set; }

        //constructors
        public Employee()
        {

        }

        public Employee(string userid, string usertype, string firstname,
        string lastname, string jobtitle, string department,
        string username, string email, string phone, string address, string password, string approved)
        {
            UserID = userid;
            Username = usertype;
            FirstName = firstname;
            LastName = lastname;
            JobTitle = jobtitle;
            Department = department;
            Username = usertype;
            Email = email;
            Phone = phone;
            Address = address;
            Password = password;
            Approved = approved;
        }
    }
}
