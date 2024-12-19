
namespace Przychodnia
{
    //Tworzenie klasy która dziedziczy po klasie Osoba
    public class Lekarz : Osoba
    {
        private static int licznik = 0;
        public string specjalizacja;
        //Tworzenie konstruktora ze wszystkimi argumentami
        public Lekarz(string id, string imie, string nazwisko, string plec, string specjalizacja, string nrTelefonu, string mail) : base(id, imie, nazwisko)
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
            this.plec = plec;
            this.specjalizacja = specjalizacja;
            this.nrTelefonu = nrTelefonu;
            this.mail = mail;
        }
        //Tworzenie konstruktora z dwoma argumentami
        public Lekarz(string imie, string nazwisko) : base(imie, nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        //Nadpisywanie metody ToString żeby została ona zwrócona w postaci imie + nazwisko
        public override string ToString()
        {
            return imie + " " + nazwisko;
        }
        //Tworzenie metody do generowania nowego numeru ID lekarza po dodaniu nowego lekarza do bazy
        public static string GenerujNoweId()
        {
            licznik++;
            return licznik.ToString();
        }
    }
}
