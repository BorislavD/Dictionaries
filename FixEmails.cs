using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> collection = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (!input.Equals("stop"))
            {
                string email = Console.ReadLine().ToLower();
                string[] arr = email.Split('.');
                if (!arr[1].Equals("us") & !arr[1].Equals("uk"))
                {
                    if (!collection.ContainsKey(input))
                    {
                        collection.Add(input, email);
                    }

                    collection[input] = email;
                }
              
                input = Console.ReadLine();
            }

            foreach (var item in collection)
            {
                Console.WriteLine("{0} -> {1}", item.Key.ToLower(), item.Value.ToLower());
            }
        }
    }
}
