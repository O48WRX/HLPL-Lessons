using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace H1150_Ismetles_Gyakorlas
{
	// Konténer osztály
    public class Korhaz
    {
		private string nev;
		// Konténer listánk
		List<Beteg> Beteglista;

		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		private int maxfo;

		public int Maxfo
		{
			get { return maxfo; }
			set { maxfo = value; }
		}

		public Korhaz(string nev, int maxfo)
		{
			this.Nev = nev;
			this.Maxfo = maxfo;
			Beteglista = new List<Beteg>();
		}

		public Beteg this[int index]
		{
			get { return Beteglista[index]; }
			set { Beteglista[index] = value; }
		}

		public void Hozzaad(Beteg beteg)
		{
			Beteglista.Add(beteg);
		}

		public void Kivesz(Beteg beteg)
		{
			// Ha nincs benne a listában akkor nincs mit kivenni
			// Ekkor kilépünk
			if (!Beteglista.Contains(beteg))
			{
				return;
			}

			int betegindex = Beteglista.IndexOf(beteg);

			Beteglista.RemoveAt(betegindex);

			/*
			 * Úgy is meg lehet oldani, hogy nem indexet keresünk
			 * 
			 * Beteglista.Remove(beteg)
			 * 
			 */
		}
	}
}
