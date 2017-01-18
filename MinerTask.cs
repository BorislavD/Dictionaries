using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> collection = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (!input.Equals("stop"))
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!collection.ContainsKey(input))
                {
                    collection.Add(input, quantity);
                }
                else
                {
                    collection[input] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var item in collection)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
