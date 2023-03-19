using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1340_OroklodesGyakorlas
{
    public class Allatkert
    {
		private string nev;
		private int befogadokepesseg;
		private int aktualisallatok;
		List<Allat> allatok; // Konténer lista

		public Allatkert(string nev, int befogadokepesseg, int aktualisallatok)
		{
			this.Nev = nev;
			this.Befogadokepesseg = befogadokepesseg;
			this.Aktualisallatok = aktualisallatok;
			allatok = new List<Allat>(); // Konstruktorban példányosítjuk a listát.
		}

		public void HozzaAd(Allat allat)
		{
			// Ha már benne van az állat akkor
			// Nem kell hozzáadni
			if (allatok.Contains(allat))
			{
				return;
			}
			// Ha a hozzáadandó allat nem null, és az aktuális állatok száma nem egyenlő a befogadó képességgel
			// Csak akkor adjuk hozzá.
			if (allat != null && aktualisallatok <= befogadokepesseg)
			{
				allatok.Add(allat);
				Aktualisallatok++; // Inkrementáljuk az állatok számát egyel.
			}
		}

		public void Kivesz(Allat allat)
		{
			// Ha nincs benne az állat az osztályban vagy az aktuális állatok száma nulla akkor
			// Nem tudunk kivenni semmit a listából.
			if (!(allatok.Contains(allat)) || aktualisallatok == 0)
			{
				return;
			}
			allatok.Remove(allat); 
			Aktualisallatok--; // Dekrementálunk 1-el, mert kivettünk.
		}

		public int Aktualisallatok
		{
			get { return aktualisallatok; }
			set { aktualisallatok = value; }
		}



		public int Befogadokepesseg
		{
			get { return befogadokepesseg; }
			set { befogadokepesseg = value; }
		}


		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}


		// Indexer
		public Allat this[int i]
		{
			get { return allatok[i]; }
			set { allatok[i] = value; }
		}
	}
}
