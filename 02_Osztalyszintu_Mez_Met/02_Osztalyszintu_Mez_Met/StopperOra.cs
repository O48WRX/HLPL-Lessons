using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Osztalyszintu_Mez_Met
{
    public class StopperOra
    {
        public static int peldanyokszama = 0;

        public StopperOra()
        {
            StopperOra.peldanyokszama++;
        }

        public static int GetPeldanyokSzama()
        {
            return peldanyokszama;
        }
    }
}
