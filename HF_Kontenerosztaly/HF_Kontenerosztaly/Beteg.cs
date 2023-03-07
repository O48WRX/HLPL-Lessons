using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_Kontenerosztaly
{
    public class Beteg
    {
		private string nev;
		private DateTime szuldatum;
		private string betegazonosito;

		public Beteg(string nev, DateTime szuldatum, string betegazonosito)
		{
			this.Nev = nev;
			this.Szuldatum = szuldatum;
			this.Betegazonosító = betegazonosito;
		}

		public string Betegazonosító
		{
			get { return betegazonosito; }
			set { betegazonosito = value; }
		}


		public DateTime Szuldatum
		{
			get { return szuldatum; }
			set { szuldatum = value; }
		}


		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

        public override string ToString()
        {
			return String.Format("Nev = {0}, Születési dátum = {1}, betegazonosító = {2}",this.Nev, this.Szuldatum, this.Betegazonosító);
        }
    }
}
