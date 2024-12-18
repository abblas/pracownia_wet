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
        //Ustawienie właściwości dla loginu, hasła i roli
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
        public virtual bool Zaloguj(string podanyLogin, string podaneHaslo)
        {
            return this.login == podanyLogin && this.haslo == podaneHaslo;
        }
    }
}
