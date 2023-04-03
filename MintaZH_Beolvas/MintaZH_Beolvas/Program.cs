using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MintaZH_Beolvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("ingatlanok.csv");
            string[] strings = new string[5];
            while (!sr.EndOfStream)
            {
                strings = null;
                string line;
                line = sr.ReadLine();
                strings = line.Split(';');
                if (strings[0] == "I")
                {
                    Ingatlan ingatlan = new Ingatlan();
                    Console.WriteLine("Ingatlan");
                    // Add to container.
                }
                else if (strings[0] == "CS")
                {
                    CsaladiHaz csaladihaz = new CsaladiHaz();
                    Console.WriteLine("Családi ház.");
                    // Add to container.
                }
            }

            Console.ReadKey();
        }
    }
}
