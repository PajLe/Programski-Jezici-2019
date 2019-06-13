using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kolok2_2018_grpA
{
    public enum JedinicaMere
    {
        BrojGolova,
        ProcenatOdbrana
    }

    public abstract class Fudbaler
    {
        private int ucinak;
        private string ime;
        private string prezime;

        public int Ucinak {
            get { return ucinak; }
            set { ucinak = value; }
        }

        public abstract JedinicaMere Mera { get; }
        
        public string Ime
        {
            get { return ime; }
        }

        public string Prezime
        {
            get { return prezime; }
        }

        public virtual void upisiTxt(StreamWriter sw)
        {
            sw.WriteLine(ucinak);
            sw.WriteLine(ime);
            sw.WriteLine(prezime);
        }

        public virtual void citajTxt(StreamReader sr)
        {
            ucinak = int.Parse(sr.ReadLine());
            ime = sr.ReadLine();
            prezime = sr.ReadLine();
        }

        public double relativniUcinak(int norma)
        {
            return ucinak * 1.0 / norma;
        }
    }
}
