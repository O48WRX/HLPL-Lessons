using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1150_Ismetles_Gyakorlas
{
    public class Beteg
    {
		private string nev;

		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		private string betegazonosito;

		public string Betegazonosito
		{
			get { return betegazonosito; }
			set 
			{
				// A bejövő érték hosszának muszáj 10-nek lennie, és nem lehet üres string.
				if (value.Length != 10 || value == String.Empty)
				{
					return;
				}
				betegazonosito = value; 
			}
		}

		private int benttoltottido;

		public int Benttoltottido
		{
			get { return benttoltottido; }
			set 
			{
				// A bent töltött idő nem haladhatja meg a 3-at
				if (value > 3)
				{
					return;
				}
				benttoltottido = value; 
			}
		}

		public Beteg(string nev, string betegazonosito, int benttoltottido)
		{
			this.Nev = nev;
			this.Betegazonosito = betegazonosito;
			this.Benttoltottido = benttoltottido;
		}

        public override string ToString()
        {
			return String.Format("Beteg neve : {0}, beteg azonosítója : {1}, beteg bent töltött ideje {2}", this.Nev, this.Betegazonosito, this.Benttoltottido);
        }

    }
}
