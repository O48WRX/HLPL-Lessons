using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Osztalyszintu_Mez_Met
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StopperOra.GetPeldanyokSzama());
            StopperOra ora1 = new StopperOra();
            StopperOra ora2 = new StopperOra();
            StopperOra ora3 = new StopperOra();
            StopperOra ora4 = new StopperOra();

            Console.WriteLine(StopperOra.peldanyokszama);
            Console.ReadKey();
        }
    }
}
