using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string toLow = input.ToLower();
            string[] arr = toLow.Split(' ');

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in arr)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }
            }

         
            List<string> result = new List<string>();

            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
