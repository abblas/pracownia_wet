
namespace Przychodnia
{
    public partial class Menu_Wlascicieli : Form
    {
        private Uzytkownik zalogowanyUzytkownik;
        private string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "klienci.txt");
        public Menu_Wlascicieli(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            ustawieniaDataGridView_listaWlascicieli();
            this.zalogowanyUzytkownik = uzytkownik;
            OgraniczDostepDoKontrolek();
        }
        public List<Klient> klienci = new List<Klient>();
        public List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();
        private void Menu_Wlascicieli_Load(object sender, EventArgs e)
        {
            OdczytajWlascicieliZPliku();
            dataGridView_listaWlascicieli.SelectionChanged += dataGridView_listaWlascicieli_SelectionChanged;
        }
        private void btn_ListaWlascicieli_Click(object sender, EventArgs e)
        {
            dataGridView_listaWlascicieli.Visible = true;
            btn_cofnijDoMenuWlascicieli.Visible = true;
            panel_Wlasciciele.Visible = false;
            label_ListaWlascicieli.Visible = true;
            dataGridView_listaWlascicieli.ClearSelection();
        }
        private void btn_DodajWłaściciela_Click(object sender, EventArgs e)
        {
            panel_NowyWlasciciel.Visible = true;
            panel_Wlasciciele.Visible = false;
            btn_cofnijDoMenuWlascicieli.Visible = true;
            dataGridView_listaWlascicieli.Visible = true;
            label_ListaWlascicieli.Visible = true;
            dataGridView_listaWlascicieli.ClearSelection();
            int id = klienci.Count + 1;
            string autoId = id.ToString();
            textBox_idWlasciciela.Text = autoId;
            textBox_idWlasciciela.ReadOnly = true;
        }
        private void btn_ZapiszWlasciciela_Click(object sender, EventArgs e)
        {
            string id = textBox_idWlasciciela.Text;
            string imie = textBox_imieWlasciciela.Text;
            string nazwisko = textBox_nazwiskoWlasciciela.Text;
            string plec = comboBox_plecWlasciciela.Text;
            string adres = textBox_adresWlasciciela.Text;
            string nrTelefonu = textBox_nrTelefonuWlasciciela.Text;
            string mail = textBox_emailWlasciciela.Text;

            if (string.IsNullOrWhiteSpace(plec))
            {
                MessageBox.Show("Proszę wybrać płeć właściciela.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }

            string noweId = Klient.GenerujNoweId();
            Klient nowyKlient = new Klient(id, imie, nazwisko, plec, adres, nrTelefonu, mail);

            // Dodanie wizyty do listy
            klienci.Add(nowyKlient);
            wyczyscPola();
            //Zwiększenie ID wizyty
            zwiekszIdWlasciciela();
            wyswietlTabelkaWlascicieli();
            ZapiszWlascicieliDoPliku();
        }
        private void btn_EdytujWłaściciela_Click(object sender, EventArgs e)
        {
            dataGridView_listaWlascicieli.Visible = true;
            btn_cofnijDoMenuWlascicieli.Visible = true;
            panel_Wlasciciele.Visible = false;
            btn_edycjaWlasciciela.Visible = true;
            label_wlascicielDoEdycji.Visible = true;
            dataGridView_listaWlascicieli.ClearSelection();
        }
        private void btn_edycjaWlasciciela_Click(object sender, EventArgs e)
        {
            panel_edycjaWlasciciela.Visible = true;
            btn_cofnijDoMenuWlascicieli.Visible = true;
            pobierzWartosciDoEdycji();
        }
        private void btn_zapiszEdytowanegoWlasciciela_Click(object sender, EventArgs e)
        {
            string id = textBox_idEdytowanegoWlasciciela.Text;
            string imie = textBox_imieEdytowanegoWlasciciela.Text;
            string nazwisko = textBox_nazwiskoEdytowanegoWlasciciela.Text;
            string plec = comboBox_plecEdytowanegoWlasciciela.Text;
            string adres = textBox_adresEdytowanegoWlasciciela.Text;
            string nrTelefonu = textBox_nrTelefonuEdytowanegoWlasciciela.Text;
            string mail = textBox_mailEdytowanegoWlasciciela.Text;
            if (string.IsNullOrWhiteSpace(plec))
            {
                MessageBox.Show("Proszę wybrać płeć właściciela.");
                return;
            }
            Klient edytowanyKlient = null;
            foreach (Klient klient in klienci)
            {
                if (klient.id == id)
                {
                    edytowanyKlient = klient;
                    break;
                }
            }
            if (edytowanyKlient != null)
            {
                edytowanyKlient.imie = imie;
                edytowanyKlient.nazwisko = nazwisko;
                edytowanyKlient.plec = plec;
                edytowanyKlient.adres = adres;
                edytowanyKlient.nrTelefonu = nrTelefonu;
                edytowanyKlient.mail = mail;
            }
            wyczyscPola();
            wyswietlTabelkaWlascicieli();
            ZapiszWlascicieliDoPliku();
        }
        private void btn_UsunWłaściciela_Click(object sender, EventArgs e)
        {
            dataGridView_listaWlascicieli.Visible = true;
            btn_cofnijDoMenuWlascicieli.Visible = true;
            panel_Wlasciciele.Visible = false;
            btn_usuwanieWlasciciela.Visible = true;
            label_usuwanieWlasciciela.Visible = true;
            dataGridView_listaWlascicieli.ClearSelection();
        }
        private void btn_usuwanieWlasciciela_Click(object sender, EventArgs e)
        {
            DataGridViewRow wybranyKlient = dataGridView_listaWlascicieli.SelectedRows[0];
            string idKlienta = wybranyKlient.Cells["id"].Value.ToString();
            Klient klientDoUsuniecia = null;
            foreach (Klient klient in klienci)
            {
                if (klient.id == idKlienta)
                {
                    klientDoUsuniecia = klient;
                    break;
                }
            }
            DialogResult usunKlienta = MessageBox.Show("Czy na pewno chcesz usunąć wybranego właściciela?", "Ostrzeżenie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (usunKlienta != DialogResult.Yes)
            {
                return;
            }
            klienci.Remove(klientDoUsuniecia);
            dataGridView_listaWlascicieli.ClearSelection();
            foreach (Klient klient in klienci)
            {
                // Zmniejsz numer ID o 1 dla wizyt po usuniętej
                string idText = klient.id;
                int id = int.Parse(idText);
                if (id > int.Parse(idKlienta))
                {
                    id--;
                    klient.id = id.ToString();
                }
            }
            // Odśwież widok tabeli
            wyswietlTabelkaWlascicieli();
            // Zapisz zmiany do pliku
            ZapiszWlascicieliDoPliku();
        }
        private void btn_cofnijDoMenuWlascicieli_Click(object sender, EventArgs e)
        {
            panel_NowyWlasciciel.Visible = false;
            panel_Wlasciciele.Visible = true;
            btn_cofnijDoMenuWlascicieli.Visible = false;
            dataGridView_listaWlascicieli.Visible = false;
            btn_edycjaWlasciciela.Visible = false;
            panel_edycjaWlasciciela.Visible = false;
            btn_usuwanieWlasciciela.Visible = false;
            label_ListaWlascicieli.Visible = false;
            label_wlascicielDoEdycji.Visible = false;
            label_usuwanieWlasciciela.Visible = false;
        }
        private void btn_wrocDoMenuGlownego_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ZapiszWlascicieliDoPliku()
        {
            // Przygotowanie listy danych wizyt w formacie tekstowym
            var klienciText = new List<string>();
            klienciText.Add("Id-Imie-Nazwisko-Plec-Adres-NrTelefonu-Email"); // Nagłówek

            foreach (var klient in klienci)
            {
                // Tworzymy wiersz dla każdego pacjenta
                string klientText = $"{klient.id}-{klient.imie}-{klient.nazwisko}-{klient.plec}-" +
                                    $"{klient.adres}-{klient.nrTelefonu}-{klient.mail}";
                klienciText.Add(klientText);
            }

            // Zapisujemy całą listę wizyt do pliku
            File.WriteAllLines(sciezkaPliku, klienciText);

        }
        private void OdczytajWlascicieliZPliku()
        {
            // Odczytujemy wszystkie linie z pliku
            string[] linie = File.ReadAllLines(sciezkaPliku);

            // Pomijamy nagłówek
            for (int i = 1; i < linie.Length; i++)
            {
                string linia = linie[i];
                string[] dane = linia.Split('-');

                if (dane.Length == 7)
                {
                    string id = dane[0];
                    string imie = dane[1];
                    string nazwisko = dane[2];
                    string plec = dane[3];
                    string adres = dane[4];
                    string nrTelefonu = dane[5];
                    string mail = dane[6];
                    Klient klient = new Klient(id, imie, nazwisko, plec, adres, nrTelefonu, mail);
                    klienci.Add(klient);
                }
            }
            // Po załadowaniu wizyt z pliku, zaktualizuj DataGridView
            wyswietlTabelkaWlascicieli();
        }
        private void wyczyscPola()
        {
            textBox_imieWlasciciela.Text = string.Empty;
            textBox_nazwiskoWlasciciela.Text = string.Empty;
            comboBox_plecWlasciciela.SelectedIndex = -1;
            textBox_adresWlasciciela.Text = string.Empty;
            textBox_nrTelefonuWlasciciela.Text = string.Empty;
            textBox_emailWlasciciela.Text = string.Empty;
            textBox_idEdytowanegoWlasciciela.Text = string.Empty;
            textBox_imieEdytowanegoWlasciciela.Text = string.Empty;
            textBox_nazwiskoEdytowanegoWlasciciela.Text = string.Empty;
            comboBox_plecEdytowanegoWlasciciela.SelectedIndex = -1;
            textBox_adresEdytowanegoWlasciciela.Text = string.Empty;
            textBox_nrTelefonuEdytowanegoWlasciciela.Text = string.Empty;
            textBox_mailEdytowanegoWlasciciela.Text = string.Empty;
            dataGridView_listaWlascicieli.ClearSelection();
        }
        private void zwiekszIdWlasciciela()
        {
            int maxNumerWizyty = 0;
            foreach (Klient klient in klienci)
            {
                string idText = klient.id;
                int id = int.Parse(idText);
                if (id > maxNumerWizyty)
                {
                    maxNumerWizyty = id;
                }
            }
            // Nowe ID to maksymalny numer + 1
            string newId = (maxNumerWizyty + 1).ToString();
            textBox_idWlasciciela.Text = newId;
        }
        private void wyswietlTabelkaWlascicieli()
        {
            // Czyścimy istniejące dane w tabelce
            dataGridView_listaWlascicieli.Rows.Clear();

            // Dodajemy wiersze na podstawie listy wizyt
            foreach (var klient in klienci)
            {
                dataGridView_listaWlascicieli.Rows.Add(
                    klient.id,
                    klient.imie,
                    klient.nazwisko,
                    klient.plec,
                    klient.adres,
                    klient.nrTelefonu,
                    klient.mail
                    );
            }
        }
        private void pobierzWartosciDoEdycji()
        {
            if (dataGridView_listaWlascicieli.SelectedRows.Count > 0)
            {
                DataGridViewRow wybranyWiersz = dataGridView_listaWlascicieli.SelectedRows[0];
                string id = wybranyWiersz.Cells[0].Value.ToString();
                textBox_idEdytowanegoWlasciciela.Text = id;
                string imie = wybranyWiersz.Cells[1].Value.ToString();
                textBox_imieEdytowanegoWlasciciela.Text = imie;
                string nazwisko = wybranyWiersz.Cells[2].Value.ToString();
                textBox_nazwiskoEdytowanegoWlasciciela.Text = nazwisko;
                string plec = wybranyWiersz.Cells[3].Value.ToString();
                comboBox_plecEdytowanegoWlasciciela.Text = plec;
                string adres = wybranyWiersz.Cells[4].Value.ToString();
                textBox_adresEdytowanegoWlasciciela.Text = adres;
                string nrTelefonu = wybranyWiersz.Cells[5].Value.ToString();
                textBox_nrTelefonuEdytowanegoWlasciciela.Text = nrTelefonu;
                string mail = wybranyWiersz.Cells[6].Value.ToString();
                textBox_mailEdytowanegoWlasciciela.Text = mail;
            }
        }
        private void ustawieniaDataGridView_listaWlascicieli()
        {
            dataGridView_listaWlascicieli.Columns.Clear();
            dataGridView_listaWlascicieli.Columns.Add("Id", "Id");
            dataGridView_listaWlascicieli.Columns.Add("Imie", "Imię");
            dataGridView_listaWlascicieli.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView_listaWlascicieli.Columns.Add("Plec", "Płeć");
            dataGridView_listaWlascicieli.Columns.Add("Adres", "Adres");
            dataGridView_listaWlascicieli.Columns.Add("Nr telefonu", "Nr telefonu");
            dataGridView_listaWlascicieli.Columns.Add("E-mail", "E-mail");
            dataGridView_listaWlascicieli.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_listaWlascicieli.MultiSelect = false; // Możliwość zaznaczania tylko jednego wiersza
            dataGridView_listaWlascicieli.ClearSelection(); // Wyczyszczenie zaznaczenia
            dataGridView_listaWlascicieli.CurrentCell = null; // Usunięcie zaznaczenia bieżącej komórki
        }
        private void dataGridView_listaWlascicieli_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_listaWlascicieli.SelectedRows.Count > 0)
            {
                // Jeśli zaznaczony wiersz, włącz przycisk "Edytuj"
                btn_edycjaWlasciciela.Enabled = true;
                btn_usuwanieWlasciciela.Enabled = true;
            }
            else
            {
                // Jeśli nie ma zaznaczonego wiersza, wyłącz przycisk "Edytuj"
                btn_edycjaWlasciciela.Enabled = false;
                btn_usuwanieWlasciciela.Enabled = false;
            }
        }
        private void OgraniczDostepDoKontrolek()
        {
            // Sprawdzamy rolę użytkownika
            if (zalogowanyUzytkownik.Rola == "Lekarz")
            {
                btn_DodajWłaściciela.Enabled = false;
                btn_EdytujWłaściciela.Enabled = false;
                btn_UsunWłaściciela.Enabled = false;
            }
            else if (zalogowanyUzytkownik.Rola == "Recepcjonista")
            {
                btn_EdytujWłaściciela.Enabled = false;
                btn_UsunWłaściciela.Enabled = false;
            }
                 
        }
    }
}
