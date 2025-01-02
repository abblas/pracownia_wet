using Microsoft.VisualBasic.Logging;
using Przychodnia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Przychodnia.Uzytkownik;
using static System.Windows.Forms.LinkLabel;

namespace Przychodnia
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
            // Podpięcie obsługi klawiszy dla formularza
            this.KeyPreview = true; // Pozwala na przechwytywanie klawiszy w formularzu
            this.KeyDown += Logowanie_KeyDown;
        }
        private void Logowanie_KeyDown(object sender, KeyEventArgs e)
        {
            // Sprawdź, czy naciśnięto klawisz Enter
            if (e.KeyCode == Keys.Enter)
            {
                btn_zaloguj.PerformClick(); // Symuluje kliknięcie przycisku Zaloguj
            }
        }
        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
        private void btn_zaloguj_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string haslo = textBox_haslo.Text;
            if (SprawdzUzytkownika(login, haslo))
            {
                // Przekazanie zalogowanego użytkownika do głównego okna
                MessageBox.Show("Zalogowano jako: " + " " + ZalogowanyUzytkownik.Rola);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.");
            }
        }
        //Wczytaj użytkowników z pliku
        private bool SprawdzUzytkownika(string login, string haslo)
        {
            string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "uzytkownicy.txt"); ; // Ścieżka do pliku
            if (!File.Exists(sciezkaPliku))
            {
                MessageBox.Show("Plik z użytkownikami nie istnieje.");
                return false;
            }
            string[] linie = File.ReadAllLines(sciezkaPliku);
            foreach (string linia in linie)
            {
                // Rozdzielamy dane w linii
                string[] dane = linia.Split(';');
                if (dane.Length == 3)
                {
                    string loginZPliku = dane[0];
                    string hasloZPliku = dane[1];
                    string rola = dane[2];

                    // Sprawdzamy, czy login i hasło są poprawne
                    if (login == loginZPliku && haslo == hasloZPliku)
                    {
                        // Tworzymy odpowiedni obiekt użytkownika na podstawie roli
                        if (rola == "Administrator")
                        {
                            ZalogowanyUzytkownik = new Administratorzy(loginZPliku, hasloZPliku);
                        }
                        else if (rola == "Kierownik przychodni")
                        {
                            ZalogowanyUzytkownik = new KierownicyPrzychodni(loginZPliku, hasloZPliku);
                        }
                        else if (rola == "Kierownik recepcji")
                        {
                            ZalogowanyUzytkownik = new KierownicyRecepcji(loginZPliku, hasloZPliku);
                        }
                        else if (rola == "Recepcjonista")
                        {
                            ZalogowanyUzytkownik = new Recepcjoniści(loginZPliku, hasloZPliku);
                        }
                        else if (rola == "Lekarz")
                        {
                            ZalogowanyUzytkownik = new Lekarze(loginZPliku, hasloZPliku);
                        }
                        // Jeśli znalazł pasującego użytkownika, zwracamy true
                        return true;
                    }
                }
            }
            // Jeśli nie znaleziono pasującego użytkownika
            return false;
        }
        public Uzytkownik ZalogowanyUzytkownik { get; private set; }
    }
}    
