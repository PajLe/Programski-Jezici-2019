using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpB
{

    enum Kategorija
    {
        MaliGradski,
        Porodicni,
        Luksuzni
    }

    class Automobil : Vozilo
    {
        private Kategorija kategorija;

        public Automobil() { }

        public Kategorija Kategorija
        {
            get { return kategorija; }
        }

        public override JedinicaMere Mera
        {
            get { return JedinicaMere.KilometarNaCas; }
        }

        public override bool boljiOd(Vozilo drugo)
        {
            return this.Karakteristika > drugo.Karakteristika;
        }

        public override void citajTxt(StreamReader sr)
        {
            base.citajTxt(sr);
            kategorija = (Kategorija)int.Parse(sr.ReadLine());
        }

        public override void upisiTxt(StreamWriter sw)
        {
            base.upisiTxt(sw);
            sw.WriteLine(kategorija);
        }
    }
}
