using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1340_OroklodesGyakorlas
{
	// Gyermekosztály
    public class Kacsa : Allat
    {
		private string szin; // Exkluzív mező

		public string Szin
		{
			get { return szin; }
			set { szin = value; }
		}

		public Kacsa(string nev, int allatid, string szin) 
			: base(nev, allatid) // Szülő osztály konstruktora kezeli az örökölt mezőket.
		{
			this.Szin = szin;
		}

		// Az osztály exkluzív metódusa.
		public void Repul()
		{
			Console.WriteLine("{0} nevű kacsa repül", this.Nev);
		}

        public override string ToString()
        {
			return String.Format("{0} nevű, {1} azonosítójú, {2} színű kacsa");
        }

    }
}
