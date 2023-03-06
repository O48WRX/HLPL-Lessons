using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koala koala1 = new Koala("Ted", 1, "Fokozottan Védett");
            koala1.HangotKiad();
            koala1.felmaszikAFara();

            Console.ReadKey();
        }
    }
}
