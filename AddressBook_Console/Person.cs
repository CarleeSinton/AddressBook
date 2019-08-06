using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_Console
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string[] Addresses { get; set; }
    }
}
