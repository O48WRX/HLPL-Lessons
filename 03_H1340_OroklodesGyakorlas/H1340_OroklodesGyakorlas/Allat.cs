using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1340_OroklodesGyakorlas
{
	// Szülőosztály
	// A metódusai és mezői mind elérhetőek lesznek a gyermekosztályokban
	// A protected védelmi szintű dolgokat pedig csak ezen az osztályon belül és a leszármazottaiban érjük el, azon kívül nem.
    public class Allat
    {
		private string nev;
		private int allatid;

		// protected
		// Így nem érjük el az osztályon és a gyermekosztályain kívül.
		protected int Allatid
		{
			get { return allatid; }
			set { allatid = value; }
		}

		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		public Allat(string nev, int allatid)
		{
			this.Nev = nev;
			this.Allatid = allatid;
		}

		public void HangotKiad()
		{
			Console.WriteLine("{0} nevű állat hangot ad ki!", this.Nev);
		}

        public override string ToString()
        {
			return String.Format("Állat neve {0}, állat id-je {1}", this.Nev, this.Allatid);
        }

    }
}
