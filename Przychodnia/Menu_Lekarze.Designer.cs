namespace Przychodnia
{
    partial class Menu_Lekarze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label_VetAnimal = new Label();
            btn_wrocDoMenuGlownego = new Button();
            panel_Lekarze = new Panel();
            btn_ListaLekarzy = new Button();
            btn_UsunLekarza = new Button();
            btn_EdytujLekarza = new Button();
            btn_DodajLekarza = new Button();
            panel_DodajLekarza = new Panel();
            comboBox_specjalizacjaLekarza = new ComboBox();
            textBox_nrTelefonuLekarza = new TextBox();
            textBox_nazwiskoLekarza = new TextBox();
            comboBox_plecLekarza = new ComboBox();
            textBox_idLekarza = new TextBox();
            label_idLekarza = new Label();
            label_NowyLekarz = new Label();
            label_imieLekarza = new Label();
            textBox_imieLekarza = new TextBox();
            btn_zapiszLekarza = new Button();
            label_nazwiskoLekarza = new Label();
            textBox_mailLekarza = new TextBox();
            label_mailLekarza = new Label();
            label_specjalizacjaLekarza = new Label();
            label_plecLekarza = new Label();
            label_nrTelefonuLekarza = new Label();
            panel_edycjaLekarza = new Panel();
            comboBox_specjalizacjaEdytowanegoLekarza = new ComboBox();
            textBox_nrTelefonuEdytowanegoLekarza = new TextBox();
            textBox_nazwiskoEdytowanegoLekarza = new TextBox();
            comboBox_plecEdytowanegoLekarza = new ComboBox();
            textBox_idEdytowanegoLekarza = new TextBox();
            label_idEdytowanegoLekarza = new Label();
            label_edytujLekarza = new Label();
            label_imieEdytowanegoLekarza = new Label();
            textBox_imieEdytowanegoLekarza = new TextBox();
            btn_zapiszEdytowanegoLekarza = new Button();
            label_nazwiskoEdytowanegoLekarza = new Label();
            textBox_mailEdytowanegoLekarza = new TextBox();
            label_mailEdytowanegoLekarza = new Label();
            label_specjalizacjaEdytowanegoLekarza = new Label();
            label_plecEdytowanegoLekarza = new Label();
            label_nrtelefonuEdytowanegoLekarza = new Label();
            dataGridView_listaLekarzy = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label_listaLekarzy = new Label();
            btn_edytowanieLekarza = new Button();
            btn_usuwanieLekarza = new Button();
            btn_cofnijDoMenuLekarzy = new Button();
            label_lekarzDoEdycji = new Label();
            label_usuwanieLekarza = new Label();
            panel_Lekarze.SuspendLayout();
            panel_DodajLekarza.SuspendLayout();
            panel_edycjaLekarza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_listaLekarzy).BeginInit();
            SuspendLayout();
            // 
            // label_VetAnimal
            // 
            label_VetAnimal.BackColor = SystemColors.HotTrack;
            label_VetAnimal.Dock = DockStyle.Left;
            label_VetAnimal.Font = new Font("Sitka Banner", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_VetAnimal.Location = new Point(0, 0);
            label_VetAnimal.Name = "label_VetAnimal";
            label_VetAnimal.Size = new Size(321, 885);
            label_VetAnimal.TabIndex = 3;
            label_VetAnimal.Text = "VetAnimal";
            label_VetAnimal.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_wrocDoMenuGlownego
            // 
            btn_wrocDoMenuGlownego.BackColor = SystemColors.Highlight;
            btn_wrocDoMenuGlownego.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_wrocDoMenuGlownego.ForeColor = SystemColors.ButtonFace;
            btn_wrocDoMenuGlownego.ImageAlign = ContentAlignment.TopCenter;
            btn_wrocDoMenuGlownego.Location = new Point(95, 100);
            btn_wrocDoMenuGlownego.Name = "btn_wrocDoMenuGlownego";
            btn_wrocDoMenuGlownego.Size = new Size(129, 34);
            btn_wrocDoMenuGlownego.TabIndex = 36;
            btn_wrocDoMenuGlownego.Text = "Menu Główne";
            btn_wrocDoMenuGlownego.UseVisualStyleBackColor = false;
            btn_wrocDoMenuGlownego.Click += btn_wrocDoMenuGlownego_Click;
            // 
            // panel_Lekarze
            // 
            panel_Lekarze.Controls.Add(btn_ListaLekarzy);
            panel_Lekarze.Controls.Add(btn_UsunLekarza);
            panel_Lekarze.Controls.Add(btn_EdytujLekarza);
            panel_Lekarze.Controls.Add(btn_DodajLekarza);
            panel_Lekarze.Location = new Point(339, 23);
            panel_Lekarze.Name = "panel_Lekarze";
            panel_Lekarze.Size = new Size(772, 224);
            panel_Lekarze.TabIndex = 37;
            // 
            // btn_ListaLekarzy
            // 
            btn_ListaLekarzy.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_ListaLekarzy.Location = new Point(3, 4);
            btn_ListaLekarzy.Name = "btn_ListaLekarzy";
            btn_ListaLekarzy.Size = new Size(367, 94);
            btn_ListaLekarzy.TabIndex = 1;
            btn_ListaLekarzy.Text = "Lista lekarzy";
            btn_ListaLekarzy.UseVisualStyleBackColor = true;
            btn_ListaLekarzy.Click += btn_ListaLekarzy_Click;
            // 
            // btn_UsunLekarza
            // 
            btn_UsunLekarza.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_UsunLekarza.Location = new Point(397, 126);
            btn_UsunLekarza.Name = "btn_UsunLekarza";
            btn_UsunLekarza.Size = new Size(367, 94);
            btn_UsunLekarza.TabIndex = 4;
            btn_UsunLekarza.Text = "Usuń lekarza";
            btn_UsunLekarza.UseVisualStyleBackColor = true;
            btn_UsunLekarza.Click += btn_UsunLekarza_Click;
            // 
            // btn_EdytujLekarza
            // 
            btn_EdytujLekarza.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_EdytujLekarza.Location = new Point(5, 126);
            btn_EdytujLekarza.Name = "btn_EdytujLekarza";
            btn_EdytujLekarza.Size = new Size(367, 94);
            btn_EdytujLekarza.TabIndex = 3;
            btn_EdytujLekarza.Text = "Edytuj lekarza";
            btn_EdytujLekarza.UseVisualStyleBackColor = true;
            btn_EdytujLekarza.Click += btn_EdytujLekarza_Click;
            // 
            // btn_DodajLekarza
            // 
            btn_DodajLekarza.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_DodajLekarza.Location = new Point(397, 4);
            btn_DodajLekarza.Name = "btn_DodajLekarza";
            btn_DodajLekarza.Size = new Size(367, 94);
            btn_DodajLekarza.TabIndex = 2;
            btn_DodajLekarza.Text = "Dodaj lekarza";
            btn_DodajLekarza.UseVisualStyleBackColor = true;
            btn_DodajLekarza.Click += btn_DodajLekarza_Click;
            // 
            // panel_DodajLekarza
            // 
            panel_DodajLekarza.Controls.Add(comboBox_specjalizacjaLekarza);
            panel_DodajLekarza.Controls.Add(textBox_nrTelefonuLekarza);
            panel_DodajLekarza.Controls.Add(textBox_nazwiskoLekarza);
            panel_DodajLekarza.Controls.Add(comboBox_plecLekarza);
            panel_DodajLekarza.Controls.Add(textBox_idLekarza);
            panel_DodajLekarza.Controls.Add(label_idLekarza);
            panel_DodajLekarza.Controls.Add(label_NowyLekarz);
            panel_DodajLekarza.Controls.Add(label_imieLekarza);
            panel_DodajLekarza.Controls.Add(textBox_imieLekarza);
            panel_DodajLekarza.Controls.Add(btn_zapiszLekarza);
            panel_DodajLekarza.Controls.Add(label_nazwiskoLekarza);
            panel_DodajLekarza.Controls.Add(textBox_mailLekarza);
            panel_DodajLekarza.Controls.Add(label_mailLekarza);
            panel_DodajLekarza.Controls.Add(label_specjalizacjaLekarza);
            panel_DodajLekarza.Controls.Add(label_plecLekarza);
            panel_DodajLekarza.Controls.Add(label_nrTelefonuLekarza);
            panel_DodajLekarza.Location = new Point(328, 11);
            panel_DodajLekarza.Name = "panel_DodajLekarza";
            panel_DodajLekarza.Size = new Size(637, 462);
            panel_DodajLekarza.TabIndex = 40;
            panel_DodajLekarza.Visible = false;
            // 
            // comboBox_specjalizacjaLekarza
            // 
            comboBox_specjalizacjaLekarza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_specjalizacjaLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_specjalizacjaLekarza.FormattingEnabled = true;
            comboBox_specjalizacjaLekarza.Items.AddRange(new object[] { "Chirurg", "Dermatolog", "Kardiolog", "Lekarz ogólny", "Neurolog", "Okulista", "Onkolog", "Ortopeda", "Stomatolog" });
            comboBox_specjalizacjaLekarza.Location = new Point(140, 260);
            comboBox_specjalizacjaLekarza.Name = "comboBox_specjalizacjaLekarza";
            comboBox_specjalizacjaLekarza.Size = new Size(288, 38);
            comboBox_specjalizacjaLekarza.Sorted = true;
            comboBox_specjalizacjaLekarza.TabIndex = 5;
            // 
            // textBox_nrTelefonuLekarza
            // 
            textBox_nrTelefonuLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_nrTelefonuLekarza.Location = new Point(140, 311);
            textBox_nrTelefonuLekarza.Multiline = true;
            textBox_nrTelefonuLekarza.Name = "textBox_nrTelefonuLekarza";
            textBox_nrTelefonuLekarza.Size = new Size(288, 38);
            textBox_nrTelefonuLekarza.TabIndex = 6;
            // 
            // textBox_nazwiskoLekarza
            // 
            textBox_nazwiskoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_nazwiskoLekarza.Location = new Point(140, 160);
            textBox_nazwiskoLekarza.Multiline = true;
            textBox_nazwiskoLekarza.Name = "textBox_nazwiskoLekarza";
            textBox_nazwiskoLekarza.Size = new Size(288, 38);
            textBox_nazwiskoLekarza.TabIndex = 3;
            // 
            // comboBox_plecLekarza
            // 
            comboBox_plecLekarza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_plecLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_plecLekarza.FormattingEnabled = true;
            comboBox_plecLekarza.Items.AddRange(new object[] { "Kobieta", "Mężczyzna" });
            comboBox_plecLekarza.Location = new Point(140, 210);
            comboBox_plecLekarza.Name = "comboBox_plecLekarza";
            comboBox_plecLekarza.Size = new Size(288, 38);
            comboBox_plecLekarza.TabIndex = 4;
            // 
            // textBox_idLekarza
            // 
            textBox_idLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_idLekarza.Location = new Point(140, 60);
            textBox_idLekarza.Multiline = true;
            textBox_idLekarza.Name = "textBox_idLekarza";
            textBox_idLekarza.ReadOnly = true;
            textBox_idLekarza.Size = new Size(288, 38);
            textBox_idLekarza.TabIndex = 1;
            // 
            // label_idLekarza
            // 
            label_idLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_idLekarza.Location = new Point(38, 72);
            label_idLekarza.Name = "label_idLekarza";
            label_idLekarza.Size = new Size(74, 21);
            label_idLekarza.TabIndex = 30;
            label_idLekarza.Text = "Numer";
            label_idLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_NowyLekarz
            // 
            label_NowyLekarz.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_NowyLekarz.Location = new Point(9, 13);
            label_NowyLekarz.Name = "label_NowyLekarz";
            label_NowyLekarz.Size = new Size(154, 27);
            label_NowyLekarz.TabIndex = 11;
            label_NowyLekarz.Text = "Dodaj lekarza";
            label_NowyLekarz.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_imieLekarza
            // 
            label_imieLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_imieLekarza.Location = new Point(38, 122);
            label_imieLekarza.Name = "label_imieLekarza";
            label_imieLekarza.Size = new Size(74, 21);
            label_imieLekarza.TabIndex = 12;
            label_imieLekarza.Text = "Imię";
            label_imieLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_imieLekarza
            // 
            textBox_imieLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_imieLekarza.Location = new Point(140, 110);
            textBox_imieLekarza.Multiline = true;
            textBox_imieLekarza.Name = "textBox_imieLekarza";
            textBox_imieLekarza.Size = new Size(288, 38);
            textBox_imieLekarza.TabIndex = 2;
            // 
            // btn_zapiszLekarza
            // 
            btn_zapiszLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_zapiszLekarza.Location = new Point(504, 402);
            btn_zapiszLekarza.Name = "btn_zapiszLekarza";
            btn_zapiszLekarza.Size = new Size(130, 46);
            btn_zapiszLekarza.TabIndex = 8;
            btn_zapiszLekarza.Text = "Zapisz lekarza";
            btn_zapiszLekarza.UseVisualStyleBackColor = true;
            btn_zapiszLekarza.Click += btn_zapiszLekarza_Click;
            // 
            // label_nazwiskoLekarza
            // 
            label_nazwiskoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_nazwiskoLekarza.Location = new Point(38, 172);
            label_nazwiskoLekarza.Name = "label_nazwiskoLekarza";
            label_nazwiskoLekarza.Size = new Size(74, 21);
            label_nazwiskoLekarza.TabIndex = 22;
            label_nazwiskoLekarza.Text = "Nazwisko";
            label_nazwiskoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_mailLekarza
            // 
            textBox_mailLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_mailLekarza.Location = new Point(140, 360);
            textBox_mailLekarza.Multiline = true;
            textBox_mailLekarza.Name = "textBox_mailLekarza";
            textBox_mailLekarza.Size = new Size(288, 38);
            textBox_mailLekarza.TabIndex = 7;
            // 
            // label_mailLekarza
            // 
            label_mailLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_mailLekarza.Location = new Point(15, 372);
            label_mailLekarza.Name = "label_mailLekarza";
            label_mailLekarza.Size = new Size(97, 21);
            label_mailLekarza.TabIndex = 20;
            label_mailLekarza.Text = "E-mail";
            label_mailLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_specjalizacjaLekarza
            // 
            label_specjalizacjaLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_specjalizacjaLekarza.Location = new Point(9, 272);
            label_specjalizacjaLekarza.Name = "label_specjalizacjaLekarza";
            label_specjalizacjaLekarza.Size = new Size(103, 21);
            label_specjalizacjaLekarza.TabIndex = 14;
            label_specjalizacjaLekarza.Text = "Specjalizacja";
            label_specjalizacjaLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_plecLekarza
            // 
            label_plecLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_plecLekarza.Location = new Point(38, 222);
            label_plecLekarza.Name = "label_plecLekarza";
            label_plecLekarza.Size = new Size(74, 21);
            label_plecLekarza.TabIndex = 16;
            label_plecLekarza.Text = "Płeć";
            label_plecLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_nrTelefonuLekarza
            // 
            label_nrTelefonuLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_nrTelefonuLekarza.Location = new Point(9, 323);
            label_nrTelefonuLekarza.Name = "label_nrTelefonuLekarza";
            label_nrTelefonuLekarza.Size = new Size(103, 21);
            label_nrTelefonuLekarza.TabIndex = 18;
            label_nrTelefonuLekarza.Text = "Numer telefonu";
            label_nrTelefonuLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel_edycjaLekarza
            // 
            panel_edycjaLekarza.Controls.Add(comboBox_specjalizacjaEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(textBox_nrTelefonuEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(textBox_nazwiskoEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(comboBox_plecEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(textBox_idEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(label_idEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(label_edytujLekarza);
            panel_edycjaLekarza.Controls.Add(label_imieEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(textBox_imieEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(btn_zapiszEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(label_nazwiskoEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(textBox_mailEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(label_mailEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(label_specjalizacjaEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(label_plecEdytowanegoLekarza);
            panel_edycjaLekarza.Controls.Add(label_nrtelefonuEdytowanegoLekarza);
            panel_edycjaLekarza.Location = new Point(328, 14);
            panel_edycjaLekarza.Name = "panel_edycjaLekarza";
            panel_edycjaLekarza.Size = new Size(637, 462);
            panel_edycjaLekarza.TabIndex = 41;
            panel_edycjaLekarza.Visible = false;
            // 
            // comboBox_specjalizacjaEdytowanegoLekarza
            // 
            comboBox_specjalizacjaEdytowanegoLekarza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_specjalizacjaEdytowanegoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_specjalizacjaEdytowanegoLekarza.FormattingEnabled = true;
            comboBox_specjalizacjaEdytowanegoLekarza.Items.AddRange(new object[] { "Chirurg", "Dermatolog", "Kardiolog", "Lekarz ogólny", "Neurolog", "Okulista", "Onkolog", "Ortopeda", "Stomatolog" });
            comboBox_specjalizacjaEdytowanegoLekarza.Location = new Point(140, 260);
            comboBox_specjalizacjaEdytowanegoLekarza.Name = "comboBox_specjalizacjaEdytowanegoLekarza";
            comboBox_specjalizacjaEdytowanegoLekarza.Size = new Size(288, 38);
            comboBox_specjalizacjaEdytowanegoLekarza.Sorted = true;
            comboBox_specjalizacjaEdytowanegoLekarza.TabIndex = 5;
            // 
            // textBox_nrTelefonuEdytowanegoLekarza
            // 
            textBox_nrTelefonuEdytowanegoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_nrTelefonuEdytowanegoLekarza.Location = new Point(140, 311);
            textBox_nrTelefonuEdytowanegoLekarza.Multiline = true;
            textBox_nrTelefonuEdytowanegoLekarza.Name = "textBox_nrTelefonuEdytowanegoLekarza";
            textBox_nrTelefonuEdytowanegoLekarza.Size = new Size(288, 38);
            textBox_nrTelefonuEdytowanegoLekarza.TabIndex = 6;
            // 
            // textBox_nazwiskoEdytowanegoLekarza
            // 
            textBox_nazwiskoEdytowanegoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_nazwiskoEdytowanegoLekarza.Location = new Point(140, 160);
            textBox_nazwiskoEdytowanegoLekarza.Multiline = true;
            textBox_nazwiskoEdytowanegoLekarza.Name = "textBox_nazwiskoEdytowanegoLekarza";
            textBox_nazwiskoEdytowanegoLekarza.Size = new Size(288, 38);
            textBox_nazwiskoEdytowanegoLekarza.TabIndex = 3;
            // 
            // comboBox_plecEdytowanegoLekarza
            // 
            comboBox_plecEdytowanegoLekarza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_plecEdytowanegoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_plecEdytowanegoLekarza.FormattingEnabled = true;
            comboBox_plecEdytowanegoLekarza.Items.AddRange(new object[] { "Kobieta", "Mężczyzna" });
            comboBox_plecEdytowanegoLekarza.Location = new Point(140, 210);
            comboBox_plecEdytowanegoLekarza.Name = "comboBox_plecEdytowanegoLekarza";
            comboBox_plecEdytowanegoLekarza.Size = new Size(288, 38);
            comboBox_plecEdytowanegoLekarza.TabIndex = 4;
            // 
            // textBox_idEdytowanegoLekarza
            // 
            textBox_idEdytowanegoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_idEdytowanegoLekarza.Location = new Point(140, 60);
            textBox_idEdytowanegoLekarza.Multiline = true;
            textBox_idEdytowanegoLekarza.Name = "textBox_idEdytowanegoLekarza";
            textBox_idEdytowanegoLekarza.ReadOnly = true;
            textBox_idEdytowanegoLekarza.Size = new Size(288, 38);
            textBox_idEdytowanegoLekarza.TabIndex = 1;
            // 
            // label_idEdytowanegoLekarza
            // 
            label_idEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_idEdytowanegoLekarza.Location = new Point(38, 72);
            label_idEdytowanegoLekarza.Name = "label_idEdytowanegoLekarza";
            label_idEdytowanegoLekarza.Size = new Size(74, 21);
            label_idEdytowanegoLekarza.TabIndex = 30;
            label_idEdytowanegoLekarza.Text = "Numer";
            label_idEdytowanegoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_edytujLekarza
            // 
            label_edytujLekarza.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_edytujLekarza.Location = new Point(9, 13);
            label_edytujLekarza.Name = "label_edytujLekarza";
            label_edytujLekarza.Size = new Size(154, 27);
            label_edytujLekarza.TabIndex = 11;
            label_edytujLekarza.Text = "Edytuj lekarza";
            label_edytujLekarza.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_imieEdytowanegoLekarza
            // 
            label_imieEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_imieEdytowanegoLekarza.Location = new Point(38, 122);
            label_imieEdytowanegoLekarza.Name = "label_imieEdytowanegoLekarza";
            label_imieEdytowanegoLekarza.Size = new Size(74, 21);
            label_imieEdytowanegoLekarza.TabIndex = 12;
            label_imieEdytowanegoLekarza.Text = "Imię";
            label_imieEdytowanegoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_imieEdytowanegoLekarza
            // 
            textBox_imieEdytowanegoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_imieEdytowanegoLekarza.Location = new Point(140, 110);
            textBox_imieEdytowanegoLekarza.Multiline = true;
            textBox_imieEdytowanegoLekarza.Name = "textBox_imieEdytowanegoLekarza";
            textBox_imieEdytowanegoLekarza.Size = new Size(288, 38);
            textBox_imieEdytowanegoLekarza.TabIndex = 2;
            // 
            // btn_zapiszEdytowanegoLekarza
            // 
            btn_zapiszEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_zapiszEdytowanegoLekarza.Location = new Point(504, 402);
            btn_zapiszEdytowanegoLekarza.Name = "btn_zapiszEdytowanegoLekarza";
            btn_zapiszEdytowanegoLekarza.Size = new Size(130, 46);
            btn_zapiszEdytowanegoLekarza.TabIndex = 8;
            btn_zapiszEdytowanegoLekarza.Text = "Zapisz lekarza";
            btn_zapiszEdytowanegoLekarza.UseVisualStyleBackColor = true;
            btn_zapiszEdytowanegoLekarza.Click += btn_zapiszEdytowanegoLekarza_Click;
            // 
            // label_nazwiskoEdytowanegoLekarza
            // 
            label_nazwiskoEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_nazwiskoEdytowanegoLekarza.Location = new Point(38, 172);
            label_nazwiskoEdytowanegoLekarza.Name = "label_nazwiskoEdytowanegoLekarza";
            label_nazwiskoEdytowanegoLekarza.Size = new Size(74, 21);
            label_nazwiskoEdytowanegoLekarza.TabIndex = 22;
            label_nazwiskoEdytowanegoLekarza.Text = "Nazwisko";
            label_nazwiskoEdytowanegoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_mailEdytowanegoLekarza
            // 
            textBox_mailEdytowanegoLekarza.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_mailEdytowanegoLekarza.Location = new Point(140, 360);
            textBox_mailEdytowanegoLekarza.Multiline = true;
            textBox_mailEdytowanegoLekarza.Name = "textBox_mailEdytowanegoLekarza";
            textBox_mailEdytowanegoLekarza.Size = new Size(288, 38);
            textBox_mailEdytowanegoLekarza.TabIndex = 7;
            // 
            // label_mailEdytowanegoLekarza
            // 
            label_mailEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_mailEdytowanegoLekarza.Location = new Point(15, 372);
            label_mailEdytowanegoLekarza.Name = "label_mailEdytowanegoLekarza";
            label_mailEdytowanegoLekarza.Size = new Size(97, 21);
            label_mailEdytowanegoLekarza.TabIndex = 20;
            label_mailEdytowanegoLekarza.Text = "E-mail";
            label_mailEdytowanegoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_specjalizacjaEdytowanegoLekarza
            // 
            label_specjalizacjaEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_specjalizacjaEdytowanegoLekarza.Location = new Point(9, 272);
            label_specjalizacjaEdytowanegoLekarza.Name = "label_specjalizacjaEdytowanegoLekarza";
            label_specjalizacjaEdytowanegoLekarza.Size = new Size(103, 21);
            label_specjalizacjaEdytowanegoLekarza.TabIndex = 14;
            label_specjalizacjaEdytowanegoLekarza.Text = "Specjalizacja";
            label_specjalizacjaEdytowanegoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_plecEdytowanegoLekarza
            // 
            label_plecEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_plecEdytowanegoLekarza.Location = new Point(38, 222);
            label_plecEdytowanegoLekarza.Name = "label_plecEdytowanegoLekarza";
            label_plecEdytowanegoLekarza.Size = new Size(74, 21);
            label_plecEdytowanegoLekarza.TabIndex = 16;
            label_plecEdytowanegoLekarza.Text = "Płeć";
            label_plecEdytowanegoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_nrtelefonuEdytowanegoLekarza
            // 
            label_nrtelefonuEdytowanegoLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_nrtelefonuEdytowanegoLekarza.Location = new Point(9, 323);
            label_nrtelefonuEdytowanegoLekarza.Name = "label_nrtelefonuEdytowanegoLekarza";
            label_nrtelefonuEdytowanegoLekarza.Size = new Size(103, 21);
            label_nrtelefonuEdytowanegoLekarza.TabIndex = 18;
            label_nrtelefonuEdytowanegoLekarza.Text = "Numer telefonu";
            label_nrtelefonuEdytowanegoLekarza.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridView_listaLekarzy
            // 
            dataGridView_listaLekarzy.AllowUserToAddRows = false;
            dataGridView_listaLekarzy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listaLekarzy.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_listaLekarzy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_listaLekarzy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_listaLekarzy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_listaLekarzy.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_listaLekarzy.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_listaLekarzy.Location = new Point(327, 514);
            dataGridView_listaLekarzy.MultiSelect = false;
            dataGridView_listaLekarzy.Name = "dataGridView_listaLekarzy";
            dataGridView_listaLekarzy.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_listaLekarzy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_listaLekarzy.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_listaLekarzy.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_listaLekarzy.RowTemplate.Height = 50;
            dataGridView_listaLekarzy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_listaLekarzy.Size = new Size(1546, 307);
            dataGridView_listaLekarzy.StandardTab = true;
            dataGridView_listaLekarzy.TabIndex = 32;
            dataGridView_listaLekarzy.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // label_listaLekarzy
            // 
            label_listaLekarzy.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_listaLekarzy.Location = new Point(327, 484);
            label_listaLekarzy.Name = "label_listaLekarzy";
            label_listaLekarzy.Size = new Size(275, 27);
            label_listaLekarzy.TabIndex = 42;
            label_listaLekarzy.Text = "Lista lekarzy";
            label_listaLekarzy.Visible = false;
            // 
            // btn_edytowanieLekarza
            // 
            btn_edytowanieLekarza.Enabled = false;
            btn_edytowanieLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_edytowanieLekarza.Location = new Point(914, 827);
            btn_edytowanieLekarza.Name = "btn_edytowanieLekarza";
            btn_edytowanieLekarza.Size = new Size(386, 46);
            btn_edytowanieLekarza.TabIndex = 43;
            btn_edytowanieLekarza.Text = "Edytuj";
            btn_edytowanieLekarza.UseVisualStyleBackColor = true;
            btn_edytowanieLekarza.Visible = false;
            btn_edytowanieLekarza.Click += btn_edytowanieLekarza_Click;
            // 
            // btn_usuwanieLekarza
            // 
            btn_usuwanieLekarza.Enabled = false;
            btn_usuwanieLekarza.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_usuwanieLekarza.Location = new Point(914, 827);
            btn_usuwanieLekarza.Name = "btn_usuwanieLekarza";
            btn_usuwanieLekarza.Size = new Size(386, 46);
            btn_usuwanieLekarza.TabIndex = 44;
            btn_usuwanieLekarza.Text = "Usuń";
            btn_usuwanieLekarza.UseVisualStyleBackColor = true;
            btn_usuwanieLekarza.Visible = false;
            btn_usuwanieLekarza.Click += btn_usuwanieLekarza_Click;
            // 
            // btn_cofnijDoMenuLekarzy
            // 
            btn_cofnijDoMenuLekarzy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_cofnijDoMenuLekarzy.Location = new Point(1737, 827);
            btn_cofnijDoMenuLekarzy.Name = "btn_cofnijDoMenuLekarzy";
            btn_cofnijDoMenuLekarzy.Size = new Size(130, 46);
            btn_cofnijDoMenuLekarzy.TabIndex = 45;
            btn_cofnijDoMenuLekarzy.Text = "Wstecz";
            btn_cofnijDoMenuLekarzy.UseVisualStyleBackColor = true;
            btn_cofnijDoMenuLekarzy.Visible = false;
            btn_cofnijDoMenuLekarzy.Click += btn_cofnijDoMenuLekarzy_Click;
            // 
            // label_lekarzDoEdycji
            // 
            label_lekarzDoEdycji.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_lekarzDoEdycji.Location = new Point(327, 484);
            label_lekarzDoEdycji.Name = "label_lekarzDoEdycji";
            label_lekarzDoEdycji.Size = new Size(275, 27);
            label_lekarzDoEdycji.TabIndex = 46;
            label_lekarzDoEdycji.Text = "Wybierz lekarza do edytowania";
            label_lekarzDoEdycji.Visible = false;
            // 
            // label_usuwanieLekarza
            // 
            label_usuwanieLekarza.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_usuwanieLekarza.Location = new Point(328, 484);
            label_usuwanieLekarza.Name = "label_usuwanieLekarza";
            label_usuwanieLekarza.Size = new Size(275, 27);
            label_usuwanieLekarza.TabIndex = 47;
            label_usuwanieLekarza.Text = "Wybierz lekarza do usunięcia";
            label_usuwanieLekarza.Visible = false;
            // 
            // Menu_Lekarze
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 885);
            Controls.Add(btn_cofnijDoMenuLekarzy);
            Controls.Add(dataGridView_listaLekarzy);
            Controls.Add(btn_wrocDoMenuGlownego);
            Controls.Add(label_VetAnimal);
            Controls.Add(btn_usuwanieLekarza);
            Controls.Add(btn_edytowanieLekarza);
            Controls.Add(panel_DodajLekarza);
            Controls.Add(label_lekarzDoEdycji);
            Controls.Add(label_listaLekarzy);
            Controls.Add(label_usuwanieLekarza);
            Controls.Add(panel_edycjaLekarza);
            Controls.Add(panel_Lekarze);
            Name = "Menu_Lekarze";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu_Lekarze";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Lekarze_Load;
            panel_Lekarze.ResumeLayout(false);
            panel_DodajLekarza.ResumeLayout(false);
            panel_DodajLekarza.PerformLayout();
            panel_edycjaLekarza.ResumeLayout(false);
            panel_edycjaLekarza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_listaLekarzy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_VetAnimal;
        private Button btn_wrocDoMenuGlownego;
        private Panel panel_Lekarze;
        private Button btn_ListaLekarzy;
        private Button btn_UsunLekarza;
        private Button btn_EdytujLekarza;
        private Button btn_DodajLekarza;
        private Panel panel_DodajLekarza;
        private TextBox textBox_nrTelefonuLekarza;
        private TextBox textBox_nazwiskoLekarza;
        private ComboBox comboBox_plecLekarza;
        private TextBox textBox_idLekarza;
        private Label label_idLekarza;
        private Label label_NowyLekarz;
        private Label label_imieLekarza;
        private TextBox textBox_imieLekarza;
        private Button btn_zapiszLekarza;
        private Label label_nazwiskoLekarza;
        private TextBox textBox_mailLekarza;
        private Label label_mailLekarza;
        private Label label_specjalizacjaLekarza;
        private Label label_plecLekarza;
        private Label label_nrTelefonuLekarza;
        private ComboBox comboBox_specjalizacjaLekarza;
        private Panel panel_edycjaLekarza;
        private ComboBox comboBox_specjalizacjaEdytowanegoLekarza;
        private TextBox textBox_nrTelefonuEdytowanegoLekarza;
        private TextBox textBox_nazwiskoEdytowanegoLekarza;
        private ComboBox comboBox_plecEdytowanegoLekarza;
        private TextBox textBox_idEdytowanegoLekarza;
        private Label label_idEdytowanegoLekarza;
        private Label label_edytujLekarza;
        private Label label_imieEdytowanegoLekarza;
        private TextBox textBox_imieEdytowanegoLekarza;
        private Button btn_zapiszEdytowanegoLekarza;
        private Label label_nazwiskoEdytowanegoLekarza;
        private TextBox textBox_mailEdytowanegoLekarza;
        private Label label_mailEdytowanegoLekarza;
        private Label label_specjalizacjaEdytowanegoLekarza;
        private Label label_plecEdytowanegoLekarza;
        private Label label_nrtelefonuEdytowanegoLekarza;
        private DataGridView dataGridView_listaLekarzy;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label_listaLekarzy;
        private Button btn_edytowanieLekarza;
        private Button btn_usuwanieLekarza;
        private Button btn_cofnijDoMenuLekarzy;
        private Label label_lekarzDoEdycji;
        private Label label_usuwanieLekarza;
    }
}