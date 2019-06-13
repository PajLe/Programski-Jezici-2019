using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpC
{
    class Tacka
    {
        private double x;
        private double y;
        private int nadmorskaVisina;
        private string lokacija;

        public Tacka() { }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public int NadmorskaVisina
        {
            get { return nadmorskaVisina; }
            set { nadmorskaVisina = value; }
        }

        public string Lokacija
        {
            get { return lokacija; }
            set { lokacija = value; }
        }

        public static double operator -(Tacka a, Tacka b)
        {
            return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
        }

        public void upisiTxt(StreamWriter sw)
        {
            sw.WriteLine(x);
            sw.WriteLine(y);
            sw.WriteLine(nadmorskaVisina);
            sw.WriteLine(lokacija);
        }

        public void citajTxt(StreamReader sr)
        {
            x = double.Parse(sr.ReadLine());
            y = double.Parse(sr.ReadLine());
            nadmorskaVisina = int.Parse(sr.ReadLine());
            if (nadmorskaVisina < 0) throw new Exception("Nadmorska visina je negativna");
            lokacija = sr.ReadLine();
        }
    }
}
