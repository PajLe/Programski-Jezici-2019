using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2017_grpD
{
    class Fakultet
    {
        private List<EkipaNauka> naucneEkipe;
        private List<EkipaSport> sporskeEkipe;
        private string naziv;

        public Fakultet(string naziv) {
            this.naziv = naziv;
            naucneEkipe = new List<EkipaNauka>();
            sporskeEkipe = new List<EkipaSport>();
        }

        public int UkupanBrojPoenaSvihEkipa
        {
            get
            {
                int ukupanBroj = 0;
                foreach(EkipaNauka ekipa in naucneEkipe) ukupanBroj += ekipa.BrojPoenaEkipe;
                foreach (EkipaSport ekipa in sporskeEkipe) ukupanBroj += ekipa.BrojPoenaEkipe;
                return ukupanBroj;
            }
        }

        public string Naziv { get { return naziv; } }

        public void upisiTxt(string path1, string path2)
        {
            using(StreamWriter sw = new StreamWriter(new FileStream(path1, FileMode.Create)))
            {
                sw.WriteLine(naucneEkipe.Count); // upisuje broj ekipa u kolekciji naucnih ekipa radi lakseg citanja kasnije
                foreach(EkipaNauka ekipa in naucneEkipe) ekipa.upisiTxt(sw);
            }
            using (StreamWriter sw = new StreamWriter(new FileStream(path2, FileMode.Create)))
            {
                sw.WriteLine(sporskeEkipe.Count); // upisuje broj ekipa u kolekciji sportskih ekipa
                foreach (EkipaSport ekipa in sporskeEkipe) ekipa.upisiTxt(sw);
            }
        }

        public void citajTxt(string path1, string path2)
        {
            using(StreamReader sr = new StreamReader(new FileStream(path1, FileMode.Open)))
            {
                int brojNaucnihEkipa = int.Parse(sr.ReadLine());
                for(int i = 0; i < brojNaucnihEkipa; i++)
                {
                    EkipaNauka toAdd = new EkipaNauka();
                    toAdd.citajTxt(sr);
                    naucneEkipe.Add(toAdd);
                }
            }

            using (StreamReader sr = new StreamReader(new FileStream(path2, FileMode.Open)))
            {
                int brojSportskihEkipa = int.Parse(sr.ReadLine());
                for (int i = 0; i < brojSportskihEkipa; i++)
                {
                    EkipaSport toAdd = new EkipaSport();
                    toAdd.citajTxt(sr);
                    sporskeEkipe.Add(toAdd);
                }
            }
        }

        public void sortirajKolekcije()
        {
            sporskeEkipe.Sort();
            naucneEkipe.Sort();
        }

    }
}
