using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpB
{
    enum JedinicaMere
    {
        KilometarNaCas,
        LitarPoKilometru
    }

    abstract class Vozilo
    {
        private int karakteristika;
        private string naziv;
        private string registarskaOznaka;

        public abstract JedinicaMere Mera { get; }

        public int Karakteristika
        {
            get { return karakteristika; }
            set { karakteristika = value; }
        }

        public string Naziv
        {
            get { return naziv; }
        }

        public string RegistarskaOznaka
        {
            get { return registarskaOznaka; }
        }

        public virtual void upisiTxt(StreamWriter sw)
        {
            sw.WriteLine(karakteristika);
            sw.WriteLine(naziv);
            sw.WriteLine(registarskaOznaka);
        }

        public virtual void citajTxt(StreamReader sr)
        {
            karakteristika = int.Parse(sr.ReadLine());
            naziv = sr.ReadLine();
            registarskaOznaka = sr.ReadLine();
        }

        public abstract bool boljiOd(Vozilo drugo);

        public double RezultatTestaEmisije
        {
            get
            {
                Random r = new Random();
                return r.NextDouble() * 200;
            }
        }
    }
}
