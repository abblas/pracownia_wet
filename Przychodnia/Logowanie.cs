using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }
        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
        private void btn_zaloguj_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string haslo = textBox_haslo.Text;

            //Wczytaj użytkowników z pliku
            bool uzytkownik = SprawdzUzytkownika(login, haslo);

            if (uzytkownik)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.");
            }
        }
        // Metoda do sprawdzania loginu i hasła
        private bool SprawdzUzytkownika(string login, string haslo)
        {
            string sciezkaPliku = @"C:\Users\Luke\Desktop\uzytkownicy.txt";  // Zmień na odpowiednią ścieżkę do pliku

            if (File.Exists(sciezkaPliku))
            {
                string[] linie = File.ReadAllLines(sciezkaPliku);

                foreach (string linia in linie)
                {
                    // Zapisane dane w pliku: login;haslo
                    string[] dane = linia.Split(';');
                    string zapisanyLogin = dane[0];
                    string zapisaneHaslo = dane[1];

                    // Jeśli login i hasło się zgadzają, logowanie udane
                    if (login == zapisanyLogin && haslo == zapisaneHaslo)
                    {
                        return true;
                    }
                }
            }
            return false; // Zwróć false, jeśli nie znaleziono dopasowania
        }
    }
}
