using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
	public class Pacjent
	{
        private static int licznik = 0;
        public string id;
        public string imie;
		public string gatunek;
		public string rasa;
        public string plec;
        public string wiek;
        public DateTime dataUrodzenia;
        public string waga;
		public Klient wlasciciel;

		public Pacjent(string imie)
		{
			this.imie = imie;
		}
        //Nadpisywanie metody ToString() w klasie Pacjent, aby zwracała imię pacjenta
        public override string ToString()
        {
            return imie;
        }

        public Pacjent(string id, string imie, string gatunek, string rasa, string plec, DateTime dataUrodzenia, string waga, Klient wlasciciel)
        {
            if (string.IsNullOrEmpty(id))
            {
                licznik++;
                this.id = licznik.ToString();
            }
            else
            {
                this.id = id;
            }
            this.imie = imie;
            this.gatunek = gatunek;
            this.rasa = rasa;
            this.plec = plec;
            this.dataUrodzenia = dataUrodzenia;
            this.waga = waga;
            this.wlasciciel = wlasciciel;
            // this.wiek = wiek;
        }
        public Pacjent(string id, string imie, Klient wlasciciel)
        {
            this.id = id;
            this.imie = imie;
            this.wlasciciel = wlasciciel;
        }
        public static string GenerujNoweId()
        {
            licznik++;
            return licznik.ToString();
        }
    }
}
