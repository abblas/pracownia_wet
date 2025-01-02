using System.Globalization;
using static Przychodnia.Menu_Wizyty;

namespace Przychodnia
{
    public partial class Menu_Pacjenci : Form
    {
        private Uzytkownik zalogowanyUzytkownik;
        private string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "pacjenci.txt");
        public Menu_Pacjenci(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            ustawieniaDataGridView_listaPacjentow();
            this.zalogowanyUzytkownik = uzytkownik;
            OgraniczDostepDoKontrolek();
        }
        public List<Pacjent> pacjenci = new List<Pacjent>();
        private void Menu_Pacjenci_Load(object sender, EventArgs e)
        {
            dateTimePicker_DataUrodzeniaPacjenta.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DataUrodzeniaPacjenta.CustomFormat = " "; // Puste pole na starcie
            OdczytajPacjentowZPliku();
            dataGridView_listaPacjentow.SelectionChanged += dataGridView_listaPacjentow_SelectionChanged;
        }
        private void btn_ListaPacjentow_Click(object sender, EventArgs e)
        {
            panel_NowyPacjent.Visible = false;
            panel_Pacjenci.Visible = false;
            btn_cofnijDoMenuPacjentow.Visible = true;
            label_ListaPacjentow.Visible = true;
            btn_edycjaPacjenta.Visible = false;
            dataGridView_listaPacjentow.Visible = true;
            panel_edycjaPacjenta.Visible = false;
            dataGridView_listaPacjentow.ClearSelection();
        }
        private void btn_DodajPacjenta_Click(object sender, EventArgs e)
        {
            pobierzListeKlientow();
            wyczyscPola();
            panel_NowyPacjent.Visible = true;
            panel_Pacjenci.Visible = false;
            btn_cofnijDoMenuPacjentow.Visible = true;
            label_ListaPacjentow.Visible = true;
            dataGridView_listaPacjentow.Visible = true;
            int id = pacjenci.Count + 1;
            string autoId = id.ToString();
            textBox_idPacjenta.Text = autoId;
            textBox_idPacjenta.ReadOnly = true;
        }
        private void btn_EdytujPacjenta_Click(object sender, EventArgs e)
        {
            panel_NowyPacjent.Visible = false;
            panel_Pacjenci.Visible = false;
            btn_cofnijDoMenuPacjentow.Visible = true;
            label_ListaPacjentow.Visible = false;
            btn_edycjaPacjenta.Visible = true;
            dataGridView_listaPacjentow.Visible = true;
            label_pacjentDoEdycji.Visible = true;
            dataGridView_listaPacjentow.ClearSelection();
        }
        private void btn_edycjaPacjenta_Click(object sender, EventArgs e)
        {
            panel_edycjaPacjenta.Visible = true;
            label_edycjaPacjenta.Visible = true;
            pobierzListeKlientow();
            pobierzWartosciDoEdycji();
        }
        private void btn_zapiszEdytowanegoPacjenta_Click(object sender, EventArgs e)
        {
            // Pobieranie danych z kontrolek
            string id = textBox_idEdytowanegoPacjenta.Text;
            string imie = textBox_imieEdytowanegoPacjenta.Text;
            string gatunek = comboBox_gatunekEdytowanegoPacjenta.Text;
            string rasa = textBox_rasaEdytowanegoPacjenta.Text;
            string plec = comboBox_plecEdytowanegoPacjenta.Text;
            DateTime dataUrodzenia = dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Value;
            string waga = textBox_wagaEdytowanegoPacjenta.Text;
            string wlascicieltext = comboBox_wlascicielEdytowanegoPacjenta.Text;

            // Rozdzielamy na imię i nazwisko
            string[] daneWlasciciela = wlascicieltext.Split(' ');
            if (daneWlasciciela.Length < 2)
            {
                MessageBox.Show("Proszę podać pełne imię i nazwisko.");
                return;
            }
            string imieWlasciciela = daneWlasciciela[0];
            string nazwiskoWlasciciela = daneWlasciciela[1];
            Klient wlasciciel = new Klient(imieWlasciciela, nazwiskoWlasciciela);
            if (string.IsNullOrWhiteSpace(gatunek))
            {
                MessageBox.Show("Proszę wybrać gatunek pacjenta.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }
            if (string.IsNullOrWhiteSpace(plec))
            {
                MessageBox.Show("Proszę wybrać płeć pacjenta.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }

            if (string.IsNullOrWhiteSpace(wlascicieltext))
            {
                MessageBox.Show("Proszę wybrać właściciela pacjenta.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }
            Pacjent edytowanyPacjent = null;
            foreach (Pacjent pacjent in pacjenci)
            {
                if (pacjent.id == id)
                {
                    edytowanyPacjent = pacjent;
                    break;
                }
            }
            if (edytowanyPacjent != null)
            {
                edytowanyPacjent.imie = imie;
                edytowanyPacjent.gatunek = gatunek;
                edytowanyPacjent.rasa = rasa;
                edytowanyPacjent.plec = plec;
                edytowanyPacjent.dataUrodzenia = dataUrodzenia;
                edytowanyPacjent.waga = waga;
                edytowanyPacjent.wlasciciel = wlasciciel;
            }
            //Czyszczenie pól formularza
            wyczyscPola();
            wyswietlTabelkaPacjentow();
            ZapiszPacjentowDoPliku();
        }
        private void btn_UsunPacjenta_Click(object sender, EventArgs e)
        {
            panel_NowyPacjent.Visible = false;
            panel_Pacjenci.Visible = false;
            btn_cofnijDoMenuPacjentow.Visible = true;
            label_ListaPacjentow.Visible = false;
            dataGridView_listaPacjentow.Visible = true;
            label_usuwaniePacjenta.Visible = true;
            btn_usuwaniePacjenta.Visible = true;
            dataGridView_listaPacjentow.ClearSelection();
        }
        private void btn_usuwaniePacjenta_Click(object sender, EventArgs e)
        {
            DataGridViewRow wybranyPacjent = dataGridView_listaPacjentow.SelectedRows[0];
            string idPacjenta = wybranyPacjent.Cells["id"].Value.ToString();
            Pacjent pacjentDoUsuniecia = null;
            foreach (Pacjent pacjent in pacjenci)
            {
                if (pacjent.id == idPacjenta)
                {
                    pacjentDoUsuniecia = pacjent;
                    break;
                }
            }
            DialogResult usunPacjenta = MessageBox.Show("Czy na pewno chcesz usunąć wybranego pacjenta?", "Ostrzeżenie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (usunPacjenta != DialogResult.Yes)
            {
                return;
            }
            pacjenci.Remove(pacjentDoUsuniecia);
            dataGridView_listaPacjentow.ClearSelection();
            foreach (Pacjent pacjent in pacjenci)
            {
                // Zmniejsz numer ID o 1 dla wizyt po usuniętej
                string idText = pacjent.id;
                int id = int.Parse(idText);
                if (id > int.Parse(idPacjenta))
                {
                    id--;
                    pacjent.id = id.ToString();
                }
            }
            // Odśwież widok tabeli
            wyswietlTabelkaPacjentow();
            // Zapisz zmiany do pliku
            ZapiszPacjentowDoPliku();
        }
        private void btn_ZapiszPacjenta_Click(object sender, EventArgs e)
        {
            string id = textBox_idPacjenta.Text;
            string imie = textBox_ImiePacjenta.Text;
            string gatunek = comboBox_GatunekPacjenta.Text;
            string rasa = textBox_RasaPacjenta.Text;
            string plec = comboBox_Plec.Text;
            DateTime dataUrodzenia = dateTimePicker_DataUrodzeniaPacjenta.Value;
            string waga = textBox_WagaPacjenta.Text;
            string wlascicieltext = comboBox_ListaWlascicieli.Text;
            string[] daneWlasciciela = wlascicieltext.Split(' ');
            if (daneWlasciciela.Length < 2)
            {
                MessageBox.Show("Proszę podać pełne imię i nazwisko.");
                return;
            }
            string imieWlasciciela = daneWlasciciela[0];
            string nazwiskoWlasciciela = daneWlasciciela[1];
            Klient wlasciciel = new Klient(imieWlasciciela, nazwiskoWlasciciela);
            if (string.IsNullOrWhiteSpace(gatunek))
            {
                MessageBox.Show("Proszę wybrać gatunek pacjenta.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }
            if (string.IsNullOrWhiteSpace(plec))
            {
                MessageBox.Show("Proszę wybrać płeć pacjenta.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }

            if (string.IsNullOrWhiteSpace(wlascicieltext))
            {
                MessageBox.Show("Proszę wybrać właściciela pacjenta.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }
            string noweId = Pacjent.GenerujNoweId();
            Pacjent nowyPacjent = new Pacjent(id, imie, gatunek, rasa, plec, dataUrodzenia, waga, wlasciciel);

            // Dodanie wizyty do listy
            pacjenci.Add(nowyPacjent);

            //Czyszczenie pól formularza
            wyczyscPola();
            //Zwiększenie ID wizyty
            zwiekszIdPacjenta();
            wyswietlTabelkaPacjentow();
            ZapiszPacjentowDoPliku();
        }
        private void btn_cofnijDoMenuPacjentow_Click(object sender, EventArgs e)
        {
            panel_Pacjenci.Visible = true;
            panel_NowyPacjent.Visible = false;
            btn_cofnijDoMenuPacjentow.Visible = false;
            btn_edycjaPacjenta.Visible = false;
            panel_edycjaPacjenta.Visible = false;
            label_ListaPacjentow.Visible = false;
            dataGridView_listaPacjentow.Visible = false;
            label_usuwaniePacjenta.Visible = false;
            btn_usuwaniePacjenta.Visible = false;
            label_pacjentDoEdycji.Visible = false;
        }
        private void btn_wrocDoMenuGlownego_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ZapiszPacjentowDoPliku()
        {
            // Przygotowanie listy danych wizyt w formacie tekstowym
            var pacjenciText = new List<string>();
            pacjenciText.Add("IdPacjenta-Imie-Gatunek-Rasa-Plec-dataUrodzenia-Waga-Wlasciciel"); // Nagłówek

            foreach (var pacjent in pacjenci)
            {
                // Tworzymy wiersz dla każdego pacjenta
                string pacjentText = $"{pacjent.id}-{pacjent.imie}-{pacjent.gatunek}-{pacjent.rasa}-" +
                                    $"{pacjent.plec}-{pacjent.dataUrodzenia:dd.MM.yyyy}-{pacjent.waga}-" +
                                    $"{pacjent.wlasciciel}";
                pacjenciText.Add(pacjentText);
            }

            // Zapisujemy całą listę wizyt do pliku
            File.WriteAllLines(sciezkaPliku, pacjenciText);

            MessageBox.Show("Pacjenci zostali zapisani do pliku.");
        }
        private void OdczytajPacjentowZPliku()
        {
            // Odczytujemy wszystkie linie z pliku
            string[] linie = File.ReadAllLines(sciezkaPliku);

            // Pomijamy nagłówek
            for (int i = 1; i < linie.Length; i++)
            {
                string linia = linie[i];
                string[] dane = linia.Split('-');

                if (dane.Length == 8)
                {
                    string id = dane[0];
                    string gatunek = dane[2];
                    string rasa = dane[3];
                    string plec = dane[4];
                    DateTime dataUrodzenia = DateTime.ParseExact(dane[5], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    string waga = dane[6];
                    Klient wlasciciel = new Klient(dane[7].Split(' ')[0], dane[7].Split(' ')[1]);
                    Pacjent pacjent = new Pacjent(id, dane[1], gatunek, rasa, plec, dataUrodzenia, waga, wlasciciel);
                    pacjenci.Add(pacjent);
                }
            }
            // Po załadowaniu wizyt z pliku, zaktualizuj DataGridView
            wyswietlTabelkaPacjentow();
        }
        private void wyczyscPola()
        {
            textBox_ImiePacjenta.Text = string.Empty;
            comboBox_GatunekPacjenta.SelectedIndex = -1;
            textBox_RasaPacjenta.Text = string.Empty;
            comboBox_Plec.SelectedIndex = -1;
            dateTimePicker_DataUrodzeniaPacjenta.CustomFormat = " ";
            textBox_WagaPacjenta.Text = string.Empty;
            comboBox_ListaWlascicieli.Text = string.Empty;
            textBox_idEdytowanegoPacjenta.Text = string.Empty;
            textBox_imieEdytowanegoPacjenta.Text = string.Empty;
            comboBox_gatunekEdytowanegoPacjenta.SelectedIndex = -1;
            textBox_rasaEdytowanegoPacjenta.Text = string.Empty;
            comboBox_plecEdytowanegoPacjenta.SelectedIndex = -1;
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.CustomFormat = " ";
            textBox_wagaEdytowanegoPacjenta.Text = string.Empty;
            comboBox_wlascicielEdytowanegoPacjenta.Text = string.Empty;
            dataGridView_listaPacjentow.ClearSelection();
        }
        private void zwiekszIdPacjenta()
        {
            int maxNumerWizyty = 0;
            foreach (Pacjent pacjent in pacjenci)
            {
                string idText = pacjent.id;
                int id = int.Parse(idText);
                if (id > maxNumerWizyty)
                {
                    maxNumerWizyty = id;
                }
            }
            // Nowe ID to maksymalny numer + 1
            string newId = (maxNumerWizyty + 1).ToString();
            textBox_idPacjenta.Text = newId;
        }
        private void wyswietlTabelkaPacjentow()
        {
            // Czyścimy istniejące dane w tabelce
            dataGridView_listaPacjentow.Rows.Clear();

            // Dodajemy wiersze na podstawie listy wizyt
            foreach (var pacjent in pacjenci)
            {
                dataGridView_listaPacjentow.Rows.Add(
                    pacjent.id,
                    pacjent.imie,
                    pacjent.gatunek,
                    pacjent.rasa,
                    pacjent.plec,
                    pacjent.dataUrodzenia.ToString("dd.MM.yyyy"),
                    pacjent.waga,
                    pacjent.wlasciciel
                    );
            }
        }
        private void pobierzWartosciDoEdycji()
        {
            if (dataGridView_listaPacjentow.SelectedRows.Count > 0)
            {
                DataGridViewRow wybranyWiersz = dataGridView_listaPacjentow.SelectedRows[0];
                string id = wybranyWiersz.Cells[0].Value.ToString();
                textBox_idEdytowanegoPacjenta.Text = id;
                string imie = wybranyWiersz.Cells[1].Value.ToString();
                textBox_imieEdytowanegoPacjenta.Text = imie;
                string gatunek = wybranyWiersz.Cells[2].Value.ToString();
                comboBox_gatunekEdytowanegoPacjenta.Text = gatunek;
                string rasa = wybranyWiersz.Cells[3].Value.ToString();
                textBox_rasaEdytowanegoPacjenta.Text = rasa;
                string plec = wybranyWiersz.Cells[4].Value.ToString();
                comboBox_plecEdytowanegoPacjenta.Text = plec;
                string dataUrodzeniaText = wybranyWiersz.Cells[5].Value.ToString();
                DateTime.TryParse(dataUrodzeniaText, out DateTime dataUrodzenia);
                dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Value = dataUrodzenia;
                string waga = wybranyWiersz.Cells[6].Value.ToString();
                textBox_wagaEdytowanegoPacjenta.Text = waga;
                string wlasciciel = wybranyWiersz.Cells[7].Value.ToString();
                comboBox_wlascicielEdytowanegoPacjenta.Text = wlasciciel;
            }
        }
        private void pobierzListeKlientow()
        {
            List<Klient> klienci = WczytywanieKlientow.wczytajKlientowZPliku();
            comboBox_ListaWlascicieli.DataSource = klienci;
            comboBox_ListaWlascicieli.DisplayMember = "imie" + "nazwisko";
            comboBox_wlascicielEdytowanegoPacjenta.DataSource = klienci;
            comboBox_wlascicielEdytowanegoPacjenta.DisplayMember = "imie" + "nazwisko";
        }
        private void ustawieniaDataGridView_listaPacjentow()
        {
            dataGridView_listaPacjentow.Columns.Clear();
            dataGridView_listaPacjentow.Columns.Add("Id", "Id Pacjenta");
            dataGridView_listaPacjentow.Columns.Add("Imie", "Imię Pacjenta");
            dataGridView_listaPacjentow.Columns.Add("Gatunek", "Gatunek");
            dataGridView_listaPacjentow.Columns.Add("Rasa", "Rasa");
            dataGridView_listaPacjentow.Columns.Add("Plec", "Płeć");
            dataGridView_listaPacjentow.Columns.Add("DataUrodzenia", "Data Urodzenia");
            dataGridView_listaPacjentow.Columns.Add("Waga", "Waga");
            dataGridView_listaPacjentow.Columns.Add("Wlasciciel", "Właściciel");
            dataGridView_listaPacjentow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_listaPacjentow.MultiSelect = false; // Możliwość zaznaczania tylko jednego wiersza
            dataGridView_listaPacjentow.ClearSelection(); // Wyczyszczenie zaznaczenia
            dataGridView_listaPacjentow.CurrentCell = null; // Usunięcie zaznaczenia bieżącej komórki
        }
        private void dataGridView_listaPacjentow_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_listaPacjentow.SelectedRows.Count > 0)
            {
                // Jeśli zaznaczony wiersz, włącz przycisk "Edytuj"
                btn_edycjaPacjenta.Enabled = true;
                btn_usuwaniePacjenta.Enabled = true;
            }
            else
            {
                // Jeśli nie ma zaznaczonego wiersza, wyłącz przycisk "Edytuj"
                btn_edycjaPacjenta.Enabled = false;
                btn_usuwaniePacjenta.Enabled = false;
            }
        }
        private void dateTimePicker_DataUrodzeniaPacjenta_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_DataUrodzeniaPacjenta.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DataUrodzeniaPacjenta.CustomFormat = "dd.MM.yyyy";
        }
        private void OgraniczDostepDoKontrolek()
        {
            if (zalogowanyUzytkownik.Rola == "Lekarz")
            {
                btn_DodajPacjenta.Enabled = false;
                btn_UsunPacjenta.Enabled = false;
                btn_EdytujPacjenta.Enabled = false;
            }
            else if (zalogowanyUzytkownik.Rola == "Recepcjonista")
            {
                btn_UsunPacjenta.Enabled = false;
                btn_EdytujPacjenta.Enabled = false;
            }
        }
    }
}

