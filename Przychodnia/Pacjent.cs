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
        //Tworzenie konstruktora z jednym argumentem
		public Pacjent(string imie)
		{
			this.imie = imie;
		}
        //Tworzenie konstruktora z kilkoma argumentami
        public Pacjent(string id, string imie, string gatunek, string rasa, string plec, DateTime dataUrodzenia, string waga, Klient wlasciciel)
        {
            //Sprawdzanie czy zmienna id jest pusta
            if (string.IsNullOrEmpty(id))
            {
                //Jeśli tak to zwiększamy zmienną licznik o 1
                licznik++;
                //I przypisujemy wartość z licznika do zmiennej id w tym konstruktorze
                this.id = licznik.ToString();
            }
            else
            {      
                //W przeciwnym razie wartość ze zmiennej globalnej id przypisujemy do wartości zmiennej id konstruktora
                this.id = id;
            }
            this.imie = imie;
            this.gatunek = gatunek;
            this.rasa = rasa;
            this.plec = plec;
            this.dataUrodzenia = dataUrodzenia;
            this.waga = waga;
            this.wlasciciel = wlasciciel;
        }
        //Tworzenie konstruktora z trzema argumentami
        public Pacjent(string id, string imie, Klient wlasciciel)
        {
            this.id = id;
            this.imie = imie;
            this.wlasciciel = wlasciciel;
        }
        //Nadpisywanie metody ToString(), aby zwracała imię pacjenta
        public override string ToString()
        {
            return imie;
        }
        //Tworzenie metody do generowania nowego numeru ID pacjenta po dodaniu nowego pacjenta do bazy
        public static string GenerujNoweId()
        {
            licznik++;
            return licznik.ToString();
        }
    }
}
