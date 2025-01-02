using System.Globalization;

namespace Przychodnia
{
    public partial class Menu_Wizyty : Form
    {   
        //Prywatne pole klasy Uzytkownik - zmienna zalogowanyUzytkownik przechowuje aktualnie zalogowanego użytkownika
        private Uzytkownik zalogowanyUzytkownik;
        private string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "wizyty.txt");
        //Konstruktor klasy Menu_Wizyty - przyjmujący obiekt zalogowanego użytkownika
        public Menu_Wizyty(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            ustawieniaDataGridView_listaWizyt();
            this.zalogowanyUzytkownik = uzytkownik;
            OgraniczDostepDoKontrolek();
        }
        //Lista przechowująca wizyty
        private List<Wizyta> wizyty = new List<Wizyta>();
        private void Menu_Wizyty_Load(object sender, EventArgs e)
        {
            dateTimePicker_dataWizyty.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataWizyty.CustomFormat = " "; // Puste pole na starcie
            dateTimePicker_godzinaWizyty.Format = DateTimePickerFormat.Custom;
            dateTimePicker_godzinaWizyty.CustomFormat = " "; // Puste pole na starcie
            dateTimePicker_dataEdytowanejWizyty.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataEdytowanejWizyty.CustomFormat = " "; // Puste pole na starcie
            dateTimePicker_godzinaEdytowanejWizyty.Format = DateTimePickerFormat.Custom;
            dateTimePicker_godzinaEdytowanejWizyty.CustomFormat = " "; // Puste pole na starcie
            OdczytajWizytyZPliku();
            dataGridView_listaWizyt.SelectionChanged += dataGridView_listaWizyt_SelectionChanged;
        }
        private void btn_ListaWizyt_Click(object sender, EventArgs e)
        {
            panel_Wizyty.Visible = false;
            panel_NowaWizyta.Visible = false;
            dataGridView_listaWizyt.Visible = true;
            label_ListaWizyt.Visible = true;
            btn_wrocDoMenuGlownego.Visible = false;
            btn_cofnijDoMenuWizyt.Visible = true;
            btn_edycjaWizyty.Visible = false;
            btn_usuwanieWizyty.Visible = false;
            dataGridView_listaWizyt.ClearSelection();
        }
        private void btn_DodajWizyte_Click(object sender, EventArgs e)
        {
            PobierzListePacjentow();
            PobierzListeLekarzy();
            wyczyscPola();
            label_NowaWizyta.Visible = true;
            panel_Wizyty.Visible = false;
            panel_NowaWizyta.Visible = true;
            dataGridView_listaWizyt.Visible = true;
            label_ListaWizyt.Visible = true;
            btn_wrocDoMenuGlownego.Visible = false;
            btn_cofnijDoMenuWizyt.Visible = true;
            btn_edycjaWizyty.Visible = false;
            btn_usuwanieWizyty.Visible = false;
            dataGridView_listaWizyt.ClearSelection();
            //Automatyczne generowanie Id wizyty
            int idLiczba = wizyty.Count + 1;
            string autoId = idLiczba.ToString();
            textBox_IdWizyty.Text = autoId;
            textBox_IdWizyty.ReadOnly = true;
        }
        private void btn_ZapiszWizyte_Click(object sender, EventArgs e)
        {
            // Pobieranie danych z kontrolek
            string id = textBox_IdWizyty.Text;
            string typWizyty = comboBox_TypWizyty.Text;  // Opis z TextBox
            DateTime dataWizyty = dateTimePicker_dataWizyty.Value;  // Data z DateTimePicker
            DateTime godzinaWizyty = dateTimePicker_godzinaWizyty.Value; // Godzina z DateTimePicker
            string pacjentText = comboBox_Pacjent.Text;
            string wlascicielText = comboBox_wlasciciel.Text;
            string lekarzText = comboBox_lekarz.Text;

            // Rozdzielamy na imię i nazwisko
            string[] daneWlasciciela = wlascicielText.Split(' ');
            if (daneWlasciciela.Length < 2)
            {
                MessageBox.Show("Proszę podać pełne imię i nazwisko.");
                return;
            }
            string imieWlasciciela = daneWlasciciela[0];
            string nazwiskoWlasciciela = daneWlasciciela[1];

            // Rozdzielamy na imię i nazwisko
            string[] daneLekarza = lekarzText.Split(' ');
            if (daneLekarza.Length < 2)
            {
                MessageBox.Show("Proszę podać pełne imię i nazwisko.");
                return;
            }

            string imieLekarza = daneLekarza[0];
            string nazwiskoLekarza = daneLekarza[1];

            Pacjent pacjent = new Pacjent(pacjentText);
            Klient wlasciciel = new Klient(imieWlasciciela, nazwiskoWlasciciela);
            Lekarz lekarz = new Lekarz(imieLekarza, nazwiskoLekarza);

            if (string.IsNullOrWhiteSpace(typWizyty))
            {
                MessageBox.Show("Proszę podać opis wizyty.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }
            // Tworzenie nowej wizyty
            string noweId = Wizyta.GenerujNoweId();
            Wizyta nowaWizyta = new Wizyta(id, typWizyty, dataWizyty, godzinaWizyty, pacjent, wlasciciel, lekarz);

            // Dodanie wizyty do listy
            wizyty.Add(nowaWizyta);
            //Czyszczenie pól formularza
            wyczyscPola();
            //Zwiększenie ID wizyty
            zwiekszIdWizyty();
            wyswietlTabelkaWizyty();
            ZapiszWizytyDoPliku();
        }
        private void btn_EdytujWizyte_Click(object sender, EventArgs e)
        {
            panel_Wizyty.Visible = false;
            dataGridView_listaWizyt.Visible = true;
            label_edytowanieWizyty.Visible = true;
            btn_wrocDoMenuGlownego.Visible = false;
            btn_cofnijDoMenuWizyt.Visible = true;
            btn_edycjaWizyty.Visible = true;
            btn_usuwanieWizyty.Visible = false;
            dataGridView_listaWizyt.ClearSelection();
        }
        private void btn_edycjaWizyty_Click(object sender, EventArgs e)
        {
            comboBox_wlasciciel.Text = string.Empty;
            PobierzListePacjentow();
            PobierzListeLekarzy();
            panel_edycjaWizyty.Visible = true;
            label_EdycjaWizyty.Visible = true;
            pobierzWartosciDoEdycji();
        }
        private void btn_zapiszEdytowanaWizyte_Click(object sender, EventArgs e)
        {
            // Pobieranie danych z kontrolek
            string id = textBox_idEdytowanejWizyty.Text;
            string typWizyty = comboBox_typEdytowanejWizyty.Text;  // Opis z TextBox
            DateTime dataWizyty = dateTimePicker_dataEdytowanejWizyty.Value;  // Data z DateTimePicker
            DateTime godzinaWizyty = dateTimePicker_godzinaEdytowanejWizyty.Value; // Godzina z DateTimePicker
            string pacjentText = comboBox_pacjentEdytowanejWizyty.Text;
            string wlascicielText = comboBox_wlascicielEdytowanejWizyty.Text;
            string lekarzText = comboBox_lekarzEdytowanejWizyty.Text;

            // Rozdzielamy na imię i nazwisko
            string[] daneWlasciciela = wlascicielText.Split(' ');
            if (daneWlasciciela.Length < 2)
            {
                MessageBox.Show("Proszę podać pełne imię i nazwisko.");
                return;
            }
            string imieWlasciciela = daneWlasciciela[0];
            string nazwiskoWlasciciela = daneWlasciciela[1];

            // Rozdzielamy na imię i nazwisko
            string[] daneLekarza = lekarzText.Split(' ');
            if (daneLekarza.Length < 2)
            {
                MessageBox.Show("Proszę podać pełne imię i nazwisko.");
                return;
            }

            string imieLekarza = daneLekarza[0];
            string nazwiskoLekarza = daneLekarza[1];

            Pacjent pacjent = new Pacjent(pacjentText);
            Klient wlasciciel = new Klient(imieWlasciciela, nazwiskoWlasciciela);
            Lekarz lekarz = new Lekarz(imieLekarza, nazwiskoLekarza);

            if (string.IsNullOrWhiteSpace(typWizyty))
            {
                MessageBox.Show("Proszę podać opis wizyty.");
                return; // Zatrzymanie dalszego działania, jeśli opis jest pusty
            }
            Wizyta edytowanaWizyta = null;
            foreach (Wizyta wizyta in wizyty)
            {
                if (wizyta.id == id)
                {
                    edytowanaWizyta = wizyta;
                    break;
                }
            }
            if (edytowanaWizyta != null)
            {
                edytowanaWizyta.typWizyty = typWizyty;
                edytowanaWizyta.dataWizyty = dataWizyty;
                edytowanaWizyta.godzinaWizyty = godzinaWizyty;
                edytowanaWizyta.pacjent = pacjent;
                edytowanaWizyta.wlasciciel = wlasciciel;
                edytowanaWizyta.lekarz = lekarz;
            }
            DialogResult edytujWizyte = MessageBox.Show("Czy na pewno zapisać wybraną wizytę?", "Ostrzeżenie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (edytujWizyte != DialogResult.Yes)
            {
                return;
            }
            //Czyszczenie pól formularza
            dataGridView_listaWizyt.ClearSelection();
            //Zwiększenie ID wizyty
            wyswietlTabelkaWizyty();
            ZapiszWizytyDoPliku();
        }
        private void btn_UsunWizyte_Click(object sender, EventArgs e)
        {
            panel_Wizyty.Visible = false;
            dataGridView_listaWizyt.Visible = true;
            label_ListaWizyt.Visible = false;
            btn_wrocDoMenuGlownego.Visible = false;
            btn_cofnijDoMenuWizyt.Visible = true;
            btn_edycjaWizyty.Visible = false;
            btn_usuwanieWizyty.Visible = true;
            label_usuwanieWizyty.Visible = true;
            dataGridView_listaWizyt.ClearSelection();
        }
        private void btn_usuwanieWizyty_Click(object sender, EventArgs e)
        {
            DataGridViewRow wybranaWizyta = dataGridView_listaWizyt.SelectedRows[0];
            string idWizyty = wybranaWizyta.Cells["id"].Value.ToString();
            Wizyta wizytaDoUsuniecia = null;
            foreach (Wizyta wizyta in wizyty)
            {
                if (wizyta.id == idWizyty)
                {
                    wizytaDoUsuniecia = wizyta;
                    break;
                }
            }
            DialogResult usunWizyte = MessageBox.Show("Czy na pewno chcesz usunąć wybraną wizytę?", "Ostrzeżenie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (usunWizyte != DialogResult.Yes)
            {
                return;
            }
            wizyty.Remove(wizytaDoUsuniecia);
            dataGridView_listaWizyt.ClearSelection();
            foreach (Wizyta wizyta in wizyty)
            {
                // Zmniejsz numer ID o 1 dla wizyt po usuniętej
                int id = int.Parse(wizyta.id);
                if (id > int.Parse(idWizyty))
                {
                    id--;
                    wizyta.id = id.ToString();
                }
            }
            // Odśwież widok tabeli
            wyswietlTabelkaWizyty();
            // Zapisz zmiany do pliku
            ZapiszWizytyDoPliku();
        }
        private void btn_cofnijDoMenuWizyt_Click(object sender, EventArgs e)
        {
            label_NowaWizyta.Visible = false;
            panel_Wizyty.Visible = true;
            panel_NowaWizyta.Visible = false;
            dataGridView_listaWizyt.Visible = false;
            label_ListaWizyt.Visible = false;
            btn_wrocDoMenuGlownego.Visible = true;
            btn_cofnijDoMenuWizyt.Visible = false;
            btn_edycjaWizyty.Visible = false;
            panel_edycjaWizyty.Visible = false;
            label_EdycjaWizyty.Visible = false;
            btn_usuwanieWizyty.Visible = false;
            label_usuwanieWizyty.Visible = false;
            label_edytowanieWizyty.Visible = false;
        }
        private void btn_wrocDoMenuGlownego_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void ZapiszWizytyDoPliku()
        {
            // Przygotowanie listy danych wizyt w formacie tekstowym
            var wizytyText = new List<string>();
            wizytyText.Add("IdWizyty-TypWizyty-DataWizyty-GodzinaWizyty-Pacjent-Wlasciciel-Lekarz"); // Nagłówek

            foreach (var wizyta in wizyty)
            {
                // Tworzymy wiersz dla każdej wizyty
                string wizytaText = $"{wizyta.id}-{wizyta.typWizyty}-{wizyta.dataWizyty:dd.MM.yyyy}-{wizyta.godzinaWizyty:HH:mm}-" +
                                    $"{wizyta.pacjent}-{wizyta.wlasciciel.imie} {wizyta.wlasciciel.nazwisko}-" +
                                    $"{wizyta.lekarz.imie} {wizyta.lekarz.nazwisko}";
                wizytyText.Add(wizytaText);
            }

            // Zapisujemy całą listę wizyt do pliku
            File.WriteAllLines(sciezkaPliku, wizytyText);
            dataGridView_listaWizyt.ClearSelection();
        }
        private void OdczytajWizytyZPliku()
        {
            // Odczytujemy wszystkie linie z pliku
            string[] linie = File.ReadAllLines(sciezkaPliku);
            for (int i = 1; i < linie.Length; i++)
            {
                string linia = linie[i];
                string[] dane = linia.Split('-');

                if (dane.Length == 7)
                {
                    string id = dane[0];
                    DateTime dataWizyty = DateTime.ParseExact(dane[2], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    DateTime godzinaWizyty = DateTime.ParseExact(dane[3], "HH:mm", CultureInfo.InvariantCulture);
                    Pacjent pacjent = new Pacjent(dane[4]);
                    Klient wlasciciel = new Klient(dane[5].Split(' ')[0], dane[5].Split(' ')[1]);
                    Lekarz lekarz = new Lekarz(dane[6].Split(' ')[0], dane[6].Split(' ')[1]);
                    Wizyta wizyta = new Wizyta(id, dane[1], dataWizyty, godzinaWizyty, pacjent, wlasciciel, lekarz);
                    wizyty.Add(wizyta);
                }
            }
            // Po załadowaniu wizyt z pliku, zaktualizuj DataGridView
            wyswietlTabelkaWizyty();
        }
        private void wyczyscPola()
        {
            comboBox_TypWizyty.SelectedIndex = -1;
            dateTimePicker_dataWizyty.CustomFormat = " ";
            dateTimePicker_godzinaWizyty.CustomFormat = " ";
            comboBox_Pacjent.SelectedIndex = -1;
            comboBox_wlasciciel.Text = string.Empty;
            comboBox_lekarz.SelectedIndex = -1;
            textBox_idEdytowanejWizyty.Text = string.Empty;
            comboBox_typEdytowanejWizyty.SelectedIndex = -1;
            dateTimePicker_dataEdytowanejWizyty.CustomFormat = " ";
            dateTimePicker_godzinaEdytowanejWizyty.CustomFormat = " ";
            comboBox_pacjentEdytowanejWizyty.SelectedIndex = -1;
            comboBox_wlascicielEdytowanejWizyty.Text = string.Empty;
            comboBox_lekarzEdytowanejWizyty.SelectedIndex = -1;
        }
        private void zwiekszIdWizyty()
        {
            int maxNumerWizyty = 0;
            foreach (Wizyta wizyta in wizyty)
            {
                int id = int.Parse(wizyta.id);
                if (id > maxNumerWizyty)
                {
                    maxNumerWizyty = id;
                }
            }
            // Nowe ID to maksymalny numer + 1
            string newId = (maxNumerWizyty + 1).ToString();
            textBox_IdWizyty.Text = newId;
        }
        private void SortujWizyty()
        {
            // Używamy klasycznej metody porównania
            for (int i = 0; i < wizyty.Count - 1; i++)
            {
                for (int j = i + 1; j < wizyty.Count; j++)
                {
                    // Porównanie dat
                    int porownanieDat = wizyty[i].dataWizyty.Date.CompareTo(wizyty[j].dataWizyty.Date);

                    // Jeśli daty są równe, porównaj godziny
                    if (porownanieDat == 0)
                    {
                        // Porównanie godzin
                        int porownanieGodzin = wizyty[i].godzinaWizyty.TimeOfDay.CompareTo(wizyty[j].godzinaWizyty.TimeOfDay);

                        // Jeśli godzina i data są takie same, nie robimy nic
                        if (porownanieGodzin > 0)
                        {
                            // Zamiana miejscami
                            Wizyta temp = wizyty[i];
                            wizyty[i] = wizyty[j];
                            wizyty[j] = temp;
                        }
                    }
                    else if (porownanieDat > 0)
                    {
                        // Jeśli data jest późniejsza, zamieniamy
                        Wizyta temp = wizyty[i];
                        wizyty[i] = wizyty[j];
                        wizyty[j] = temp;
                    }
                }
            }
        }
        private void wyswietlTabelkaWizyty()
        {
            // Czyścimy istniejące dane w tabelce
            dataGridView_listaWizyt.Rows.Clear();
            SortujWizyty();
            // Dodajemy wiersze na podstawie listy wizyt
            foreach (var wizyta in wizyty)
            {
                dataGridView_listaWizyt.Rows.Add(
                    wizyta.id,
                    wizyta.typWizyty,
                    wizyta.dataWizyty.ToString("dd.MM.yyyy"),
                    wizyta.godzinaWizyty.ToString("HH:mm"),
                    wizyta.pacjent,
                    wizyta.wlasciciel,
                    wizyta.lekarz
                    );
            }
        }
        private void pobierzWartosciDoEdycji()
        {
            if (dataGridView_listaWizyt.SelectedRows.Count > 0)
            {
                DataGridViewRow wybranyWiersz = dataGridView_listaWizyt.SelectedRows[0];
                string id = wybranyWiersz.Cells[0].Value.ToString();
                textBox_idEdytowanejWizyty.Text = id;
                string typWizyty = wybranyWiersz.Cells[1].Value.ToString();
                comboBox_typEdytowanejWizyty.Text = typWizyty;
                string dataWizytyText = wybranyWiersz.Cells[2].Value.ToString();
                DateTime.TryParse(dataWizytyText, out DateTime dataWizyty);
                dateTimePicker_dataEdytowanejWizyty.Value = dataWizyty;
                string godzinaWizytyText = wybranyWiersz.Cells[3].Value.ToString();
                DateTime.TryParse(godzinaWizytyText, out DateTime godzinaWizyty);
                dateTimePicker_godzinaEdytowanejWizyty.Value = godzinaWizyty;
                string pacjent = wybranyWiersz.Cells[4].Value.ToString();
                comboBox_pacjentEdytowanejWizyty.Text = pacjent;
                string wlasciciel = wybranyWiersz.Cells[5].Value.ToString();
                comboBox_wlascicielEdytowanejWizyty.Text = wlasciciel;
                string lekarz = wybranyWiersz.Cells[6].Value.ToString();
                comboBox_lekarzEdytowanejWizyty.Text = lekarz;
            }
        }
        private void PobierzListePacjentow()
        {
            List<Pacjent> pacjenci = WczytywaniePacjentow.WczytajPacjentowIWlascicieli();
            comboBox_Pacjent.DataSource = pacjenci;
            comboBox_Pacjent.DisplayMember = "imie";  // Wyświetlanie imienia pacjenta
            comboBox_pacjentEdytowanejWizyty.DataSource = pacjenci;
            comboBox_pacjentEdytowanejWizyty.DisplayMember = "imie";  // Wyświetlanie imienia pacjenta
        }
        private void PobierzListeLekarzy()
        {
            List<Lekarz> lekarze = WczytywanieLekarzy.wczytajLekarzyZPliku();
            comboBox_lekarz.DataSource = lekarze;
            comboBox_lekarz.DisplayMember = "imie" + "nazwisko";  // Wyświetlanie imienia pacjenta
            comboBox_lekarzEdytowanejWizyty.DataSource = lekarze;
            comboBox_lekarzEdytowanejWizyty.DisplayMember = "imie" + "nazwisko";  // Wyświetlanie imienia pacjenta
        }
        private void ustawieniaDataGridView_listaWizyt()
        {
            dataGridView_listaWizyt.Columns.Clear();
            dataGridView_listaWizyt.Columns.Add("Id", "Numer Wizyty");
            dataGridView_listaWizyt.Columns.Add("TypWizyty", "Typ Wizyty");
            dataGridView_listaWizyt.Columns.Add("DataWizyty", "Data Wizyty");
            dataGridView_listaWizyt.Columns.Add("GodzinaWizyty", "Godzina Wizyty");
            dataGridView_listaWizyt.Columns.Add("Pacjent", "Pacjent");
            dataGridView_listaWizyt.Columns.Add("Wlasciciel", "Właściciel");
            dataGridView_listaWizyt.Columns.Add("Lekarz", "Lekarz");
            dataGridView_listaWizyt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_listaWizyt.MultiSelect = false; // Możliwość zaznaczania tylko jednego wiersza
            dataGridView_listaWizyt.ClearSelection(); // Wyczyszczenie zaznaczenia
            dataGridView_listaWizyt.CurrentCell = null; // Usunięcie zaznaczenia bieżącej komórki
        }
        private void dataGridView_listaWizyt_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_listaWizyt.SelectedRows.Count > 0)
            {
                // Jeśli zaznaczony wiersz, włącz przycisk "Edytuj"
                btn_edycjaWizyty.Enabled = true;
                btn_usuwanieWizyty.Enabled = true;
            }
            else
            {
                // Jeśli nie ma zaznaczonego wiersza, wyłącz przycisk "Edytuj"
                btn_edycjaWizyty.Enabled = false;
                btn_usuwanieWizyty.Enabled = false;
            }
        }
        private void dateTimePicker_dataWizyty_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_dataWizyty.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataWizyty.CustomFormat = "dd.MM.yyyy";
            dateTimePicker_godzinaWizyty.CustomFormat = "HH:mm";
        }
        private void dateTimePicker_dataEdytowanejWizyty_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_dataEdytowanejWizyty.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataEdytowanejWizyty.CustomFormat = "dd.MM.yyyy";
            dateTimePicker_godzinaEdytowanejWizyty.CustomFormat = "HH:mm";
        }
        private void comboBox_Pacjent_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_wlasciciel.SelectedItem = null;
            comboBox_wlasciciel.DisplayMember = "ToString";
            // Pobierz wybranego pacjenta z comboBox
            Pacjent wybranyPacjent = comboBox_Pacjent.SelectedItem as Pacjent;
            comboBox_wlasciciel.SelectedItem = null;
            comboBox_wlasciciel.DisplayMember = "ToString";
            if (wybranyPacjent != null && wybranyPacjent.wlasciciel != null)
            {
                // Ustaw właściciela w odpowiednim polu formularza (np. TextBox)
                comboBox_wlasciciel.Text = wybranyPacjent.wlasciciel.ToString();
                comboBox_wlascicielEdytowanejWizyty.Text = wybranyPacjent.wlasciciel.ToString();
            }
        }
        private void OgraniczDostepDoKontrolek()
        {
            // Sprawdzamy rolę użytkownika
            if (zalogowanyUzytkownik.Rola == "Lekarz")
            {
                // Jeśli użytkownik nie jest administratorem, wyłączamy przycisk usuwania wizyty
                btn_DodajWizyte.Enabled = false;
                btn_UsunWizyte.Enabled = false;
            }
        }
        public class WczytywanieKlientow
        {
            public static List<Klient> wczytajKlientowZPliku()
            {
                List<Klient> klienci = new List<Klient>();
                string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "klienci.txt");
                string[] klienciText = File.ReadAllLines(sciezkaPliku);
                for (int i = 1; i < klienciText.Length; i++)
                {
                    string k = klienciText[i];
                    string[] nazwaKlienta = k.Split('-');

                    if (nazwaKlienta.Length == 7)
                    {
                        string imie = nazwaKlienta[1];
                        string nazwisko = nazwaKlienta[2];
                        Klient klient = new Klient(imie, nazwisko);
                        klienci.Add(klient);
                    }
                }
                return klienci;
            }
        }
        public class WczytywanieLekarzy
        {
            public static List<Lekarz> wczytajLekarzyZPliku()
            {
                List<Lekarz> lekarze = new List<Lekarz>();
                string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "lekarze.txt");
                string[] lekarzeText = File.ReadAllLines(sciezkaPliku);
                for (int i = 1; i < lekarzeText.Length; i++)
                {
                    string l = lekarzeText[i];
                    string[] nazwaLekarza = l.Split('-');

                    if (nazwaLekarza.Length == 7)
                    {
                        string imie = nazwaLekarza[1];
                        string nazwisko = nazwaLekarza[2];
                        Lekarz lekarz = new Lekarz(imie, nazwisko);
                        lekarze.Add(lekarz);
                    }
                }
                return lekarze;
            }
        }
        public class WczytywaniePacjentow
        {
            public static List<Pacjent> WczytajPacjentowIWlascicieli()
            {
                List<Pacjent> pacjenci = new List<Pacjent>();
                string sciezkaPliku = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Baza danych", "pacjenci.txt");
                string[] pacjenciText = File.ReadAllLines(sciezkaPliku);

                for (int i = 1; i < pacjenciText.Length; i++) // Pomijamy nagłówek
                {
                    string[] dane = pacjenciText[i].Split('-');
                    if (dane.Length == 8)
                    {
                        string idPacjenta = dane[0];
                        string imiePacjenta = dane[1];
                        string nazwaWlasciciela = dane[7];

                        // Tworzymy obiekt właściciela
                        Klient wlasciciel = new Klient(nazwaWlasciciela);

                        // Tworzymy obiekt pacjenta i przypisujemy właściciela
                        Pacjent pacjent = new Pacjent(idPacjenta, imiePacjenta, wlasciciel);
                        pacjenci.Add(pacjent);
                    }
                }
                return pacjenci;
            }
        }
    }
}
