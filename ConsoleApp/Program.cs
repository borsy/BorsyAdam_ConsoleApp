using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program
    {

        static List<Dolgozo> dolgozok = new List<Dolgozo>();

        static void Main(string[] args)
        {
            beolvasas();
            feladat01();
            feladat02();
            feladat03();

            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladat03() //-- hányan dolgoznak az egyes részlegeken
        {
            
        }

        private static void feladat02() //-- a legmagasabb keresetű dolgozó nevét
        {
            Console.WriteLine("2. feladat:");
            Dolgozo max = dolgozok.Find(a => a.ber == dolgozok.Max(b => b.ber));
            Console.WriteLine($"\t{max.nev} fizetése: {max.ber} Ft");
        }

        private static void feladat01() //-- az össz dolgozók száma
        {
            Console.WriteLine("1. feladat:");
            Console.WriteLine($"\tA dolgozók száma: {dolgozok.Count} fő");
        }

        private static void beolvasas()
        {
            using (StreamReader olvaso = new StreamReader("dolgozok.csv"))
            {
                olvaso.ReadLine(); // --fejléc kihagyása, nem kell
                while (!olvaso.EndOfStream)
                {
                    string[] sor = olvaso.ReadLine().Replace('"', ' ').Split(',');
                    Dolgozo dolgozo = new Dolgozo(sor[0].Trim(), sor[1].Trim(), sor[2].Trim(), int.Parse(sor[3].Trim()), int.Parse(sor[4].Trim()));
                    dolgozok.Add(dolgozo);
                }
            }
        }
    }
}
