using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia
{
    public class Lekarz : Osoba
    {
        public int Specjalizacja;

        public Lekarz(int id, string imie, string nazwisko, string plec, int specjalizacja): base (imie,nazwisko)
        {
            Specjalizacja = specjalizacja;
        }

        public Lekarz(string imie, string nazwisko) : base(imie, nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public override string ToString()
        {
            return imie + " " + nazwisko;
        }

        public void DodajLekarza()
        {

        }
        public void EdytujLekarza()
        {

        }
        public void UsunLekarza()
        {

        }
    }
}
