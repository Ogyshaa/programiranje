using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isplata_zarada
{
    interface IBank
    {
        int Stanje { get; set; }

        void Uplata(int iznos, string racun);

        int Isplata(int iznos, string racun);
    }
}
