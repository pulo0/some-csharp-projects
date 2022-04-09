using System;
using System.IO;

namespace _02._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string route = "C:\\Users\\bskrzypek.S309.000\\Desktop\\scripts\\02.04.2022\\test.txt";

            Console.WriteLine("OLD FILE");
            ReadingFromAFile(route);
            RewriteFile(route, "nowy tekst");
            Console.WriteLine("NEW FILE");
            ReadingFromAFile(route);
        }

        static void ReadingFromAFile(string route)
        {
            StreamReader streamReader = new StreamReader(route);
            string lineWrittenFromFile = streamReader.ReadLine();

            int lineNumber = 1;

            while (lineWrittenFromFile != null)
            {
                Console.WriteLine($"Numer linii: {lineNumber} : {lineWrittenFromFile}");
                lineNumber++;
            }
            Console.WriteLine("Naciśnij dowolny klawisz, by zwolnić plik");
            Console.ReadKey();
            streamReader.Dispose();
            Console.WriteLine("Plik zwolniony");
            Console.ReadKey();
        }

        static void RewriteFile(string route, string text)
        {
            StreamWriter streamWriter = new StreamWriter(route, true);
            streamWriter.WriteLine(text);
            streamWriter.Dispose();
        }
    }
}
