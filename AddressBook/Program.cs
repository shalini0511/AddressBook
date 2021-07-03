using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Addr
    {
        //main Method-Calling the method present in AddrBook class by using switch case
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "2":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.Modify();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "3":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "4":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }



        }
    }
}


