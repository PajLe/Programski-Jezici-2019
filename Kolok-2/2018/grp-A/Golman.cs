using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpA
{
    class Golman : Fudbaler
    {
        private bool dobroBraniPenale;
        private JedinicaMere mera = JedinicaMere.ProcenatOdbrana;

        public Golman()
        {

        }

        public override JedinicaMere Mera
        {
            get { return mera; }
        }

        public bool DobroBraniPenale
        {
            get { return dobroBraniPenale; }
        }

        public override void citajTxt(StreamReader sr)
        {
            base.citajTxt(sr);
            dobroBraniPenale = bool.Parse(sr.ReadLine());
            mera = (JedinicaMere)int.Parse(sr.ReadLine());
        }

        public override void upisiTxt(StreamWriter sw)
        {
            base.upisiTxt(sw);
            sw.WriteLine(dobroBraniPenale);
            sw.WriteLine((int)mera);
        }
    }
}
