using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    public class Wizyta
    {
        private static int licznik = 0; //Statyczny licznik dla numeracji wizyt
        public string id;
        public string typWizyty;
        public DateTime dataWizyty;
        public DateTime godzinaWizyty;
        public Pacjent pacjent;
        public Lekarz lekarz;
        public Klient wlasciciel;
        public Wizyta(string id, string typWizyty, DateTime dataWizyty, DateTime godzinaWizyty, Pacjent pacjent, Klient wlasciciel, Lekarz lekarz)
        {
            if (string.IsNullOrEmpty(id))
            {
                licznik++;
                this.id = licznik + "/" + DateTime.Now.Year;
            }
            else
            {
                this.id = id;
            }
            this.typWizyty = typWizyty;
            this.dataWizyty = dataWizyty;
            this.godzinaWizyty = godzinaWizyty;
            this.pacjent = pacjent;
            this.wlasciciel = wlasciciel;
            this.lekarz = lekarz;
            
        }
        public static string GenerujNoweId()
        {
            licznik++;
            return licznik + "/" + DateTime.Now.Year;
        }
    }
}
