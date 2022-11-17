using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESSBOOK
{
    internal class AddressBook
    {
        List<Contact> contacts = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNo + "\n" + contact.Email);
            }
        }
        public void EditContact(string name)
        {
            foreach (var contact in contacts)
            {
                if (contact.FirstName == name)
                {
                    Console.WriteLine("---------------------------\n");
                    Console.WriteLine("Enter The Option To Update");
                    Contact contact1 = new Contact();
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter LastName to Update");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Address to Update");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter City to Update");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter State to Update");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Zip to Update");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter PhoneNo to Update");
                            contact.PhoneNo = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter Email to Update");
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    Console.WriteLine("....Edited Contact List........");
                    Display();
                }

            }
        }
    }
}
    