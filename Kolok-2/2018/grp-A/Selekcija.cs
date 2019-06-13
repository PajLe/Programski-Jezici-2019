using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kolok2_2018_grpA
{
    class Selekcija <T> where T : Fudbaler, new()
    {
        private List<T> fudbaleri;
        private int maxBrojFudbalera;
        private int norma;

        public Selekcija()
        {
            fudbaleri = new List<T>();
            maxBrojFudbalera = 11;
            norma = 0;
        }

        public int Norma
        {
            get { return norma; }
            set { norma = value; }
        }

        public void dodajFudbalera(T f)
        {
            if (fudbaleri.Count == maxBrojFudbalera) throw new Exception("selekcija je puna!");
            fudbaleri.Add(f);
        }

        public void upisiTxt(string path)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(maxBrojFudbalera);
                sw.WriteLine(norma);
                sw.WriteLine(fudbaleri.Count);
                foreach(T fudbaler in fudbaleri)
                {
                    fudbaler.upisiTxt(sw);
                }
            }
        }

        public void citajTxt(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                maxBrojFudbalera = int.Parse(sr.ReadLine());
                norma = int.Parse(sr.ReadLine());
                int brojFudbaleraUFajlu = int.Parse(sr.ReadLine());
                for(int i = 0; i < brojFudbaleraUFajlu; i++)
                {
                    T a = new T();
                    a.citajTxt(sr);
                    fudbaleri.Add(a);
                }
            }
        }

        public void rasvrstaj(out Selekcija<T> startna, out Selekcija<T> rezervna)
        {
            startna = new Selekcija<T>();
            rezervna = new Selekcija<T>();
            startna.Norma = this.norma;
            rezervna.Norma = this.norma;
            foreach (T fudbaler in fudbaleri)
            {
                double ru = fudbaler.relativniUcinak(norma);
                if (ru >= 0.8) startna.dodajFudbalera(fudbaler);
                else if (ru > 0.2) rezervna.dodajFudbalera(fudbaler);
                else throw new Exception("greska pri kreiranju selekcije");
            }
        }
    }
}
