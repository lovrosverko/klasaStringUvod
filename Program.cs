using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo s klasom String.";

            // Ispis broja znakova u stringu
            Console.WriteLine("Broj znakova u rečenici: {0}",
                recenica.Length);

            // Ispis malim i velikim slovima
            Console.WriteLine("Ispis velikim slovima: {0}, " +
                "\nIspis malim slovima: {1}",
                recenica.ToUpper(), recenica.ToLower());

            // Substring metoda
            Console.WriteLine("\n -- Substring metoda --");
            Console.WriteLine(recenica.Substring(0, 5));
            Console.WriteLine(recenica.Substring(
                recenica.Length-5, 5));

            // Zamjena znakova u stringu
            Console.WriteLine("\n -- Zamjena znakova --");
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));
            

            // Razdvajanje stringa u više stringova
            Console.WriteLine("\n -- Razdvajanje --");
            string[] rijeci = recenica.Split(' ');
            for (int i = 0; i<rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }

            // umetanje znakova u string
            Console.WriteLine("\n -- Umetanje --");
            Console.WriteLine(recenica.IndexOf("radimo"));
            Console.WriteLine(
                recenica.Insert(recenica.IndexOf("radimo"), 
                "intenzivno "));



            Console.ReadKey();
        }
    }
}
