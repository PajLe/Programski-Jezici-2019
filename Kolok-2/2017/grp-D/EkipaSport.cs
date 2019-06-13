using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2017_grpD
{
    enum SportskaDisciplina
    {
        MuskiFudbal,
        ZenskiFudbal,
        MuskaKosarka,
        ZenskaKosarka,
        Sah
    }

    class EkipaSport : IEkipa, IComparable<EkipaSport>
    {
        private List<Student> studenti;
        private SportskaDisciplina disciplina;

        public EkipaSport() { }

        public int BrojPoenaEkipe { get { return studenti[0].BrojPoena + studenti[1].BrojPoena + studenti[2].BrojPoena; } }
        public SportskaDisciplina Disciplina { get { return disciplina; } }

        public void citajTxt(StreamReader sr)
        {
            studenti = new List<Student>();
            disciplina = (SportskaDisciplina)int.Parse(sr.ReadLine());
            int brojStudenataEkipe = int.Parse(sr.ReadLine());

            for(int i = 0; i < brojStudenataEkipe; i++)
            {
                Student toAdd = new Student();
                toAdd.citajTxt(sr);
                studenti.Add(toAdd);
            }

            studenti.Sort();
        }

        public int CompareTo(EkipaSport other) // pitamo profesora da li je dozvoljeno ovo na kolok. ako nije onda koristimo overloadovanje operatora '<' i '>'
        {
            if (BrojPoenaEkipe > other.BrojPoenaEkipe) return -1; // za opadajuci redosled
            if (BrojPoenaEkipe < other.BrojPoenaEkipe) return +1;
            return 0;
        }

        public void upisiTxt(StreamWriter sw)
        {
            sw.WriteLine((int)disciplina);
            sw.WriteLine(studenti.Count);
            foreach(Student student in studenti)
            {
                student.upisiTxt(sw);
            }
        }
    }
}
