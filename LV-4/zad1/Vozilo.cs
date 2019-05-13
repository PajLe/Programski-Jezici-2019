using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum StanjeVozila
    {
        ukljuceno,
        iskljuceno
    }
    
    enum StanjeVrata
    {
        otvorena,
        zatvorena
    }

    abstract class Vozilo
    {
        protected StanjeVozila stVoz;
        protected int maxBrzina;
        protected int trenutnaBrzina;
        protected double potrosnja; // litar/100km

        public StanjeVozila StVoz
        {
            get { return stVoz; }
            set { stVoz = value; }
        }

        public abstract StanjeVrata[] StVrata
        {
            get;
            set;
        }
    }
}
