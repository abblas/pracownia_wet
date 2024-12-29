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
        //Statyczny licznik dla numeracji wizyt
        private static int licznik = 0;
        public string id;
        public string typWizyty;
        public DateTime dataWizyty;
        public DateTime godzinaWizyty;
        public Pacjent pacjent;
        public Lekarz lekarz;
        public Klient wlasciciel;
        //Tworzenie konstruktora ze wszystkimi argumentami
        public Wizyta(string id, string typWizyty, DateTime dataWizyty, DateTime godzinaWizyty, Pacjent pacjent, Klient wlasciciel, Lekarz lekarz)
        {
            //Sprawdzanie czy zmienna id jest pusta
            if (string.IsNullOrEmpty(id))
            {
                //Jeśli tak to zmienną licznik zwięszkamy o 1
                licznik++;
                //I przypisujemy wartość zmiennej licznik + aktualny rok (np 1/2024) do zmiennej lokalnej id. 
                this.id = licznik.ToString();
            }
            else
            {
                //W przeciwnym razie przypisz wartość ze zmiennej globalnej
                this.id = id;
            }
            this.typWizyty = typWizyty;
            this.dataWizyty = dataWizyty;
            this.godzinaWizyty = godzinaWizyty;
            this.pacjent = pacjent;
            this.wlasciciel = wlasciciel;
            this.lekarz = lekarz;
        }
        //Tworzenie metody która wygeneruje nowy nr id po dodaniu nowej wizyty
        public static string GenerujNoweId()
        {
            licznik++;
            return licznik.ToString();
        }
    }
}
