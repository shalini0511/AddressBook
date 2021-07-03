using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddBook
    {
        static void Main(string[] args)
        {
            AddressBook.AddrBook.GetCustomer();
            AddressBook.AddrBook.Modify();
            AddressBook.AddrBook.ListingPeople();
            AddressBook.AddrBook.RemovePeople();

        }
    }
}
