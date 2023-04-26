using Developer_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Developer_Assignment.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ContactHandler Contacts { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public MainViewModel() 
        {
            Contacts = new ContactHandler();

        }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get 
            { 
                //t
            }
        }

    }
}
