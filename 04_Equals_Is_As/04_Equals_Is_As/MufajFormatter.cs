using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Equals_Is_As
{
    public static class MufajFormatter
    {
        public static string Format(Mufaj mufaj)
        {
            switch (mufaj)
            {
                case Mufaj.NemDefinialt:
                    return "Nem definiált";
                case Mufaj.Scifi:
                    return "Sci-fi";
                case Mufaj.Fantasy:
                    return "Fantasy";
                case Mufaj.Drama:
                    return "Dráma";
                case Mufaj.Horror:
                    return "Horror";
                default:
                    return "Nem definiált";
            }
        }
    }
}
