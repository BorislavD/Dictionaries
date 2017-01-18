using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    using System.Data;

    class PhoneBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (!input.Equals("END"))
            {
                string[] arr = input.Split();
                string command = arr[0];
                string name = arr[1];
                if (command.Equals("A"))
                {
                    string telephoneNumber = arr[2];
                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook.Add(name, telephoneNumber);
                    }
                    else
                    {
                        phoneBook[name] = telephoneNumber;
                    }
                }

                else if (command.Equals("S"))
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }

                input = Console.ReadLine();
            }
        }

    }
}






