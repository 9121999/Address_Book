

namespace ADDRESSBOOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nselect Program\n 1.AddContacts");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBook addressBook = new AddressBook();
                        Contact contact = new Contact();
                        {
                            Console.WriteLine("Enter FirstName");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter LastName");
                            contact.LastName = Console.ReadLine();
                            Console.WriteLine("Enter Address");
                            contact.Address = Console.ReadLine();
                            Console.WriteLine("Enter City");
                            contact.City = Console.ReadLine();
                            Console.WriteLine("Enter State");
                            contact.State = Console.ReadLine();
                            Console.WriteLine("Enter Zip Code");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter PhoneNo");
                            contact.PhoneNo = Console.ReadLine();
                            Console.WriteLine("Enter Email");
                            contact.Email = Console.ReadLine();
                        }
                        Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNo + "\n" + contact.Email);
                        addressBook.AddContact(contact);
                        break;


                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }


            }


        }
    }
}