using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktEsInterface
{
    // Az interfészben definiáljuk, hogy az állatok milyen metódusokkal rendelkezzenek mindenféleképpen.
    // Jelen esetben ez csak a hangot kiad lesz.
    public interface Allat
    {
        void HangotKiad();
    }
}
