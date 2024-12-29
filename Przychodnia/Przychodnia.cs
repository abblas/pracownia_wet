using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Przychodnia
{
    public partial class Przychodnia : Form
    {
        private Uzytkownik zalogowanyUzytkownik;
        public Przychodnia(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            this.zalogowanyUzytkownik = uzytkownik;
        }
        private void label_VetAnimal_Click(object sender, EventArgs e)
        {

        }
        private void btn_Wizyty_Click(object sender, EventArgs e)
        {
            Menu_Wizyty menu_Wizyty = new Menu_Wizyty(zalogowanyUzytkownik);
            menu_Wizyty.Show();
        }
        private void btn_Pacjenci_Click(object sender, EventArgs e)
        {
            Menu_Pacjenci menu_Pacjenci = new Menu_Pacjenci(zalogowanyUzytkownik);
            menu_Pacjenci.Show();
        }
        private void btn_Wlasciciele_Click(object sender, EventArgs e)
        {
            Menu_Wlascicieli menu_wlascicieli = new Menu_Wlascicieli(zalogowanyUzytkownik);
            menu_wlascicieli.Show();
        }
        private void Przychodnia_Load(object sender, EventArgs e)
        {

        }
        private void btn_zakonczProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Lekarze_Click(object sender, EventArgs e)
        {
            Menu_Lekarze menu_Lekarze = new Menu_Lekarze(zalogowanyUzytkownik);
            menu_Lekarze.Show();
        }
        private void btn_wyloguj_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ukryj bie¿¹ce okno
            zalogowanyUzytkownik = null; // Wyzerowanie obecnie zalogowanego u¿ytkownika

            using (Logowanie logowanie = new Logowanie())
            {
                if (logowanie.ShowDialog() == DialogResult.OK)
                {
                    // Przypisz nowego zalogowanego u¿ytkownika
                    zalogowanyUzytkownik = logowanie.ZalogowanyUzytkownik;

                    // Zaktualizuj interfejs w zale¿noœci od nowej roli u¿ytkownika
                    this.Show();
                }
                else
                {
                    // Jeœli u¿ytkownik zamknie ekran logowania, zakoñcz aplikacjê
                    this.Close();
                }
            }
        }
    }
}

        