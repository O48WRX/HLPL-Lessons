using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1340_OroklodesGyakorlas
{
	// Gyermekosztály
    public class Koala : Allat
    {
		private string vedettsegiszint; // Ez a mező exkluzív erre az osztályra és külön kezeli

		public string Vedettsegiszint
		{
			get { return vedettsegiszint; }
			set { vedettsegiszint = value; }
		}

		public Koala(string nev, int allatid, string vedettsegiszint) 
			: base(nev, allatid) // A szülőosztály konstruktorát meghívjuk, hogy lekezelje az örökölt mezőket.
		{
			this.Vedettsegiszint = vedettsegiszint;
		}

		// Exkluzív metódus.
		public void FelmaszikAFara()
		{
			Console.WriteLine("{0} nevű koala felmászik a fára", this.Nev);
		}

        public override string ToString()
        {
            return String.Format("{0} nev, {1} allat id, {2} vedettsegi szint", this.Nev, this.Allatid, this.Vedettsegiszint);
        }
    }
}
