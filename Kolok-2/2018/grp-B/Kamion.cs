using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpB
{
    class Kamion : Vozilo
    {
        private int nosivost; // u tonama

        public Kamion() { }

        public int Nosivost
        {
            get { return nosivost; }
        }

        public override JedinicaMere Mera
        {
            get
            {
                return JedinicaMere.LitarPoKilometru;
            }
        }

        public override bool boljiOd(Vozilo drugo)
        {
            return this.Karakteristika < drugo.Karakteristika;
        }

        public override void citajTxt(StreamReader sr)
        {
            base.citajTxt(sr);
            nosivost = int.Parse(sr.ReadLine());
        }

        public override void upisiTxt(StreamWriter sw)
        {
            base.upisiTxt(sw);
            sw.WriteLine(nosivost);
        }
    }
}
