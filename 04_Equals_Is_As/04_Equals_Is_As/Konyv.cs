using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Equals_Is_As
{
    public class Konyv
    {
		private int id;
		private string cim;
		private string szerzo;
		private Mufaj mufaj;

        #region Properties
        public Mufaj Mufaj
		{
			get { return mufaj; }
			set { mufaj = value; }
		}


		public string Szerzo
		{
			get { return szerzo; }
			set { szerzo = value; }
		}


		public string Cim
		{
			get { return cim; }
			set { cim = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		public Konyv(int id, string cim, string szerzo)
		{
			this.Id = id;
			this.Cim = cim;
			this.Szerzo = szerzo;
			this.mufaj = Mufaj.NemDefinialt;
		}

		public Konyv(int id, string cim, string szerzo, Mufaj mufaj):this(id, cim, szerzo) // Meglévő konstruktor felhasználása
		{
			this.Mufaj = mufaj;
		}

        public override string ToString()
        {
			return String.Format("Azonosító: {0}, Cím: {1}, Szerző: {2}, Múfaj: {3}",this.Id, this.Cim, this.Szerzo, MufajFormatter.Format(this.mufaj));
        }

        public override bool Equals(object obj)
        {
			if (obj == null) return false;
			if (obj == this) return true;
			if (!(obj is Konyv)) return false;

			Konyv temp = obj as Konyv;

            return this.Id == temp.Id && this.Szerzo == temp.Szerzo && this.Cim == temp.Cim;
        }

    }
}
