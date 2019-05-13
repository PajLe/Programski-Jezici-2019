using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Automobil : Vozilo
    {
        private StanjeVrata[] vrata;

        public Automobil(StanjeVozila stVoz, int maxBrzina, int trenutnaBrzina , double potrosnja)
        {
            this.stVoz = stVoz;
            this.maxBrzina = maxBrzina;
            this.trenutnaBrzina = trenutnaBrzina;
            this.potrosnja = potrosnja;
            vrata = new StanjeVrata[4];
        }

        public Automobil(Automobil a)
        {
            vrata = new StanjeVrata[4];
            for(int i = 0; i < 4; i++)
            {
                vrata[i] = a.StVrata[i];
            }
            this.stVoz = a.stVoz;
            this.maxBrzina = a.maxBrzina;
            this.trenutnaBrzina = a.trenutnaBrzina;
            this.potrosnja = a.potrosnja;
        }

        public override StanjeVrata[] StVrata {
            get { return vrata; }
            set { this.vrata = value; }
        }

        public void otvoriVrata(int i)
        {
            vrata[i] = StanjeVrata.otvorena;
        }

        public void zatvoriVrata(int kojaVrata)
        {
            vrata[kojaVrata] = StanjeVrata.zatvorena;
        }

        public static Automobil operator ++(Automobil a)
        {
            a.trenutnaBrzina += 10;
            return a;
        }

        public static Automobil operator --(Automobil a)
        {
            a.trenutnaBrzina -= 30;
            return a;
        }
    }
}
