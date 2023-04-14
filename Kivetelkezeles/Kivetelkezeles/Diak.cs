using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelkezeles
{
    public class Diak
    {
		private string nev;
		private string neptunkod;
		private int kor;

		public Diak(string nev, string neptunkod, int kor)
		{
			this.Nev = nev;
			this.Neptunkod= neptunkod;
			this.Kor= kor;
		}

		public int Kor
		{
			get { return kor; }
			// Egyszerű példa a kivételkezelésre.
			set 
			{
				try // Az az ág, amiben dobodni fog az kivétel.
				{
                    if (value <= 0 || value > 150)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    kor = value;
                }
				catch (ArgumentOutOfRangeException e) // Elkapjuk a kialakult ArgumentOutOfRangeException() kivételt.
				{
					Console.WriteLine("Kivétel: Helytelen kor."); // Csak szemléltetésképp.
					// Itt megoldjuk a kivétel problémáját amennyiben megoldható.
					return;
				}
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

        public override string ToString()
        {
            return String.Format("Név: {0}, Neptunkód: {1}, Kor: {2}",this.Nev, this.Neptunkod, this.Kor);
        }

    }
}
