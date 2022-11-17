namespace ADDRESSBOOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            AddressBook addressBook = new AddressBook();
            while (flag)
            {
                Console.WriteLine("\nselect \n 1.AddContacts\n 2.EditContacts");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
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
                        Console.WriteLine("Added Contact:");
                        addressBook.AddContact(contact);
                        break;
                    case 2:
                        string FirstName = Console.ReadLine();
                        addressBook.EditContact(FirstName);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}