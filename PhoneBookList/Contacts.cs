using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookList
{
    internal class Contacts
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public string email { get; set; }

        public Contacts(string name, int number, int age)
        {
            Name = name;
            Number = number;
            Age = age;
        }

    }
}
