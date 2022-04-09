using System;

namespace kurs_programowania_26._03._22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Loops();

            string text = "asdfg";

            for(int i = 0; i < text.Length; i++)
            {
                char znak = text[i];
                if(znak == 'a')
                {
                    //Interpolation
                    Console.WriteLine($"Znak nr {i} to {text[i]}");
                }
                
            }

            Console.WriteLine("Wycięcie trzech znaków od indeksu 1: " + text.Substring(1, 3));

            string text0 = "    xxx    ";
            Console.WriteLine("Tekst otrzymany od użytkownika: ");
            Console.WriteLine(text0);
            Console.WriteLine("Tekst przycięty: ");
            Console.WriteLine(text0.Trim());

            Console.WriteLine("Zmiana znaków");
            Console.WriteLine(text0);
            Console.WriteLine(text0.Replace("x", "y"));


            int? nullableNumber = null;
            int number = 10;
            Console.WriteLine($"Liczba null: {nullableNumber} a normalna liczba {number}");
            
        }

        static void Loops()
        {
            //Loops
            /*
            int counter = 0;
            while (counter < 3)
            {
                FunctionName();
                counter++;
            }

            do
            {
                FunctionName();
            } while (false);
            */

            int[] tablicaWieku = new int[4];
            for (int i = 0; i < tablicaWieku.Length; i++)
            {
                int returnedAge = FunctionName();
                tablicaWieku[i] = returnedAge;
            }

            Console.WriteLine("Wartość indeksu: " + tablicaWieku[0]);
            Console.WriteLine("Wartość indeksu 1: " + tablicaWieku[1]);
            Console.WriteLine("Wartość indeksu 2: " + tablicaWieku[2]);
            Console.WriteLine("Wartość indeksu 3: " + tablicaWieku[3]);
            Console.WriteLine("KONIEC");
        }

        static int FunctionName()
        {
            //comment
            /*
            uwu
             
             */

            //Name stuff
            string text = "Podaj swoje imię:";
            Console.WriteLine(text);
            string name = Console.ReadLine();
            Console.WriteLine("Imię: " + name);

            //Age stuff
            Console.WriteLine("Podaj swój wiek:");
            string age = Console.ReadLine();
            int x = 10;
            int ageToNumber = Convert.ToInt32(age);
            try
            {
                Console.Write("Twój wiek + 10 to: " + (ageToNumber + x));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Nie podałeś liczby");
            }
        
            //If statement with age
            Console.WriteLine("\nCzy twój wiek jest wyższy od 20? ");
            if (ageToNumber > 20)
            {
                Console.WriteLine("Tak!");
            }
            else if (ageToNumber == 20)
            {
                Console.WriteLine("Równe 20");

            }
            else
            {
                Console.WriteLine("Nie-e");
            }
            Console.Clear();
            return ageToNumber;

        }
    }
}
