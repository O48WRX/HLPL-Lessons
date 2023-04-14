using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diak diak1 = new Diak("Teszt Péter", "kp67tru", 20);
            Console.WriteLine(diak1);

            Diak diak2 = new Diak("Teszt Mónika", "lptkrt", -1); // 0 lesz a kor, mivel kivételdobódik és nem történik értékátadás és ezért alapértelmezett 0 lesz.
            Console.WriteLine(diak2);

            Console.ReadKey();
        }
    }
}
