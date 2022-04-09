using System;
using System.IO;

namespace Zadanie_02._04._2022
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileRoute = "";

            if(!File.Exists(fileRoute))
            {
                CreateFile(fileRoute);
            }
            else
            {
                PuttingTheData(fileRoute);
            }
            
        }

        static void CreateFile(string route)
        {
            File.Create(route);
        }

        static void PuttingTheData(string route)
        {
            Console.WriteLine("Podaj imie");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj numer telefonu");
            string phoneNumber = Console.ReadLine();
            int convertToInt = Convert.ToInt32(phoneNumber);

            int index = 0;
            using (StreamReader streamReader = new StreamReader(route))
            {
                string actualLine = streamReader.ReadLine();
                while (actualLine != null)
                {
                    index++;
                    actualLine = streamReader.ReadLine();
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(route, true))
            {
                streamWriter.WriteLine($"{index}. {name} {surname} {convertToInt}");
            }
        }
    }
}
