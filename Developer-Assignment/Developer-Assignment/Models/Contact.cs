using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Assignment.Models
{
    class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string email, string address, string phoneNumber) 
        { 
            Name = name;
            Email = email;   
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
