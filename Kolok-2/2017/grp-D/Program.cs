using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolok2_2017_grpD
{
    class Program
    {
        /*      
         *      fajl nauka.txt
         *      
                2 // naucne ekipe unutar fakulteta

                //1. naucna ekipa

                0 // naucna disciplina Matematika
                4 // broj studenata u ekipi

                Joca // ime 1. studenta
                Ducic // prezime 1. studenta
                30 // broj poena 1. studenta

                Ivo // ime 2 .
                Andric // prezime 2.
                90 // br poena 2.

                Paja // 3.
                Car // 3.
                100 // 3.

                Lego // 4.
                Kockica // 4.
                12 // 4.

                //2. naucna ekipa

                2 // naucna disciplina OOP
                4 // broj studenata u ekipi

                Maja // ime 1. studenta
                Gojkovic // prezime 1. studenta
                22 // broj poena 1. studenta

                Vladislav // ime 2 .
                Petkovic Dis // prezime 2.
                1 // br poena 2.

                Goran // 3.
                Bregovic // 3.
                55 // 3.

                Moj // 4.
                Novcanik // 4.
                9 // 4.
        */


        /*
            fajl sport.txt
            4 // sportske ekipe unutar fakulteta

            //1. sportska ekipa

            0 // sportska disciplina MuskiFudbal
            2 // broj studenata u ekipi

            Radoje // ime 1. studenta
            Domanovic // prezime 1. studenta
            4 // broj poena 1. studenta

            Ivo // ime 2 .
            Si // prezime 2.
            90 // br poena 2.

            Saj // 3.
            Radoje // 3.
            1 // 3.

            Doske // 4.
            Obradovic // 4.
            101 // 4.

            //2. sportska ekipa

            3 // sportska disciplina Zenska kosarka
            3 // broj studenata u ekipi

            Maja // ime 1. studenta
            Gojkovic // prezime 1. studenta
            62 // broj poena 1. studenta

            Nada // ime 2 .
            Macura // prezime 2.
            999 // br poena 2.

            Hikamica // 3.
            Bebica // 3.
            100 // 3.

            //3. sportska ekipa
            4 // sportska disciplina Sah
            3 // broj studenata u ekipi
            Vuk
            Djordjevic
            103
            Laza
            Djordjevic
            99
            Em
            Ehh
            900

            //4. sportska ekipa
            2 // muska kosarka
            3 // broj studenata
            Aga
            Beciraga
            85
            Atila
            Bicboziji
            43
            Svetozar
            Mare
            19
         */
        static void Main(string[] args)
        {
            try
            {
                Fakultet elfak = new Fakultet("Elektronski Fakultet");
                elfak.citajTxt("nauka.txt", "sport.txt");

                Console.WriteLine(elfak.UkupanBrojPoenaSvihEkipa);
                elfak.sortirajKolekcije();

                elfak.upisiTxt("nauka_sortirano.txt", "sport_sortirano.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
