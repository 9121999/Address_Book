using AddressBook;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "Prerana",
                LastName = "Dahiwade",
                Address = "Karanja",
                City = "Nagpur",
                State = "Maharastra",
                Zip = 442203,
                PhoneNo = "8976542345",
                Email = "preranad@gmail.com"

            };
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNo + "\n" + contact.Email);
        }
    }
}