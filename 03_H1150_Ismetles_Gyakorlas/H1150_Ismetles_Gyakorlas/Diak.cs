using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1150_Ismetles_Gyakorlas
{
    public class Diak
    {
		// Mezők és propertyk
		private string nev;
		private string neptunkod;
		private int aktualisfelev;

		public int Aktualisfelev
		{
			get { return aktualisfelev; }
			set 
			{
				// Nincs nulladik félév
				// Ezért azt lekezeljük, hogy olyan nem lehet.
				if (value < 1)
				{
					return;
				}
				aktualisfelev = value; 
			}
		}


		public string Neptunkod
		{
			get { return neptunkod; }
			set { neptunkod = value; }
		}


		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		// Metódusok

		public void aktualisFelevNovel()
		{
			this.Aktualisfelev++;
		}

		// Konstruktor

		public Diak()
		{

		}

		public Diak(string nev, string neptunkod, int aktualisfelev)
		{
			this.Nev = nev;
			this.Neptunkod = neptunkod;
			this.Aktualisfelev = aktualisfelev;
		}

		// Override metódusok

        public override string ToString()
        {
			return string.Format("Diak neve : {0}, Diak neptunkodja: {1}, Diak aktuális féléve: {2}", this.Nev, this.Neptunkod, this.Aktualisfelev);
        }

    }
}
