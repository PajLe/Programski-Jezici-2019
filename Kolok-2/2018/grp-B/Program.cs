using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2018_grpB
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                VozniPark<Automobil> autoPark = new VozniPark<Automobil>();
                VozniPark<Kamion> kamionPark = new VozniPark<Kamion>();

                autoPark.citajTxt("automobili.txt");
                kamionPark.citajTxt("kamioni.txt");

                autoPark.izbaciLosaVozila();
                kamionPark.izbaciLosaVozila();

                autoPark.sortirajVozila();
                kamionPark.sortirajVozila();

                autoPark.upisiTxt("automobili_izlaz.txt");
                kamionPark.upisiTxt("kamioni_izlaz.txt");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /* kamioni.txt
                10 // max broj vozila kamiona
                55.5 // dozvoljena emisija
                3 // broj vozila u ovom fajlu

                15 // karakteristika potrosnja u litrima
                Marconije // naziv kamiona
                1337h4x04 // registracija
                90 // nosivost u tonama

                14 // karakteristika potrosnja u litrima
                Borivoje // naziv kamiona
                333ag2gj // registracija
                50 // nosivost u tonama

                55 // karakteristika potrosnja u litrima
                VoziMisko // naziv kamiona
                444AAA // registracija
                1000 // nosivost u tonama
             */

            /* automobili.txt
                50 // max broj vozila automobila
                100.13 // dozvoljena emisija 
                3 // broj vozila automobila u ovom fajlu

                300 // karakteristika max brzina auta
                BMW // naziv auta
                10ak // registraciaj
                2 // kategorija luksuzni

                100 // karakteristika max brzina auta
                audi // naziv auta
                g2gk // registraciaj
                1 // kategorija porodicni

                1000 // karakteristika max brzina auta
                jugic // naziv auta
                n@jbrz!be // registraciaj
                2 // kategorija luksuzni
             */
        }
    }
}
