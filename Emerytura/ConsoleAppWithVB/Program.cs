using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleAppWithVB
{
    class Program
    {
        static void Main(string[] args)
        {
            //tu piszemy kod
            //Console.OutputEncoding = Encoding.UTF8

            Interaction.MsgBox("Program emerytura");

            // Console.WriteLine("program EMERYTURA");
            //Console.Write("podaj swoje imie: ");
            string imie;
            //imie = Console.ReadLine().Trim().ToUpper();  //kropka działa jako separator kolejnych kroków
            //imie = imie.Trim();  //przycina spacje przypisuje imie przycięte o spacje imie i zapamietuje teraz przyciete imie
            imie = Interaction.InputBox("podaj imie", "tytuł okienka").Trim().ToUpper();



            //Console.Write("podaj swoje nazwisko: ");
            string nazwisko = Interaction.InputBox("podaj nazwisko", "tytuł okienka").Trim();
            string PierwszaLitera = nazwisko.Substring(0, 1);
            string reszta = nazwisko.Substring(1);
            nazwisko = PierwszaLitera.ToUpper() + reszta.ToLower();

            //Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!");

            //Console.WriteLine("Witaj, {0} {1}", nazwisko, imie); //formatted string
            Console.WriteLine($"Witaj, {imie} {nazwisko}");

            //powyższe to sposoby na sklejanie tekstu. obacnie używamy ostatniej opcji, nie plusami bo spowalniają program
            //Console.Write("Podaj swój wiek: ");
            int wiek; 
            string s = Interaction.InputBox("podaj wiek", "tytuł okienka");
            wiek = int.Parse(s); //funkcja int.parse konwertuje na liczbę ale musimy chceć przekonwertować tekst 50 na liczbę 50

            //Console.WriteLine($"Masz { wiek} lat");

            //jezeli wiek > 67 to jestes emerytem
            //a w przeciwnym przypadku do emerytury zostalo ci 67-wiek lat
            if (wiek >= 67)
            {
                //Console.WriteLine("jestes emerytem");
                Interaction.MsgBox($"masz {wiek} lat.jestes emerytem");
            }
            else
            {
                //Console.WriteLine("do emerytury zostało ci {67 - wiek} lat");
                Interaction.MsgBox($"masz {wiek} lat. do emerytury zostalo ci {67 - wiek} lat");



            }
        }
    }

}
