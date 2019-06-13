using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpA
{
    class Program
    {
        static void Main(string[] args)
        {
            Selekcija<Napadac> napadaci = new Selekcija<Napadac>();
            Selekcija<Golman> golmani = new Selekcija<Golman>();
            napadaci.citajTxt("napadaci.txt");
            golmani.citajTxt("golmani.txt");

            Selekcija<Napadac> startnaN, rezervnaN;
            napadaci.rasvrstaj(out startnaN, out rezervnaN);

            Selekcija<Golman> startnaG, rezervnaG;
            golmani.rasvrstaj(out startnaG, out rezervnaG);

            startnaN.upisiTxt("startnaN.txt");
            rezervnaN.upisiTxt("rezervnaN.txt");

            startnaG.upisiTxt("startnaG.txt");
            rezervnaG.upisiTxt("rezervnaG.txt");



        }
    }
}
