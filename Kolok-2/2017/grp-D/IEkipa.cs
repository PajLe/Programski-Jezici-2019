using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2017_grpD
{
    interface IEkipa
    {
        int BrojPoenaEkipe { get; }
        void upisiTxt(StreamWriter sw);
        void citajTxt(StreamReader sr);
    }
}
