using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2017_grpD
{
    enum NaucnaDisciplina
    {
        Matematika,
        Informatika,
        OOP
    }

    class EkipaNauka : IEkipa, IComparable<EkipaNauka>
    {
        private List<Student> studenti;
        private NaucnaDisciplina disciplina;

        public NaucnaDisciplina Disciplina { get { return disciplina; } }
        public int BrojPoenaEkipe { get { return studenti[0].BrojPoena + studenti[1].BrojPoena + studenti[2].BrojPoena; } }
            
        public EkipaNauka(){ }

        public void citajTxt(StreamReader sr)
        {
            studenti = new List<Student>();
            disciplina = (NaucnaDisciplina)int.Parse(sr.ReadLine());
            int brojStudenataEkipe = int.Parse(sr.ReadLine());
            
            for(int i = 0; i < brojStudenataEkipe; i++)
            {
                Student toAdd = new Student();
                toAdd.citajTxt(sr);
                studenti.Add(toAdd);
            }

            studenti.Sort(); // sortiramo po broju poena
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

        public int CompareTo(EkipaNauka other) // pitamo profesora da li je dozvoljeno ovo na kolok. ako nije onda koristimo overloadovanje operatora '<' i '>'
        {
            if (BrojPoenaEkipe > other.BrojPoenaEkipe) return -1; // za opadajuci redosled
            if (BrojPoenaEkipe < other.BrojPoenaEkipe) return +1;
            return 0;
        }
    }
}
