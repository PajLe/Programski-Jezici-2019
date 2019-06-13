using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpA
{
    class Napadac : Fudbaler
    {
        private int brojMinuta;
        private JedinicaMere mera = JedinicaMere.BrojGolova;
        
        public Napadac()
        {

        }

        public override JedinicaMere Mera
        {
            get { return mera; }
        }

        public int BrojMinuta
        {
            get { return brojMinuta; }
        }

        public override void upisiTxt(StreamWriter sw)
        {
            base.upisiTxt(sw);
            sw.WriteLine(brojMinuta);
            sw.WriteLine((int)mera);
        }

        public override void citajTxt(StreamReader sr)
        {
            base.citajTxt(sr);
            brojMinuta = int.Parse(sr.ReadLine());
            mera = (JedinicaMere) int.Parse(sr.ReadLine());
        }
    }
}
