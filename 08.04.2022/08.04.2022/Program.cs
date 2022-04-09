using System;
using System.Collections.Generic;

namespace _08._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Everything is going to shit
             *  Oh, it's hopeless
             *  I don't have a home
             *  And my brain is like a glass dome
            */
            string[] givenNames = new string[4];
            List<string> givenNamesList = new List<string>();
            Dictionary<int, string> givenNameDictionary = new Dictionary<int, string>();
            //int limit = 100000;
            //int counter = 0;

            while(true)
            {
                Console.WriteLine("Current list length");
                //Console.WriteLine(givenNamesList.Count);
                //Console.WriteLine(givenNames.Length);
                Console.WriteLine("************");
                Console.WriteLine("Type a name");
                givenNameDictionary.Add(givenNameDictionary.Count, Console.ReadLine());
                //givenNames = AddToTab(givenNames, "Name");
                //string name = Console.ReadLine();
                //givenNamesList.Add(name);
                //Console.Clear();
            }

            while(true)
            {
                Console.WriteLine("Type a key");
                string key = Console.ReadLine();
                int keyInt = Convert.ToInt32(key);
                string readVaue = null;
                bool isFound = givenNameDictionary.TryGetValue(keyInt, out readVaue);

                if(!isFound)
                {
                    Console.WriteLine("Entry not found");
                }
                else
                {
                    Console.WriteLine(readVaue);
                }

            }
            Console.ReadKey();

            static string[] AddToTab(string[] board, string newElement)
            {
                string[] newTab = new string[board.Length + 1];

                for(int i = 0; i < board.Length; i++)
                {
                    newTab[i] = board[i];
                }

                newTab[newTab.Length - 1] = newElement;
                return newTab;
            }
        }
    }
}
