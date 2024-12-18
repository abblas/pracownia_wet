using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Przychodnia
{
    public class Osoba
    {
        public string id;
        public string imie;
        public string nazwisko;
        public string plec;
        public string nrTelefonu;
        public string mail;
        //Tworzenie konstruktora z jednym argumentem
        public Osoba(string imie)
        {
            this.imie = imie;
        }
        //Tworzenie konstruktora z dwoma argumentami
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        //Tworzenie konstruktora z trzema argumentami
        public Osoba(string id, string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        //Tworzenie konstruktora ze wszystkimi argumentami
        public Osoba(string id, string imie, string nazwisko, string plec, string nrTelefonu, string mail) : this(imie, nazwisko) 
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;   
            this.plec = plec;
            this.nrTelefonu = nrTelefonu;
            this.mail = mail;
        }
    }
}
