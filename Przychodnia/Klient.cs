
namespace Przychodnia
{
    public class Klient : Osoba
    {
        private static int licznik = 0;
        public string adres;

        public Klient(string id, string imie, string nazwisko, string plec, string adres, string nrTelefonu, string mail) : base (imie, nazwisko)
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
            this.plec = plec;
            this.adres = adres;
            this.nrTelefonu = nrTelefonu;
            this.mail = mail;
        }
        public Klient(string imie) : base(imie)
        {
            this.imie = imie;
        }
        public Klient(string imie, string nazwisko) : base (imie, nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public override string ToString()
        {
            return imie + " " + nazwisko;
        }
        public static string GenerujNoweId()
        {
            licznik++;
            return licznik.ToString();
        }
    }
}
