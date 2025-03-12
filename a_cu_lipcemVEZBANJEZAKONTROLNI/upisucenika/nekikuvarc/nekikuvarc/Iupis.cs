using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nekikuvarc
{
    interface Iupis
    {
        double Granica { get; set; }
        int Upis(double pr);
    }
}
