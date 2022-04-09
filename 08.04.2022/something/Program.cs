using System;
using System.Collections.Generic;

namespace something
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Human> dictionary = new Dictionary<int, Human>();

            Human human = new Human();
            Human human2 = new Human();

            human.hairColor = "Brown";
            human.age = 1;
            human.eye = "Blue";

            human2.hairColor = "Blue";
            human2.age = 2;
            human2.eye = "Yellow";

            Console.WriteLine("Human1");
            Console.WriteLine(human.hairColor);
            Console.WriteLine(human.eye);
            Console.WriteLine(human.age);

            Console.WriteLine("Human2");
            Console.WriteLine(human2.hairColor);
            Console.WriteLine(human2.eye);
            Console.WriteLine(human2.age);
        }
    }

    class Human
    {
        public string hairColor;
        public int age;
        public string eye;

    }
}
