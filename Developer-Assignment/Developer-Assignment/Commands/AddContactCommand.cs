using Developer_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Developer_Assignment.Commands
{
    class AddContactCommand : ICommand
    {
        public ContactHandler ContactHandler;
        public Contact Contact;

        public AddContactCommand (Contact contact)
        {
            Contact = contact;
        }

        public event EventHandler? CanExecuteChanged;
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //execute the addcontact function
            Contact.addContact();
        }
    }
}
