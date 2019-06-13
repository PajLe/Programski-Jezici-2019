using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpC
{
    interface IPutanja
    {
        double DuzinaPutanje
        {
            get;
        }

        void sortirajPoNadmorskojVisini(); // ascending
        void upisiTxt(StreamWriter sw);
        void citajTxt(StreamReader sr);
    }
}
