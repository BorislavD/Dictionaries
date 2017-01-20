using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    using System.Text.RegularExpressions;

    class HandsOfCards
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
            string input = Console.ReadLine().Trim();
            while (!input.Equals("JOKER"))
            {
                string[] arrFirst = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string name = arrFirst[0];
                string[] cards = arrFirst[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!collection.ContainsKey(name))
                {
                    collection.Add(name, new List<string>());
                }

                foreach (var card in cards)
                {
                    collection[name].Add(card);
                }
                
                input = Console.ReadLine();
            }
            
            foreach (var item in collection)
            {
                string name = item.Key;
                List<string> cards = item.Value.Distinct().ToList();
                int sum = 0;
                foreach (var card in cards)
                {
                    string powerOfCard = card.Substring(0, card.Length - 1);
                    string typeOfCard = card.Substring(card.Length - 1);
                    int powerInt = 1;
                    int typeInt = 1;
                    switch (powerOfCard)
                    {
                        case "2":
                            powerInt = 2;
                            break;
                        case "3":
                            powerInt = 3;
                            break;
                        case "4":
                            powerInt = 4;
                            break;
                        case "5":
                            powerInt = 5;
                            break;
                        case "6":
                            powerInt = 6;
                            break;
                        case "7":
                            powerInt = 7;
                            break;
                        case "8":
                            powerInt = 8;
                            break;
                        case "9":
                            powerInt = 9;
                            break;
                        case "10":
                            powerInt = 10;
                            break;
                        case "J":
                            powerInt = 11;
                            break;
                        case "Q":
                            powerInt = 12;
                            break;
                        case "K":
                            powerInt = 13;
                            break;
                        case "A":
                            powerInt = 14;
                            break;
                    }

                    switch (typeOfCard)
                    {
                        case "S":
                            typeInt = 4;
                            break;
                        case "H":
                            typeInt = 3;
                            break;
                        case "D":
                            typeInt = 2;
                            break;
                        case "C":
                            typeInt = 1;
                            break;
                    }

                    sum += typeInt * powerInt;
                }

                Console.WriteLine("{0}: {1}", name, sum);
            }
        }
    }
}
