//aplikacja w .net core
// aplikacja dziala w trybie wsadowym, wykorzystuje parametry
//przekazane w linii komend
//przykład użycia : app.exe imie nazwisko wiek




using System;

namespace ConsoleAppCoreWsadowo
{
    class Program
    {
        const int WiekEmerytalny = 67;

        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("za malo parametrow.wymagazne trzy");
                return;
            }

            string imie = args[0];
            string nazwisko = args[1];
            int wiek = int.Parse( args[2]);
            Console.WriteLine($"witaj {imie} {nazwisko} !");

            Console.WriteLine($"masz {wiek} lat");

            if(wiek >= WiekEmerytalny)
            Console.WriteLine("jestes emerytem");
            else
            Console.WriteLine($"do emerytury zostalo ci {WiekEmerytalny - wiek} lat");

                    
        }
    }
}
