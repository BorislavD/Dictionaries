using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> collection =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Trim().Split();
                string name = arr[1];
                string ip = arr[0];
                int duration = int.Parse(arr[2]);

                if (!collection.ContainsKey(name))
                {
                    collection.Add(name, new SortedDictionary<string, int>());
                }

                if (!collection[name].ContainsKey(ip))
                {
                    collection[name].Add(ip, 0);
                }

                collection[name][ip] += duration;
            }

            foreach (var item in collection)
            {
                string name = item.Key;
                int durationTotal = item.Value.Values.Sum();
                List<string> ipList = item.Value.Keys.ToList();
                Console.WriteLine("{0}: {1} [{2}]", name, durationTotal, string.Join(", ", ipList));
            }
        }
    }
}
