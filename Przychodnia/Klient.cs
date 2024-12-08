using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //public class WczytywanieKlientow
        //{
        //    public static List<Klient> wczytajKlientowZPliku(string sciezkaPliku)
        //    {
        //        List<Klient> klienci = new List<Klient>();
        //        string[] klienciText = File.ReadAllLines(sciezkaPliku);
        //        for (int i = 1; i < klienciText.Length; i++)
        //        {
        //            string k = klienciText[i];
        //            string[] nazwaKlienta = k.Split('-');

        //            if (nazwaKlienta.Length == 7)
        //            {
        //                string imie = nazwaKlienta[1];
        //                string nazwisko = nazwaKlienta[2];
        //                Klient klient = new Klient(imie, nazwisko);
        //                klienci.Add(klient);
        //            }
        //        }
        //        return klienci;
        //    }
        //}
    }
}
