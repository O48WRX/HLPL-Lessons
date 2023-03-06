using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Oroklodes
{
    public class Allat
    {
		private string nev;
		private int allatID;

		// Protected védettségi szint
		// Így csak ez az osztály és a leszármazotti kapcsolatban lévő osztályok fognak tudni hozzáférni ehhez a propertyhez.
		protected int AllatID
		{
			get { return allatID; }
			set { allatID = value; }
		}



		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		public void HangotKiad()
		{
			Console.WriteLine("Az állat kiad hangot!");
		}


		public Allat(string nev, int allatID)
		{
			this.Nev = nev;
			this.AllatID = allatID;
		}
	}
}
