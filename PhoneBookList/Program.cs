
using PhoneBookList;
Console.WriteLine("To exit enter x");
Console.WriteLine("1 - Add Contact");
Console.WriteLine("2 - Delete Contact");
Console.WriteLine("3 - Display based on number");
Console.WriteLine("4 - Display all");
Console.WriteLine("5 - Search contacts");
var input = Console.ReadLine();
var phonebook = new PhoneBook();


while (true)
{
    switch (input)
    {
        case "1":
            Console.WriteLine("Insert number");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert name");
            var name = Console.ReadLine();
            Console.WriteLine("Insert age");
            var age = int.Parse(Console.ReadLine());
            var newcontact = new Contacts(name, number, age);
            phonebook.AddContact(newcontact);
            break;

        case "2":
            Console.WriteLine("Insert number");
            var numberdelete = int.Parse(Console.ReadLine());
            phonebook.RemoveContact(numberdelete);
            break;
        case "3":
            Console.WriteLine("Insert number");
            var numberdisplay = Console.ReadLine();
            phonebook.Find(numberdisplay);
            break;
        case "4":
            phonebook.DisplayAll();
            break;
        case "5":
            Console.WriteLine("Insert search phrase");
            var searchphrase = Console.ReadLine();
            phonebook.DisplayMatchingContacts(searchphrase);
            break;
        case "x":
            return;
        default:
            Console.WriteLine("invalid number");
            break;
    }
    input = Console.ReadLine();

}
