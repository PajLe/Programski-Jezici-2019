using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpC
{
    class Planina
    {
        private List<Putanja> putanjeNaPlanini;
        private string nazivPlanine;
        private string nazivTackePodnozje;
        private string nazivTackeVrh;

        public Planina() { putanjeNaPlanini = new List<Putanja>(); }

        public string NazivPlanine
        {
            get { return nazivPlanine; }
        }

        public string NazivTackePodnozje
        {
            get { return nazivTackePodnozje; }
        }

        public string NazivTackeVrh
        {
            get { return nazivTackeVrh; }
        }

        public void sortirajPutanje()
        {
            foreach(Putanja putanja in putanjeNaPlanini)
            {
                putanja.sortirajPoNadmorskojVisini();
            }
        }

        public void izbaciLosePutanje()
        {
            for(int i = 0; i < putanjeNaPlanini.Count; i++)
            {
                if(!putanjeNaPlanini[i].NazivPutanje.Equals(NazivTackePodnozje + " --> " + NazivTackeVrh))
                {
                    putanjeNaPlanini.RemoveAt(i--);
                }
            }
        }

        public Putanja najkracaPutanja()
        {
            Putanja najkraca = putanjeNaPlanini[0];
            najkraca.sortirajPoNadmorskojVisini();
            double najkraciPut = najkraca.DuzinaPutanje;

            for(int i = 1; i < putanjeNaPlanini.Count; i++)
            {
                putanjeNaPlanini[i].sortirajPoNadmorskojVisini();

                if(putanjeNaPlanini[i].DuzinaPutanje < najkraciPut)
                {
                    najkraciPut = putanjeNaPlanini[i].DuzinaPutanje;
                    najkraca = putanjeNaPlanini[i];
                }
            }

            return najkraca;
        }

        public void upisiTxt(string path)
        {
            using(StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create)))
            {
                sw.WriteLine(nazivPlanine);
                sw.WriteLine(NazivTackePodnozje);
                sw.WriteLine(NazivTackeVrh);
                sw.WriteLine(putanjeNaPlanini.Count); // broj putanja
                foreach(Putanja putanja in putanjeNaPlanini)
                {
                    putanja.upisiTxt(sw);
                }
            }
        }

        public void citajTxt(string path)
        {
            using(StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                nazivPlanine = sr.ReadLine();
                nazivTackePodnozje = sr.ReadLine();
                nazivTackeVrh = sr.ReadLine();
                int brojPutanja = int.Parse(sr.ReadLine());
                for(int i = 0; i < brojPutanja; i++)
                {
                    Putanja toAdd = new Putanja();
                    toAdd.citajTxt(sr);
                    putanjeNaPlanini.Add(toAdd);
                }
            }
        }

    }
}
