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

            Console.WriteLine("Program vége!");
            Console.ReadLine();
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
