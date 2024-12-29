using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    public class Uzytkownik
    {
        private string login;
        private string haslo;
        private string rola;
        public Uzytkownik(string rola)
        {
            this.rola = rola;
        }

        //Tworzenie konstruktora z dwoma argumentami - login, hasło
        public Uzytkownik(string login, string haslo)
        {
            this.login = login;
            this.haslo = haslo;
        }
        //Tworzenie konstruktora z trzema argumentami - login, hasło, rola
        public Uzytkownik(string login, string haslo, string rola)
        {
            this.login = login;
            this.haslo = haslo;
            this.rola = rola;
        }
        //Ustawienie właściwości dla loginu, hasła i roli (zastosowanie hermetyzacji)
        public string Login
        {
            get { return login; }
        }
        public string Haslo
        { 
            get { return haslo; } 
        }
        public string Rola
        {
            get { return rola; }
        }
        //Metoda logowania
        public virtual bool Zaloguj(string login, string haslo)
        {
            return this.login == login && this.haslo == haslo; ;
        }

        // Pobierz użytkowników z pliku
        public static List<Uzytkownik> PobierzUzytkownikowZPliku(string sciezka)
        {
            List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();
            {
                string[] linie = File.ReadAllLines(sciezka);

                foreach (var linia in linie)
                {
                    string[] dane = linia.Split(',');

                    if (dane.Length == 3)
                    {
                        string login = dane[0];
                        string haslo = dane[1];
                        string rola = dane[2];

                        uzytkownicy.Add(new Uzytkownik(login, haslo, rola));
                    }
                }
            }
            return uzytkownicy;
        }
        public class Administratorzy : Uzytkownik
        {
            public Administratorzy(string login, string haslo)
                : base(login, haslo, "Administrator") { }

            // Nadpisanie metody Zaloguj
            public override bool Zaloguj(string podanyLogin, string podaneHaslo)
            {
                return base.Zaloguj(podanyLogin, podaneHaslo);
            }
        }
        public class KierownicyPrzychodni : Uzytkownik
        {
            public KierownicyPrzychodni(string login, string haslo)
                : base(login, haslo, "Kierownik przychodni") { }

            // Nadpisanie metody Zaloguj
            public override bool Zaloguj(string podanyLogin, string podaneHaslo)
            {
                return base.Zaloguj(podanyLogin, podaneHaslo);
            }
        }
        public class KierownicyRecepcji : Uzytkownik
        {
            public KierownicyRecepcji(string login, string haslo)
                : base(login, haslo, "Kierownik recepcji") { }

            // Nadpisanie metody Zaloguj
            public override bool Zaloguj(string podanyLogin, string podaneHaslo)
            {
                return base.Zaloguj(podanyLogin, podaneHaslo);
            }
        }
        public class Recepcjoniści : Uzytkownik
        {
            public Recepcjoniści(string login, string haslo)
                : base(login, haslo, "Recepcjonista") { }

            // Nadpisanie metody Zaloguj
            public override bool Zaloguj(string podanyLogin, string podaneHaslo)
            {
                return base.Zaloguj(podanyLogin, podaneHaslo);
            }
        }
        public class Lekarze : Uzytkownik
        {
            public Lekarze(string login, string haslo)
                : base(login, haslo, "Lekarz") { }

            // Nadpisanie metody Zaloguj
            public override bool Zaloguj(string podanyLogin, string podaneHaslo)
            {
                return base.Zaloguj(podanyLogin, podaneHaslo);
            }
        }
    }
}

