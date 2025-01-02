
namespace Przychodnia
{
    public partial class Menu_Lekarze : Form
    {
        private Uzytkownik zalogowanyUzytkownik;
        private string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "lekarze.txt");
        public Menu_Lekarze(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            ustawieniaDataGridView_listaLekarzy();
            this.zalogowanyUzytkownik = uzytkownik;
            OgraniczDostepDoKontrolek();
        }
        public List<Lekarz> lekarze = new List<Lekarz>();
        private void Menu_Lekarze_Load(object sender, EventArgs e)
        {
            OdczytajLekarzyZPliku();
            dataGridView_listaLekarzy.SelectionChanged += dataGridView_listaLekarzy_SelectionChanged;
        }
        private void btn_ListaLekarzy_Click(object sender, EventArgs e)
        {
            panel_Lekarze.Visible = false;
            dataGridView_listaLekarzy.Visible = true;
            btn_cofnijDoMenuLekarzy.Visible = true;
            label_listaLekarzy.Visible = true;
            dataGridView_listaLekarzy.ClearSelection();
        }
        private void btn_DodajLekarza_Click(object sender, EventArgs e)
        {
            panel_DodajLekarza.Visible = true;
            dataGridView_listaLekarzy.Visible = true;
            panel_Lekarze.Visible = false;
            label_listaLekarzy.Visible = true;
            btn_cofnijDoMenuLekarzy.Visible = true;
            dataGridView_listaLekarzy.ClearSelection();
            int id = lekarze.Count + 1;
            string autoId = id.ToString();
            textBox_idLekarza.Text = autoId;
            textBox_idLekarza.ReadOnly = true;
        }
        private void btn_zapiszLekarza_Click(object sender, EventArgs e)
        {
            string id = textBox_idLekarza.Text;
            string imie = textBox_imieLekarza.Text;
            string nazwisko = textBox_nazwiskoLekarza.Text;
            string plec = comboBox_plecLekarza.Text;
            string specjalizacja = comboBox_specjalizacjaLekarza.Text;
            string nrTelefonu = textBox_nrTelefonuLekarza.Text;
            string mail = textBox_mailLekarza.Text;

            if (string.IsNullOrWhiteSpace(plec))
            {
                MessageBox.Show("Proszę wybrać płeć lekarza.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }

            string noweId = Lekarz.GenerujNoweId();
            Lekarz nowyLekarz = new Lekarz(id, imie, nazwisko, plec, specjalizacja, nrTelefonu, mail);

            // Dodanie wizyty do listy
            lekarze.Add(nowyLekarz);
            wyczyscPola();
            //Zwiększenie ID wizyty
            zwiekszIdLekarza();
            wyswietlTabelkaLekarzy();
            ZapiszLekarzyDoPliku();
        }
        private void btn_EdytujLekarza_Click(object sender, EventArgs e)
        {
            panel_edycjaLekarza.Visible = true;
            dataGridView_listaLekarzy.Visible = true;
            btn_edytowanieLekarza.Visible = true;
            btn_cofnijDoMenuLekarzy.Visible = true;
            panel_Lekarze.Visible = false;
            label_edytujLekarza.Visible = true;
            label_lekarzDoEdycji.Visible = true;
            dataGridView_listaLekarzy.ClearSelection();
        }
        private void btn_edytowanieLekarza_Click(object sender, EventArgs e)
        {
            pobierzWartosciDoEdycji();
        }
        private void btn_zapiszEdytowanegoLekarza_Click(object sender, EventArgs e)
        {
            string id = textBox_idEdytowanegoLekarza.Text;
            string imie = textBox_imieEdytowanegoLekarza.Text;
            string nazwisko = textBox_nazwiskoEdytowanegoLekarza.Text;
            string plec = comboBox_plecEdytowanegoLekarza.Text;
            string specjalizacja = comboBox_specjalizacjaEdytowanegoLekarza.Text;
            string nrTelefonu = textBox_nrTelefonuEdytowanegoLekarza.Text;
            string mail = textBox_mailEdytowanegoLekarza.Text;
            if (string.IsNullOrWhiteSpace(plec))
            {
                MessageBox.Show("Proszę wybrać płeć lekarza.");
                return;
            }
            Lekarz edytowanyLekarz = null;
            foreach (Lekarz lekarz in lekarze)
            {
                if (lekarz.id == id)
                {
                    edytowanyLekarz = lekarz;
                    break;
                }
            }
            if (edytowanyLekarz != null)
            {
                edytowanyLekarz.imie = imie;
                edytowanyLekarz.nazwisko = nazwisko;
                edytowanyLekarz.plec = plec;
                edytowanyLekarz.specjalizacja = specjalizacja;
                edytowanyLekarz.nrTelefonu = nrTelefonu;
                edytowanyLekarz.mail = mail;
            }
            wyczyscPola();
            wyswietlTabelkaLekarzy();
            ZapiszLekarzyDoPliku();
        }
        private void btn_UsunLekarza_Click(object sender, EventArgs e)
        {
            dataGridView_listaLekarzy.Visible = true;
            btn_usuwanieLekarza.Visible = true;
            panel_Lekarze.Visible = false;
            label_usuwanieLekarza.Visible = true;
            btn_cofnijDoMenuLekarzy.Visible = true;
            dataGridView_listaLekarzy.ClearSelection();
        }
        private void btn_usuwanieLekarza_Click(object sender, EventArgs e)
        {
            DataGridViewRow wybranyLekarz = dataGridView_listaLekarzy.SelectedRows[0];
            string idLekarza = wybranyLekarz.Cells["id"].Value.ToString();
            Lekarz lekarzDoUsuniecia = null;
            foreach (Lekarz lekarz in lekarze)
            {
                if (lekarz.id == idLekarza)
                {
                    lekarzDoUsuniecia = lekarz;
                    break;
                }
            }
            DialogResult usunLekarza = MessageBox.Show("Czy na pewno chcesz usunąć wybranego lekarza?", "Ostrzeżenie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (usunLekarza != DialogResult.Yes)
            {
                return;
            }
            lekarze.Remove(lekarzDoUsuniecia);
            dataGridView_listaLekarzy.ClearSelection();
            foreach (Lekarz lekarz in lekarze)
            {
                // Zmniejsz numer ID o 1 dla wizyt po usuniętej
                string idText = lekarz.id;
                int id = int.Parse(idText);
                if (id > int.Parse(idLekarza))
                {
                    id--;
                    lekarz.id = id.ToString();
                }
            }
            // Odśwież widok tabeli
            wyswietlTabelkaLekarzy();
            // Zapisz zmiany do pliku
            ZapiszLekarzyDoPliku();
        }
        private void btn_cofnijDoMenuLekarzy_Click(object sender, EventArgs e)
        {
            panel_Lekarze.Visible = true;
            panel_DodajLekarza.Visible = false;
            panel_edycjaLekarza.Visible = false;
            btn_usuwanieLekarza.Visible = false;
            btn_edytowanieLekarza.Visible = false;
            label_lekarzDoEdycji.Visible = false;
            label_listaLekarzy.Visible = false;
            dataGridView_listaLekarzy.Visible = false;
            btn_cofnijDoMenuLekarzy.Visible = false;
            label_edytujLekarza.Visible = false;
            label_usuwanieLekarza.Visible = false;
        }
        private void btn_wrocDoMenuGlownego_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ZapiszLekarzyDoPliku()
        {
            // Przygotowanie listy danych wizyt w formacie tekstowym
            var lekarzeText = new List<string>();
            lekarzeText.Add("Id-Imie-Nazwisko-Plec-Specjalizacja-NrTelefonu-Email"); // Nagłówek

            foreach (var lekarz in lekarze)
            {
                // Tworzymy wiersz dla każdego pacjenta
                string lekarzText = $"{lekarz.id}-{lekarz.imie}-{lekarz.nazwisko}-{lekarz.plec}-" +
                                    $"{lekarz.specjalizacja}-{lekarz.nrTelefonu}-{lekarz.mail}";
                lekarzeText.Add(lekarzText);
            }

            // Zapisujemy całą listę wizyt do pliku
            File.WriteAllLines(sciezkaPliku, lekarzeText);
        }
        private void OdczytajLekarzyZPliku()
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
                    string specjalizacja = dane[4];
                    string nrTelefonu = dane[5];
                    string mail = dane[6];
                    Lekarz lekarz = new Lekarz(id, imie, nazwisko, plec, specjalizacja, nrTelefonu, mail);
                    lekarze.Add(lekarz);
                }
            }
            // Po załadowaniu wizyt z pliku, zaktualizuj DataGridView
            wyswietlTabelkaLekarzy();
        }
        private void wyczyscPola()
        {
            textBox_imieLekarza.Text = string.Empty;
            textBox_nazwiskoLekarza.Text = string.Empty;
            comboBox_plecLekarza.SelectedIndex = -1;
            comboBox_specjalizacjaLekarza.SelectedIndex = -1;
            textBox_nrTelefonuLekarza.Text = string.Empty;
            textBox_mailLekarza.Text = string.Empty;
            textBox_idEdytowanegoLekarza.Text = string.Empty;
            textBox_imieEdytowanegoLekarza.Text = string.Empty;
            textBox_nazwiskoEdytowanegoLekarza.Text = string.Empty;
            comboBox_plecEdytowanegoLekarza.SelectedIndex = -1;
            comboBox_specjalizacjaEdytowanegoLekarza.SelectedIndex = -1;
            textBox_nrTelefonuEdytowanegoLekarza.Text = string.Empty;
            textBox_mailEdytowanegoLekarza.Text = string.Empty;
            dataGridView_listaLekarzy.ClearSelection();
        }
        private void zwiekszIdLekarza()
        {
            int maxNumerWizyty = 0;
            foreach (Lekarz lekarz in lekarze)
            {
                string idText = lekarz.id;
                int id = int.Parse(idText);
                if (id > maxNumerWizyty)
                {
                    maxNumerWizyty = id;
                }
            }
            // Nowe ID to maksymalny numer + 1
            string newId = (maxNumerWizyty + 1).ToString();
            textBox_idLekarza.Text = newId;
        }
        private void wyswietlTabelkaLekarzy()
        {
            // Czyścimy istniejące dane w tabelce
            dataGridView_listaLekarzy.Rows.Clear();

            // Dodajemy wiersze na podstawie listy wizyt
            foreach (var lekarz in lekarze)
            {
                dataGridView_listaLekarzy.Rows.Add(
                    lekarz.id,
                    lekarz.imie,
                    lekarz.nazwisko,
                    lekarz.plec,
                    lekarz.specjalizacja,
                    lekarz.nrTelefonu,
                    lekarz.mail
                    );
            }
        }
        private void pobierzWartosciDoEdycji()
        {
            if (dataGridView_listaLekarzy.SelectedRows.Count > 0)
            {
                DataGridViewRow wybranyWiersz = dataGridView_listaLekarzy.SelectedRows[0];
                string id = wybranyWiersz.Cells[0].Value.ToString();
                textBox_idEdytowanegoLekarza.Text = id;
                string imie = wybranyWiersz.Cells[1].Value.ToString();
                textBox_imieEdytowanegoLekarza.Text = imie;
                string nazwisko = wybranyWiersz.Cells[2].Value.ToString();
                textBox_nazwiskoEdytowanegoLekarza.Text = nazwisko;
                string plec = wybranyWiersz.Cells[3].Value.ToString();
                comboBox_plecEdytowanegoLekarza.Text = plec;
                string specjalizacja = wybranyWiersz.Cells[4].Value.ToString();
                comboBox_specjalizacjaEdytowanegoLekarza.Text = specjalizacja;
                string nrTelefonu = wybranyWiersz.Cells[5].Value.ToString();
                textBox_nrTelefonuEdytowanegoLekarza.Text = nrTelefonu;
                string mail = wybranyWiersz.Cells[6].Value.ToString();
                textBox_mailEdytowanegoLekarza.Text = mail;
            }
        }
        private void ustawieniaDataGridView_listaLekarzy()
        {
            dataGridView_listaLekarzy.Columns.Clear();
            dataGridView_listaLekarzy.Columns.Add("Id", "Id");
            dataGridView_listaLekarzy.Columns.Add("Imie", "Imię");
            dataGridView_listaLekarzy.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView_listaLekarzy.Columns.Add("Plec", "Płeć");
            dataGridView_listaLekarzy.Columns.Add("Specjalizacja", "Specjalizacja");
            dataGridView_listaLekarzy.Columns.Add("Nr telefonu", "Nr telefonu");
            dataGridView_listaLekarzy.Columns.Add("E-mail", "E-mail");
            dataGridView_listaLekarzy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_listaLekarzy.MultiSelect = false; // Możliwość zaznaczania tylko jednego wiersza
            dataGridView_listaLekarzy.ClearSelection(); // Wyczyszczenie zaznaczenia
            dataGridView_listaLekarzy.CurrentCell = null; // Usunięcie zaznaczenia bieżącej komórki
        }
        private void dataGridView_listaLekarzy_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_listaLekarzy.SelectedRows.Count > 0)
            {
                // Jeśli zaznaczony wiersz, włącz przycisk "Edytuj"
                btn_edytowanieLekarza.Enabled = true;
                btn_usuwanieLekarza.Enabled = true;
            }
            else
            {
                // Jeśli nie ma zaznaczonego wiersza, wyłącz przycisk "Edytuj"
                btn_edytowanieLekarza.Enabled = false;
                btn_usuwanieLekarza.Enabled = false;

            }
        }
        private void OgraniczDostepDoKontrolek()
        {
            if (zalogowanyUzytkownik.Rola != "Administrator" && zalogowanyUzytkownik.Rola != "Kierownik przychodni")
            {
                btn_DodajLekarza.Enabled = false;
                btn_EdytujLekarza.Enabled = false;
                btn_UsunLekarza.Enabled = false;
            }
        }
    }
}
