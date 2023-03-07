using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_Kontenerosztaly
{
    public class Korhaz
    {
		private string nev;
		private int agyakszama;
		List<Beteg> betegek;

		public Korhaz(string nev, int tarolokapacitas)
		{
			this.Nev = nev;
			this.Agyakszama = tarolokapacitas;
			betegek = new List<Beteg>();
		}

		public int Agyakszama
		{
			get { return agyakszama; }
			set { agyakszama = value; }
		}


		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		// Indexer
		public Beteg this[int i]
		{
			get { return betegek[i];}
		}

		public void addBeteg(Beteg beteg)
		{
			// Leteszteljük, hogy benne van-e már a listában a betegünk
			// Nem akarjuk kétszer felvenni ugyanazt a beteget.
			if (!betegek.Contains(beteg))
			{
				betegek.Add(beteg);
			}
		}

		public void removeBeteg(Beteg beteg)
		{
			if (!betegek.Contains(beteg))
			{
				Console.WriteLine("Nem létezik ilyen beteg!");
			}
			// Megszerezzük az objektumunk indexét, mivel tudjuk, hogy benne van a listában.
			int index = betegek.IndexOf(beteg);
			// Index alapján kitöröljük a listából.
			betegek.RemoveAt(index);
		}

	}
}
