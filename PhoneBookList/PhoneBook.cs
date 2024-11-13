using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneBookList
{
    internal class PhoneBook
    {
        public List<Contacts> Contacts { get; set; } = new List<Contacts>();

        private void DisplayContact(Contacts contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}, {contact.Age}, {contact.email}");
        }

        private void Loop(List<Contacts> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContact(contact);
            }
        }
        public void AddContact(Contacts contact)
        {
            if (!Regex.IsMatch(contact.Number.ToString(), @"^\d{3,9}$"))
            {
                Console.WriteLine("Invalid number format. Please use a number with 3 to 9 digits.");
                return;
            }
            Contacts.Add(contact);
            Console.WriteLine("Contact added successfully");
        }
        public void RemoveContact(int number)
        {
            var remove = Contacts.FirstOrDefault(c => c.Number.Equals(number));
            if (remove != null)
            {
                Contacts.Remove(remove);
                Console.WriteLine("Contact removed successfully");
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }

        public void Find(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number.Equals(number));
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContact(contact);
            }
        }

        public void DisplayAll()
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("No contacts found");
                return;
            }
            else
            {
                Loop(Contacts);
            }

        }

        public void DisplayMatchingContacts(string searchphrase)
        {
            if (Contacts.Count == 0)
            {
                Console.WriteLine("No contacts found");
                return;
            }
            else
            {
                var matching = Contacts.Where(c => c.Name.Contains(searchphrase)).ToList();
                Loop(matching);
            }
        }

    }
}
