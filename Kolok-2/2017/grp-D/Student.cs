using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kolok2_2017_grpD
{
    class Student : IComparable<Student>
    {
        private string ime;
        private string prezime;
        private int brojPoena;

        public Student()
        {

        }

        public string Ime { get { return ime; } }
        public string Prezime { get { return prezime; } }
        public int BrojPoena { get { return brojPoena; } }

        public void upisiTxt(StreamWriter sw) {
            sw.WriteLine(ime);
            sw.WriteLine(prezime);
            sw.WriteLine(brojPoena);
        }

        public void citajTxt(StreamReader sr)
        {
            ime = sr.ReadLine();
            prezime = sr.ReadLine();
            brojPoena = int.Parse(sr.ReadLine());
            if (brojPoena < 0) throw new Exception("broj poena je negativan!");
        }

        public int CompareTo(Student other) // alternativno resenje overloadovanje operatora '>' i '<' pa implementacija sort algoritma nekog umesto koriscenje Array.sort
        {
            if (brojPoena > other.brojPoena) return -1; // treba nam opadajuci redosled da bi prva 3 bila sa max poenima
            if (brojPoena < other.brojPoena) return +1;
            return 0;
        }
    }
}
