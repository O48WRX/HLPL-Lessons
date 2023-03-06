﻿using System;
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

		public int AllatID
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
