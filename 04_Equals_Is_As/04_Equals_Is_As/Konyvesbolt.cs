using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Equals_Is_As
{
    public class Konyvesbolt
    {
		private string nev;
		private List<Konyv> konyvek;

		public List<Konyv> Konyvek
		{
			get { return konyvek; }
			set { konyvek = value; }
		}


		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		public void HozzaAd(Konyv konyv)
		{
			if (Konyvek.Contains(konyv))
			{
				Console.WriteLine("Már tartalmazza a könyvet!");
				return;
			}
			konyvek.Add(konyv);
		}

		public void Kivesz(Konyv konyv)
		{
			if (konyvek.Count == 0 || !Konyvek.Contains(konyv))
			{
				Console.WriteLine("Nem tartalmaz ilyen könyvet, vagy üres a lista!");
			}
			konyvek.Remove(konyv);
		}

		public List<Konyv> AdottMufajLista(Mufaj mufaj)
		{
			List<Konyv> temp = new List<Konyv>();

			if (konyvek.Count == 0)
			{
				Console.WriteLine("Üres a lista!");
				return temp;
			}

			foreach (var konyv in konyvek)
			{
				if (konyv.Mufaj == mufaj)
				{
					temp.Add(konyv);
				}
			}
			return temp;
		}

		public Konyv this[int index]
		{
			get { return konyvek[index]; }
			set { konyvek[index] = value; }
		}
	}
}
