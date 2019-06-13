using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpB
{
    class VozniPark<T> where T : Vozilo, new()
    {
        private List<T> vozila;
        private int maxBrojVozila;
        private double dozvoljenaEmisija;

        public VozniPark()
        {
            vozila = new List<T>();
            maxBrojVozila = 0;
        }

        public double DozvoljenaEmisija
        {
            get { return dozvoljenaEmisija; }
            set { dozvoljenaEmisija = value; }
        }

        public void dodajVozilo(T vozilo)
        {
            if (vozila.Count == maxBrojVozila) throw new Exception("Park je popunjen");
            vozila.Add(vozilo);
        }

        public void upisiTxt(string path)
        {
            using(StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.WriteLine(maxBrojVozila);
                sw.WriteLine(dozvoljenaEmisija);
                sw.WriteLine(vozila.Count); // trenutni broj vozila u parku
                foreach(T vozilo in vozila)
                {
                    vozilo.upisiTxt(sw);
                }
            }
        }

        public void citajTxt(string path)
        {
            using(StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                maxBrojVozila = int.Parse(sr.ReadLine());
                dozvoljenaEmisija = double.Parse(sr.ReadLine());
                int brojVozila = int.Parse(sr.ReadLine());
                for(int i = 0; i < brojVozila; i++)
                {
                    T vozilo = new T();
                    vozilo.citajTxt(sr);
                    vozila.Add(vozilo);
                }
            }
        }

        public void izbaciLosaVozila()
        {
            for(int i = 0; i < vozila.Count; i++)
            {
                if(vozila[i].RezultatTestaEmisije > DozvoljenaEmisija)
                {
                    vozila.RemoveAt(i--);
                }
            }
        }

        public void sortirajVozila()
        {
            for(int i = 1; i < vozila.Count; i++)
            {
                int j;
                T temp = vozila[i];
                for(j = i; j > 0 && temp.boljiOd(vozila[j - 1]); j--)
                {
                    vozila[j] = vozila[j - 1];
                }
                vozila[j] = temp;

            }
        }

    }
}
