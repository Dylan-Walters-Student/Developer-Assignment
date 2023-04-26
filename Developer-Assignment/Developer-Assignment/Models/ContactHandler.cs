using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Assignment.Models
{
    class ContactHandler
    {
        private List<Contact> contacts;

        public ContactHandler() 
        { 
            contacts = new List<Contact>();
        }

        public void AddContact(/*string Name, string phoneNumber, string email, string address*/ Contact contact)
        {
            contacts.Add(contact);
        }
    }
}
