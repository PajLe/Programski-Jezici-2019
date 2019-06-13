using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpC
{
    class Putanja : IPutanja
    {
        private List<Tacka> putanja;

        public Putanja() { putanja = new List<Tacka>(); }

        public double DuzinaPutanje
        {
            get
            {
                double duzina = 0.0;
                for (int i = 0; i < putanja.Count - 1; i++)
                {
                    duzina += putanja[i] - putanja[i + 1];
                }
                return duzina;
            }
        }

        public string NazivPutanje
        {
            get
            {
                return putanja[0].Lokacija + " --> " + putanja[putanja.Count - 1].Lokacija;
            }
        }

        public void citajTxt(StreamReader sr)
        {
            int brojTacakaNaPutanji = int.Parse(sr.ReadLine());
            for(int i = 0; i < brojTacakaNaPutanji; i++)
            {
                Tacka toAdd = new Tacka();
                toAdd.citajTxt(sr);
                putanja.Add(toAdd);
            }
        }

        public void sortirajPoNadmorskojVisini() // insertion, dobar za mali broj elemenata
        {
            for(int i = 1; i < putanja.Count; i++)
            {
                int j;
                Putanja temp = putanja[i];
                for(j = i; j > 0 && temp.NadmorskaVisina < putanja[j - 1].NadmorskaVisina; j--)
                {
                    putanja[j] = putanja[j - 1];
                }
                putanja[j] = temp;
            }
        }

        public void upisiTxt(StreamWriter sw)
        {
            sw.WriteLine(putanja.Count);
            foreach(Tacka tacka in putanja)
            {
                tacka.upisiTxt(sw);
            }
        }
    }
}
