using System.Windows.Forms;

namespace Przychodnia
{
    partial class Menu_Pacjenci
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
            panel_Pacjenci = new Panel();
            btn_ListaPacjentow = new Button();
            btn_UsunPacjenta = new Button();
            btn_EdytujPacjenta = new Button();
            btn_DodajPacjenta = new Button();
            panel_NowyPacjent = new Panel();
            comboBox_ListaWlascicieli = new ComboBox();
            label_WlascicielPacjenta = new Label();
            comboBox_Plec = new ComboBox();
            textBox_idPacjenta = new TextBox();
            label_idPacjenta = new Label();
            dateTimePicker_DataUrodzeniaPacjenta = new DateTimePicker();
            label_NowyPacjent = new Label();
            label_ImiePacjenta = new Label();
            textBox_ImiePacjenta = new TextBox();
            comboBox_GatunekPacjenta = new ComboBox();
            textBox_RasaPacjenta = new TextBox();
            btn_ZapiszPacjenta = new Button();
            label_GatunekPacjenta = new Label();
            textBox_WagaPacjenta = new TextBox();
            label_WagaPacjenta = new Label();
            label_RasaPacjenta = new Label();
            label_PlecPacjenta = new Label();
            label_DataUrodzenia = new Label();
            btn_cofnijDoMenuPacjentow = new Button();
            dataGridView_listaPacjentow = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label_ListaPacjentow = new Label();
            panel_edycjaPacjenta = new Panel();
            comboBox_wlascicielEdytowanegoPacjenta = new ComboBox();
            label_wlascicielEdytowanegoPacjenta = new Label();
            comboBox_plecEdytowanegoPacjenta = new ComboBox();
            textBox_idEdytowanegoPacjenta = new TextBox();
            label_idEdytowanegoPacjenta = new Label();
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta = new DateTimePicker();
            label_edycjaPacjenta = new Label();
            label_imieEdytowanegoPacjenta = new Label();
            textBox_imieEdytowanegoPacjenta = new TextBox();
            comboBox_gatunekEdytowanegoPacjenta = new ComboBox();
            textBox_rasaEdytowanegoPacjenta = new TextBox();
            btn_zapiszEdytowanegoPacjenta = new Button();
            label_gatunekEdytowanegoPacjenta = new Label();
            textBox_wagaEdytowanegoPacjenta = new TextBox();
            label_wagaEdytowanegoPacjenta = new Label();
            label_rasaEdytowanegoPacjenta = new Label();
            label_plecEdytowanegoPacjenta = new Label();
            label_dataUrodzeniaEdytowanegoPacjenta = new Label();
            btn_edycjaPacjenta = new Button();
            btn_wrocDoMenuGlownego = new Button();
            label_usuwaniePacjenta = new Label();
            btn_usuwaniePacjenta = new Button();
            label_pacjentDoEdycji = new Label();
            panel_Pacjenci.SuspendLayout();
            panel_NowyPacjent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_listaPacjentow).BeginInit();
            panel_edycjaPacjenta.SuspendLayout();
            SuspendLayout();
            // 
            // label_VetAnimal
            // 
            label_VetAnimal.BackColor = SystemColors.HotTrack;
            label_VetAnimal.Dock = DockStyle.Left;
            label_VetAnimal.Font = new Font("Sitka Banner", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_VetAnimal.Location = new Point(0, 0);
            label_VetAnimal.Name = "label_VetAnimal";
            label_VetAnimal.Size = new Size(321, 1011);
            label_VetAnimal.TabIndex = 2;
            label_VetAnimal.Text = "VetAnimal";
            label_VetAnimal.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel_Pacjenci
            // 
            panel_Pacjenci.Controls.Add(btn_ListaPacjentow);
            panel_Pacjenci.Controls.Add(btn_UsunPacjenta);
            panel_Pacjenci.Controls.Add(btn_EdytujPacjenta);
            panel_Pacjenci.Controls.Add(btn_DodajPacjenta);
            panel_Pacjenci.Location = new Point(327, 12);
            panel_Pacjenci.Name = "panel_Pacjenci";
            panel_Pacjenci.Size = new Size(772, 224);
            panel_Pacjenci.TabIndex = 12;
            // 
            // btn_ListaPacjentow
            // 
            btn_ListaPacjentow.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_ListaPacjentow.Location = new Point(3, 4);
            btn_ListaPacjentow.Name = "btn_ListaPacjentow";
            btn_ListaPacjentow.Size = new Size(367, 94);
            btn_ListaPacjentow.TabIndex = 1;
            btn_ListaPacjentow.Text = "Lista pacjentów";
            btn_ListaPacjentow.UseVisualStyleBackColor = true;
            btn_ListaPacjentow.Click += btn_ListaPacjentow_Click;
            // 
            // btn_UsunPacjenta
            // 
            btn_UsunPacjenta.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_UsunPacjenta.Location = new Point(397, 126);
            btn_UsunPacjenta.Name = "btn_UsunPacjenta";
            btn_UsunPacjenta.Size = new Size(367, 94);
            btn_UsunPacjenta.TabIndex = 4;
            btn_UsunPacjenta.Text = "Usuń pacjenta";
            btn_UsunPacjenta.UseVisualStyleBackColor = true;
            btn_UsunPacjenta.Click += btn_UsunPacjenta_Click;
            // 
            // btn_EdytujPacjenta
            // 
            btn_EdytujPacjenta.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_EdytujPacjenta.Location = new Point(5, 126);
            btn_EdytujPacjenta.Name = "btn_EdytujPacjenta";
            btn_EdytujPacjenta.Size = new Size(367, 94);
            btn_EdytujPacjenta.TabIndex = 3;
            btn_EdytujPacjenta.Text = "Edytuj pacjenta";
            btn_EdytujPacjenta.UseVisualStyleBackColor = true;
            btn_EdytujPacjenta.Click += btn_EdytujPacjenta_Click;
            // 
            // btn_DodajPacjenta
            // 
            btn_DodajPacjenta.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_DodajPacjenta.Location = new Point(397, 4);
            btn_DodajPacjenta.Name = "btn_DodajPacjenta";
            btn_DodajPacjenta.Size = new Size(367, 94);
            btn_DodajPacjenta.TabIndex = 2;
            btn_DodajPacjenta.Text = "Dodaj pacjenta";
            btn_DodajPacjenta.UseVisualStyleBackColor = true;
            btn_DodajPacjenta.Click += btn_DodajPacjenta_Click;
            // 
            // panel_NowyPacjent
            // 
            panel_NowyPacjent.Controls.Add(comboBox_ListaWlascicieli);
            panel_NowyPacjent.Controls.Add(label_WlascicielPacjenta);
            panel_NowyPacjent.Controls.Add(comboBox_Plec);
            panel_NowyPacjent.Controls.Add(textBox_idPacjenta);
            panel_NowyPacjent.Controls.Add(label_idPacjenta);
            panel_NowyPacjent.Controls.Add(dateTimePicker_DataUrodzeniaPacjenta);
            panel_NowyPacjent.Controls.Add(label_NowyPacjent);
            panel_NowyPacjent.Controls.Add(label_ImiePacjenta);
            panel_NowyPacjent.Controls.Add(textBox_ImiePacjenta);
            panel_NowyPacjent.Controls.Add(comboBox_GatunekPacjenta);
            panel_NowyPacjent.Controls.Add(textBox_RasaPacjenta);
            panel_NowyPacjent.Controls.Add(btn_ZapiszPacjenta);
            panel_NowyPacjent.Controls.Add(label_GatunekPacjenta);
            panel_NowyPacjent.Controls.Add(textBox_WagaPacjenta);
            panel_NowyPacjent.Controls.Add(label_WagaPacjenta);
            panel_NowyPacjent.Controls.Add(label_RasaPacjenta);
            panel_NowyPacjent.Controls.Add(label_PlecPacjenta);
            panel_NowyPacjent.Controls.Add(label_DataUrodzenia);
            panel_NowyPacjent.Location = new Point(327, 12);
            panel_NowyPacjent.Name = "panel_NowyPacjent";
            panel_NowyPacjent.Size = new Size(637, 462);
            panel_NowyPacjent.TabIndex = 27;
            panel_NowyPacjent.Visible = false;
            // 
            // comboBox_ListaWlascicieli
            // 
            comboBox_ListaWlascicieli.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_ListaWlascicieli.FormattingEnabled = true;
            comboBox_ListaWlascicieli.Location = new Point(140, 410);
            comboBox_ListaWlascicieli.Name = "comboBox_ListaWlascicieli";
            comboBox_ListaWlascicieli.Size = new Size(230, 38);
            comboBox_ListaWlascicieli.Sorted = true;
            comboBox_ListaWlascicieli.TabIndex = 8;
            // 
            // label_WlascicielPacjenta
            // 
            label_WlascicielPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_WlascicielPacjenta.Location = new Point(17, 420);
            label_WlascicielPacjenta.Name = "label_WlascicielPacjenta";
            label_WlascicielPacjenta.Size = new Size(97, 21);
            label_WlascicielPacjenta.TabIndex = 31;
            label_WlascicielPacjenta.Text = "Właściciel";
            label_WlascicielPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox_Plec
            // 
            comboBox_Plec.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Plec.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_Plec.FormattingEnabled = true;
            comboBox_Plec.Items.AddRange(new object[] { "Samiec", "Samica" });
            comboBox_Plec.Location = new Point(140, 260);
            comboBox_Plec.Name = "comboBox_Plec";
            comboBox_Plec.Size = new Size(230, 38);
            comboBox_Plec.TabIndex = 5;
            // 
            // textBox_idPacjenta
            // 
            textBox_idPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_idPacjenta.Location = new Point(140, 60);
            textBox_idPacjenta.Multiline = true;
            textBox_idPacjenta.Name = "textBox_idPacjenta";
            textBox_idPacjenta.ReadOnly = true;
            textBox_idPacjenta.Size = new Size(230, 38);
            textBox_idPacjenta.TabIndex = 1;
            // 
            // label_idPacjenta
            // 
            label_idPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_idPacjenta.Location = new Point(38, 77);
            label_idPacjenta.Name = "label_idPacjenta";
            label_idPacjenta.Size = new Size(74, 21);
            label_idPacjenta.TabIndex = 30;
            label_idPacjenta.Text = "Numer";
            label_idPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_DataUrodzeniaPacjenta
            // 
            dateTimePicker_DataUrodzeniaPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_DataUrodzeniaPacjenta.Format = DateTimePickerFormat.Short;
            dateTimePicker_DataUrodzeniaPacjenta.Location = new Point(140, 310);
            dateTimePicker_DataUrodzeniaPacjenta.MaxDate = new DateTime(2024, 11, 26, 0, 0, 0, 0);
            dateTimePicker_DataUrodzeniaPacjenta.Name = "dateTimePicker_DataUrodzeniaPacjenta";
            dateTimePicker_DataUrodzeniaPacjenta.Size = new Size(230, 35);
            dateTimePicker_DataUrodzeniaPacjenta.TabIndex = 6;
            dateTimePicker_DataUrodzeniaPacjenta.Value = new DateTime(2024, 11, 26, 0, 0, 0, 0);
            dateTimePicker_DataUrodzeniaPacjenta.ValueChanged += dateTimePicker_DataUrodzeniaPacjenta_ValueChanged;
            // 
            // label_NowyPacjent
            // 
            label_NowyPacjent.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_NowyPacjent.Location = new Point(9, 13);
            label_NowyPacjent.Name = "label_NowyPacjent";
            label_NowyPacjent.Size = new Size(124, 27);
            label_NowyPacjent.TabIndex = 11;
            label_NowyPacjent.Text = "Nowy pacjent";
            label_NowyPacjent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_ImiePacjenta
            // 
            label_ImiePacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_ImiePacjenta.Location = new Point(38, 122);
            label_ImiePacjenta.Name = "label_ImiePacjenta";
            label_ImiePacjenta.Size = new Size(74, 21);
            label_ImiePacjenta.TabIndex = 12;
            label_ImiePacjenta.Text = "Imię";
            label_ImiePacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_ImiePacjenta
            // 
            textBox_ImiePacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_ImiePacjenta.Location = new Point(140, 110);
            textBox_ImiePacjenta.Multiline = true;
            textBox_ImiePacjenta.Name = "textBox_ImiePacjenta";
            textBox_ImiePacjenta.Size = new Size(230, 38);
            textBox_ImiePacjenta.TabIndex = 2;
            // 
            // comboBox_GatunekPacjenta
            // 
            comboBox_GatunekPacjenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_GatunekPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_GatunekPacjenta.FormattingEnabled = true;
            comboBox_GatunekPacjenta.Items.AddRange(new object[] { "Pies", "Kot", "Chomik", "Królik", "Świnka morska", "Ryba", "Papuga", "Jaszczurka", "Wąż", "Pająk", "Żółw", "Inne" });
            comboBox_GatunekPacjenta.Location = new Point(140, 160);
            comboBox_GatunekPacjenta.Name = "comboBox_GatunekPacjenta";
            comboBox_GatunekPacjenta.Size = new Size(230, 38);
            comboBox_GatunekPacjenta.TabIndex = 3;
            // 
            // textBox_RasaPacjenta
            // 
            textBox_RasaPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_RasaPacjenta.Location = new Point(140, 210);
            textBox_RasaPacjenta.Multiline = true;
            textBox_RasaPacjenta.Name = "textBox_RasaPacjenta";
            textBox_RasaPacjenta.Size = new Size(230, 38);
            textBox_RasaPacjenta.TabIndex = 4;
            // 
            // btn_ZapiszPacjenta
            // 
            btn_ZapiszPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_ZapiszPacjenta.Location = new Point(504, 402);
            btn_ZapiszPacjenta.Name = "btn_ZapiszPacjenta";
            btn_ZapiszPacjenta.Size = new Size(130, 46);
            btn_ZapiszPacjenta.TabIndex = 9;
            btn_ZapiszPacjenta.Text = "Zapisz pacjenta";
            btn_ZapiszPacjenta.UseVisualStyleBackColor = true;
            btn_ZapiszPacjenta.Click += btn_ZapiszPacjenta_Click;
            // 
            // label_GatunekPacjenta
            // 
            label_GatunekPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_GatunekPacjenta.Location = new Point(38, 172);
            label_GatunekPacjenta.Name = "label_GatunekPacjenta";
            label_GatunekPacjenta.Size = new Size(74, 21);
            label_GatunekPacjenta.TabIndex = 22;
            label_GatunekPacjenta.Text = "Gatunek";
            label_GatunekPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_WagaPacjenta
            // 
            textBox_WagaPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_WagaPacjenta.Location = new Point(140, 360);
            textBox_WagaPacjenta.Multiline = true;
            textBox_WagaPacjenta.Name = "textBox_WagaPacjenta";
            textBox_WagaPacjenta.Size = new Size(230, 38);
            textBox_WagaPacjenta.TabIndex = 7;
            // 
            // label_WagaPacjenta
            // 
            label_WagaPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_WagaPacjenta.Location = new Point(15, 372);
            label_WagaPacjenta.Name = "label_WagaPacjenta";
            label_WagaPacjenta.Size = new Size(97, 21);
            label_WagaPacjenta.TabIndex = 20;
            label_WagaPacjenta.Text = "Waga (w kg)";
            label_WagaPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_RasaPacjenta
            // 
            label_RasaPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_RasaPacjenta.Location = new Point(38, 222);
            label_RasaPacjenta.Name = "label_RasaPacjenta";
            label_RasaPacjenta.Size = new Size(74, 21);
            label_RasaPacjenta.TabIndex = 14;
            label_RasaPacjenta.Text = "Rasa";
            label_RasaPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_PlecPacjenta
            // 
            label_PlecPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_PlecPacjenta.Location = new Point(17, 272);
            label_PlecPacjenta.Name = "label_PlecPacjenta";
            label_PlecPacjenta.Size = new Size(95, 21);
            label_PlecPacjenta.TabIndex = 16;
            label_PlecPacjenta.Text = "Płeć";
            label_PlecPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_DataUrodzenia
            // 
            label_DataUrodzenia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_DataUrodzenia.Location = new Point(9, 323);
            label_DataUrodzenia.Name = "label_DataUrodzenia";
            label_DataUrodzenia.Size = new Size(103, 21);
            label_DataUrodzenia.TabIndex = 18;
            label_DataUrodzenia.Text = "Data urodzenia";
            label_DataUrodzenia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_cofnijDoMenuPacjentow
            // 
            btn_cofnijDoMenuPacjentow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_cofnijDoMenuPacjentow.Location = new Point(1743, 872);
            btn_cofnijDoMenuPacjentow.Name = "btn_cofnijDoMenuPacjentow";
            btn_cofnijDoMenuPacjentow.Size = new Size(130, 46);
            btn_cofnijDoMenuPacjentow.TabIndex = 9;
            btn_cofnijDoMenuPacjentow.Text = "Wstecz";
            btn_cofnijDoMenuPacjentow.UseVisualStyleBackColor = true;
            btn_cofnijDoMenuPacjentow.Visible = false;
            btn_cofnijDoMenuPacjentow.Click += btn_cofnijDoMenuPacjentow_Click;
            // 
            // dataGridView_listaPacjentow
            // 
            dataGridView_listaPacjentow.AllowUserToAddRows = false;
            dataGridView_listaPacjentow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listaPacjentow.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_listaPacjentow.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_listaPacjentow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_listaPacjentow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_listaPacjentow.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_listaPacjentow.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_listaPacjentow.Location = new Point(327, 521);
            dataGridView_listaPacjentow.MultiSelect = false;
            dataGridView_listaPacjentow.Name = "dataGridView_listaPacjentow";
            dataGridView_listaPacjentow.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_listaPacjentow.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_listaPacjentow.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_listaPacjentow.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_listaPacjentow.RowTemplate.Height = 50;
            dataGridView_listaPacjentow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_listaPacjentow.Size = new Size(1546, 345);
            dataGridView_listaPacjentow.StandardTab = true;
            dataGridView_listaPacjentow.TabIndex = 31;
            dataGridView_listaPacjentow.Visible = false;
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
            // label_ListaPacjentow
            // 
            label_ListaPacjentow.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_ListaPacjentow.Location = new Point(336, 491);
            label_ListaPacjentow.Name = "label_ListaPacjentow";
            label_ListaPacjentow.Size = new Size(143, 27);
            label_ListaPacjentow.TabIndex = 33;
            label_ListaPacjentow.Text = "Lista pacjentów";
            label_ListaPacjentow.Visible = false;
            // 
            // panel_edycjaPacjenta
            // 
            panel_edycjaPacjenta.Controls.Add(comboBox_wlascicielEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_wlascicielEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(comboBox_plecEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(textBox_idEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_idEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(dateTimePicker_dataUrodzeniaEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_edycjaPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_imieEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(textBox_imieEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(comboBox_gatunekEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(textBox_rasaEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(btn_zapiszEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_gatunekEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(textBox_wagaEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_wagaEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_rasaEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_plecEdytowanegoPacjenta);
            panel_edycjaPacjenta.Controls.Add(label_dataUrodzeniaEdytowanegoPacjenta);
            panel_edycjaPacjenta.Location = new Point(327, 9);
            panel_edycjaPacjenta.Name = "panel_edycjaPacjenta";
            panel_edycjaPacjenta.Size = new Size(637, 462);
            panel_edycjaPacjenta.TabIndex = 33;
            panel_edycjaPacjenta.Visible = false;
            // 
            // comboBox_wlascicielEdytowanegoPacjenta
            // 
            comboBox_wlascicielEdytowanegoPacjenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_wlascicielEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_wlascicielEdytowanegoPacjenta.FormattingEnabled = true;
            comboBox_wlascicielEdytowanegoPacjenta.Location = new Point(140, 410);
            comboBox_wlascicielEdytowanegoPacjenta.Name = "comboBox_wlascicielEdytowanegoPacjenta";
            comboBox_wlascicielEdytowanegoPacjenta.Size = new Size(258, 38);
            comboBox_wlascicielEdytowanegoPacjenta.Sorted = true;
            comboBox_wlascicielEdytowanegoPacjenta.TabIndex = 8;
            // 
            // label_wlascicielEdytowanegoPacjenta
            // 
            label_wlascicielEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_wlascicielEdytowanegoPacjenta.Location = new Point(17, 420);
            label_wlascicielEdytowanegoPacjenta.Name = "label_wlascicielEdytowanegoPacjenta";
            label_wlascicielEdytowanegoPacjenta.Size = new Size(97, 21);
            label_wlascicielEdytowanegoPacjenta.TabIndex = 31;
            label_wlascicielEdytowanegoPacjenta.Text = "Właściciel";
            label_wlascicielEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox_plecEdytowanegoPacjenta
            // 
            comboBox_plecEdytowanegoPacjenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_plecEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_plecEdytowanegoPacjenta.FormattingEnabled = true;
            comboBox_plecEdytowanegoPacjenta.Items.AddRange(new object[] { "Samiec", "Samica" });
            comboBox_plecEdytowanegoPacjenta.Location = new Point(140, 260);
            comboBox_plecEdytowanegoPacjenta.Name = "comboBox_plecEdytowanegoPacjenta";
            comboBox_plecEdytowanegoPacjenta.Size = new Size(258, 38);
            comboBox_plecEdytowanegoPacjenta.TabIndex = 5;
            // 
            // textBox_idEdytowanegoPacjenta
            // 
            textBox_idEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_idEdytowanegoPacjenta.Location = new Point(140, 60);
            textBox_idEdytowanegoPacjenta.Multiline = true;
            textBox_idEdytowanegoPacjenta.Name = "textBox_idEdytowanegoPacjenta";
            textBox_idEdytowanegoPacjenta.ReadOnly = true;
            textBox_idEdytowanegoPacjenta.Size = new Size(258, 38);
            textBox_idEdytowanegoPacjenta.TabIndex = 1;
            // 
            // label_idEdytowanegoPacjenta
            // 
            label_idEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_idEdytowanegoPacjenta.Location = new Point(38, 72);
            label_idEdytowanegoPacjenta.Name = "label_idEdytowanegoPacjenta";
            label_idEdytowanegoPacjenta.Size = new Size(74, 21);
            label_idEdytowanegoPacjenta.TabIndex = 30;
            label_idEdytowanegoPacjenta.Text = "Numer";
            label_idEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker_dataUrodzeniaEdytowanegoPacjenta
            // 
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Format = DateTimePickerFormat.Short;
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Location = new Point(140, 310);
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.MaxDate = new DateTime(2024, 11, 26, 0, 0, 0, 0);
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Name = "dateTimePicker_dataUrodzeniaEdytowanegoPacjenta";
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Size = new Size(258, 35);
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.TabIndex = 6;
            dateTimePicker_dataUrodzeniaEdytowanegoPacjenta.Value = new DateTime(2024, 11, 26, 0, 0, 0, 0);
            // 
            // label_edycjaPacjenta
            // 
            label_edycjaPacjenta.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_edycjaPacjenta.Location = new Point(9, 13);
            label_edycjaPacjenta.Name = "label_edycjaPacjenta";
            label_edycjaPacjenta.Size = new Size(143, 27);
            label_edycjaPacjenta.TabIndex = 11;
            label_edycjaPacjenta.Text = "Edytuj pacjenta";
            label_edycjaPacjenta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_imieEdytowanegoPacjenta
            // 
            label_imieEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_imieEdytowanegoPacjenta.Location = new Point(38, 122);
            label_imieEdytowanegoPacjenta.Name = "label_imieEdytowanegoPacjenta";
            label_imieEdytowanegoPacjenta.Size = new Size(74, 21);
            label_imieEdytowanegoPacjenta.TabIndex = 12;
            label_imieEdytowanegoPacjenta.Text = "Imię";
            label_imieEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_imieEdytowanegoPacjenta
            // 
            textBox_imieEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_imieEdytowanegoPacjenta.Location = new Point(140, 110);
            textBox_imieEdytowanegoPacjenta.Multiline = true;
            textBox_imieEdytowanegoPacjenta.Name = "textBox_imieEdytowanegoPacjenta";
            textBox_imieEdytowanegoPacjenta.Size = new Size(258, 38);
            textBox_imieEdytowanegoPacjenta.TabIndex = 2;
            // 
            // comboBox_gatunekEdytowanegoPacjenta
            // 
            comboBox_gatunekEdytowanegoPacjenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_gatunekEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_gatunekEdytowanegoPacjenta.FormattingEnabled = true;
            comboBox_gatunekEdytowanegoPacjenta.Items.AddRange(new object[] { "Chomik", "Inne", "Jaszczurka", "Kot", "Królik", "Pająk", "Papuga", "Pies", "Ryba", "Świnka morska", "Wąż", "Żółw" });
            comboBox_gatunekEdytowanegoPacjenta.Location = new Point(140, 160);
            comboBox_gatunekEdytowanegoPacjenta.Name = "comboBox_gatunekEdytowanegoPacjenta";
            comboBox_gatunekEdytowanegoPacjenta.Size = new Size(258, 38);
            comboBox_gatunekEdytowanegoPacjenta.Sorted = true;
            comboBox_gatunekEdytowanegoPacjenta.TabIndex = 3;
            // 
            // textBox_rasaEdytowanegoPacjenta
            // 
            textBox_rasaEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_rasaEdytowanegoPacjenta.Location = new Point(140, 210);
            textBox_rasaEdytowanegoPacjenta.Multiline = true;
            textBox_rasaEdytowanegoPacjenta.Name = "textBox_rasaEdytowanegoPacjenta";
            textBox_rasaEdytowanegoPacjenta.Size = new Size(258, 38);
            textBox_rasaEdytowanegoPacjenta.TabIndex = 4;
            // 
            // btn_zapiszEdytowanegoPacjenta
            // 
            btn_zapiszEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_zapiszEdytowanegoPacjenta.Location = new Point(504, 402);
            btn_zapiszEdytowanegoPacjenta.Name = "btn_zapiszEdytowanegoPacjenta";
            btn_zapiszEdytowanegoPacjenta.Size = new Size(130, 46);
            btn_zapiszEdytowanegoPacjenta.TabIndex = 9;
            btn_zapiszEdytowanegoPacjenta.Text = "Zapisz pacjenta";
            btn_zapiszEdytowanegoPacjenta.UseVisualStyleBackColor = true;
            btn_zapiszEdytowanegoPacjenta.Click += btn_zapiszEdytowanegoPacjenta_Click;
            // 
            // label_gatunekEdytowanegoPacjenta
            // 
            label_gatunekEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_gatunekEdytowanegoPacjenta.Location = new Point(38, 172);
            label_gatunekEdytowanegoPacjenta.Name = "label_gatunekEdytowanegoPacjenta";
            label_gatunekEdytowanegoPacjenta.Size = new Size(74, 21);
            label_gatunekEdytowanegoPacjenta.TabIndex = 22;
            label_gatunekEdytowanegoPacjenta.Text = "Gatunek";
            label_gatunekEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_wagaEdytowanegoPacjenta
            // 
            textBox_wagaEdytowanegoPacjenta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_wagaEdytowanegoPacjenta.Location = new Point(140, 360);
            textBox_wagaEdytowanegoPacjenta.Multiline = true;
            textBox_wagaEdytowanegoPacjenta.Name = "textBox_wagaEdytowanegoPacjenta";
            textBox_wagaEdytowanegoPacjenta.Size = new Size(258, 38);
            textBox_wagaEdytowanegoPacjenta.TabIndex = 7;
            // 
            // label_wagaEdytowanegoPacjenta
            // 
            label_wagaEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_wagaEdytowanegoPacjenta.Location = new Point(15, 372);
            label_wagaEdytowanegoPacjenta.Name = "label_wagaEdytowanegoPacjenta";
            label_wagaEdytowanegoPacjenta.Size = new Size(97, 21);
            label_wagaEdytowanegoPacjenta.TabIndex = 20;
            label_wagaEdytowanegoPacjenta.Text = "Waga (w kg)";
            label_wagaEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_rasaEdytowanegoPacjenta
            // 
            label_rasaEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_rasaEdytowanegoPacjenta.Location = new Point(38, 222);
            label_rasaEdytowanegoPacjenta.Name = "label_rasaEdytowanegoPacjenta";
            label_rasaEdytowanegoPacjenta.Size = new Size(74, 21);
            label_rasaEdytowanegoPacjenta.TabIndex = 14;
            label_rasaEdytowanegoPacjenta.Text = "Rasa";
            label_rasaEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_plecEdytowanegoPacjenta
            // 
            label_plecEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_plecEdytowanegoPacjenta.Location = new Point(17, 272);
            label_plecEdytowanegoPacjenta.Name = "label_plecEdytowanegoPacjenta";
            label_plecEdytowanegoPacjenta.Size = new Size(95, 21);
            label_plecEdytowanegoPacjenta.TabIndex = 16;
            label_plecEdytowanegoPacjenta.Text = "Płeć";
            label_plecEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_dataUrodzeniaEdytowanegoPacjenta
            // 
            label_dataUrodzeniaEdytowanegoPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_dataUrodzeniaEdytowanegoPacjenta.Location = new Point(9, 323);
            label_dataUrodzeniaEdytowanegoPacjenta.Name = "label_dataUrodzeniaEdytowanegoPacjenta";
            label_dataUrodzeniaEdytowanegoPacjenta.Size = new Size(103, 21);
            label_dataUrodzeniaEdytowanegoPacjenta.TabIndex = 18;
            label_dataUrodzeniaEdytowanegoPacjenta.Text = "Data urodzenia";
            label_dataUrodzeniaEdytowanegoPacjenta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_edycjaPacjenta
            // 
            btn_edycjaPacjenta.Enabled = false;
            btn_edycjaPacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_edycjaPacjenta.Location = new Point(925, 872);
            btn_edycjaPacjenta.Name = "btn_edycjaPacjenta";
            btn_edycjaPacjenta.Size = new Size(386, 46);
            btn_edycjaPacjenta.TabIndex = 34;
            btn_edycjaPacjenta.Text = "Edytuj";
            btn_edycjaPacjenta.UseVisualStyleBackColor = true;
            btn_edycjaPacjenta.Visible = false;
            btn_edycjaPacjenta.Click += btn_edycjaPacjenta_Click;
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
            btn_wrocDoMenuGlownego.TabIndex = 35;
            btn_wrocDoMenuGlownego.Text = "Menu Główne";
            btn_wrocDoMenuGlownego.UseVisualStyleBackColor = false;
            btn_wrocDoMenuGlownego.Click += btn_wrocDoMenuGlownego_Click;
            // 
            // label_usuwaniePacjenta
            // 
            label_usuwaniePacjenta.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_usuwaniePacjenta.Location = new Point(336, 491);
            label_usuwaniePacjenta.Name = "label_usuwaniePacjenta";
            label_usuwaniePacjenta.Size = new Size(254, 27);
            label_usuwaniePacjenta.TabIndex = 36;
            label_usuwaniePacjenta.Text = "Wybierz pacjenta do usunięcia";
            label_usuwaniePacjenta.Visible = false;
            // 
            // btn_usuwaniePacjenta
            // 
            btn_usuwaniePacjenta.Enabled = false;
            btn_usuwaniePacjenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_usuwaniePacjenta.Location = new Point(925, 872);
            btn_usuwaniePacjenta.Name = "btn_usuwaniePacjenta";
            btn_usuwaniePacjenta.Size = new Size(386, 46);
            btn_usuwaniePacjenta.TabIndex = 37;
            btn_usuwaniePacjenta.Text = "Usuń";
            btn_usuwaniePacjenta.UseVisualStyleBackColor = true;
            btn_usuwaniePacjenta.Visible = false;
            btn_usuwaniePacjenta.Click += btn_usuwaniePacjenta_Click;
            // 
            // label_pacjentDoEdycji
            // 
            label_pacjentDoEdycji.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_pacjentDoEdycji.Location = new Point(336, 491);
            label_pacjentDoEdycji.Name = "label_pacjentDoEdycji";
            label_pacjentDoEdycji.Size = new Size(275, 27);
            label_pacjentDoEdycji.TabIndex = 38;
            label_pacjentDoEdycji.Text = "Wybierz pacjenta do edytowania";
            label_pacjentDoEdycji.Visible = false;
            // 
            // Menu_Pacjenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1917, 1011);
            Controls.Add(btn_cofnijDoMenuPacjentow);
            Controls.Add(dataGridView_listaPacjentow);
            Controls.Add(label_pacjentDoEdycji);
            Controls.Add(btn_wrocDoMenuGlownego);
            Controls.Add(label_VetAnimal);
            Controls.Add(label_usuwaniePacjenta);
            Controls.Add(label_ListaPacjentow);
            Controls.Add(btn_usuwaniePacjenta);
            Controls.Add(btn_edycjaPacjenta);
            Controls.Add(panel_edycjaPacjenta);
            Controls.Add(panel_Pacjenci);
            Controls.Add(panel_NowyPacjent);
            Name = "Menu_Pacjenci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacjenci";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Pacjenci_Load;
            panel_Pacjenci.ResumeLayout(false);
            panel_NowyPacjent.ResumeLayout(false);
            panel_NowyPacjent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_listaPacjentow).EndInit();
            panel_edycjaPacjenta.ResumeLayout(false);
            panel_edycjaPacjenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_VetAnimal;
        private Panel panel_Pacjenci;
        private Button btn_ListaPacjentow;
        private Button btn_UsunPacjenta;
        private Button btn_EdytujPacjenta;
        private Button btn_DodajPacjenta;
        private Panel panel_NowyPacjent;
        private TextBox textBox_idPacjenta;
        private Label label_idPacjenta;
        private DateTimePicker dateTimePicker_DataUrodzeniaPacjenta;
        private Label label_NowyPacjent;
        private Label label_ImiePacjenta;
        private TextBox textBox_ImiePacjenta;
        private ComboBox comboBox_GatunekPacjenta;
        private TextBox textBox_RasaPacjenta;
        private Button btn_ZapiszPacjenta;
        private Label label_GatunekPacjenta;
        private TextBox textBox_WagaPacjenta;
        private Label label_WagaPacjenta;
        private Label label_RasaPacjenta;
        private Label label_PlecPacjenta;
        private Label label_DataUrodzenia;
        private Button btn_cofnijDoMenuPacjentow;
        private ComboBox comboBox_Plec;
        private ComboBox comboBox_ListaWlascicieli;
        private Label label_WlascicielPacjenta;
        private DataGridView dataGridView_listaPacjentow;
        private Label label_ListaPacjentow;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel_edycjaPacjenta;
        private ComboBox comboBox_wlascicielEdytowanegoPacjenta;
        private Label label_wlascicielEdytowanegoPacjenta;
        private ComboBox comboBox_plecEdytowanegoPacjenta;
        private TextBox textBox_idEdytowanegoPacjenta;
        private Label label_idEdytowanegoPacjenta;
        private DateTimePicker dateTimePicker_dataUrodzeniaEdytowanegoPacjenta;
        private Label label_edycjaPacjenta;
        private Label label_imieEdytowanegoPacjenta;
        private TextBox textBox_imieEdytowanegoPacjenta;
        private ComboBox comboBox_gatunekEdytowanegoPacjenta;
        private TextBox textBox_rasaEdytowanegoPacjenta;
        private Button btn_zapiszEdytowanegoPacjenta;
        private Label label_gatunekEdytowanegoPacjenta;
        private TextBox textBox_wagaEdytowanegoPacjenta;
        private Label label_wagaEdytowanegoPacjenta;
        private Label label_rasaEdytowanegoPacjenta;
        private Label label_plecEdytowanegoPacjenta;
        private Label label_dataUrodzeniaEdytowanegoPacjenta;
        private Button btn_edycjaPacjenta;
        private Button btn_wrocDoMenuGlownego;
        private Label label_usuwaniePacjenta;
        private Button btn_usuwaniePacjenta;
        private Label label_pacjentDoEdycji;
    }
}