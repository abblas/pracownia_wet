namespace Przychodnia
{
    partial class Menu_Wizyty
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label_VetAnimal = new Label();
            panel_Wizyty = new Panel();
            btn_ListaWizyt = new Button();
            btn_UsunWizyte = new Button();
            btn_EdytujWizyte = new Button();
            btn_DodajWizyte = new Button();
            panel_NowaWizyta = new Panel();
            comboBox_lekarz = new ComboBox();
            comboBox_wlasciciel = new ComboBox();
            comboBox_Pacjent = new ComboBox();
            dateTimePicker_godzinaWizyty = new DateTimePicker();
            label_godzinaWizyty = new Label();
            btn_ZapiszWizyte = new Button();
            dateTimePicker_dataWizyty = new DateTimePicker();
            comboBox_TypWizyty = new ComboBox();
            label_NowaWizyta = new Label();
            label_TypWizyty = new Label();
            label_IdWizyty = new Label();
            textBox_IdWizyty = new TextBox();
            label_Lekarz = new Label();
            label_DataWizyty = new Label();
            label_Pacjent = new Label();
            label_Wlasciciel = new Label();
            pacjentBindingSource = new BindingSource(components);
            label_ListaWizyt = new Label();
            dataGridView_listaWizyt = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btn_cofnijDoMenuWizyt = new Button();
            btn_wrocDoMenuGlownego = new Button();
            btn_edycjaWizyty = new Button();
            panel_edycjaWizyty = new Panel();
            comboBox_lekarzEdytowanejWizyty = new ComboBox();
            comboBox_wlascicielEdytowanejWizyty = new ComboBox();
            comboBox_pacjentEdytowanejWizyty = new ComboBox();
            dateTimePicker_godzinaEdytowanejWizyty = new DateTimePicker();
            label_godzinaEdytowanejWizyty = new Label();
            btn_zapiszEdytowanaWizyte = new Button();
            dateTimePicker_dataEdytowanejWizyty = new DateTimePicker();
            comboBox_typEdytowanejWizyty = new ComboBox();
            label_EdycjaWizyty = new Label();
            label_typEdytowanejWizyty = new Label();
            label_idEdytowanejWizyty = new Label();
            textBox_idEdytowanejWizyty = new TextBox();
            label_lekarzEdytowanejWizyty = new Label();
            label_dataEdytowanejWizyty = new Label();
            label_pacjentEdytowanejWizyty = new Label();
            label_wlascicielEdytowanejWizyty = new Label();
            btn_usuwanieWizyty = new Button();
            label_usuwanieWizyty = new Label();
            label_edytowanieWizyty = new Label();
            panel_Wizyty.SuspendLayout();
            panel_NowaWizyta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pacjentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_listaWizyt).BeginInit();
            panel_edycjaWizyty.SuspendLayout();
            SuspendLayout();
            // 
            // label_VetAnimal
            // 
            label_VetAnimal.BackColor = SystemColors.HotTrack;
            label_VetAnimal.Dock = DockStyle.Left;
            label_VetAnimal.Font = new Font("Sitka Banner", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_VetAnimal.Location = new Point(0, 0);
            label_VetAnimal.Name = "label_VetAnimal";
            label_VetAnimal.Size = new Size(321, 894);
            label_VetAnimal.TabIndex = 1;
            label_VetAnimal.Text = "VetAnimal";
            label_VetAnimal.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel_Wizyty
            // 
            panel_Wizyty.Controls.Add(btn_ListaWizyt);
            panel_Wizyty.Controls.Add(btn_UsunWizyte);
            panel_Wizyty.Controls.Add(btn_EdytujWizyte);
            panel_Wizyty.Controls.Add(btn_DodajWizyte);
            panel_Wizyty.Location = new Point(327, 12);
            panel_Wizyty.Name = "panel_Wizyty";
            panel_Wizyty.Size = new Size(772, 224);
            panel_Wizyty.TabIndex = 24;
            // 
            // btn_ListaWizyt
            // 
            btn_ListaWizyt.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_ListaWizyt.Location = new Point(3, 4);
            btn_ListaWizyt.Name = "btn_ListaWizyt";
            btn_ListaWizyt.Size = new Size(367, 94);
            btn_ListaWizyt.TabIndex = 1;
            btn_ListaWizyt.Text = "Lista wizyt";
            btn_ListaWizyt.UseVisualStyleBackColor = true;
            btn_ListaWizyt.Click += btn_ListaWizyt_Click;
            // 
            // btn_UsunWizyte
            // 
            btn_UsunWizyte.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_UsunWizyte.Location = new Point(397, 126);
            btn_UsunWizyte.Name = "btn_UsunWizyte";
            btn_UsunWizyte.Size = new Size(367, 94);
            btn_UsunWizyte.TabIndex = 4;
            btn_UsunWizyte.Text = "Usuń wizytę";
            btn_UsunWizyte.UseVisualStyleBackColor = true;
            btn_UsunWizyte.Click += btn_UsunWizyte_Click;
            // 
            // btn_EdytujWizyte
            // 
            btn_EdytujWizyte.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_EdytujWizyte.Location = new Point(5, 126);
            btn_EdytujWizyte.Name = "btn_EdytujWizyte";
            btn_EdytujWizyte.Size = new Size(367, 94);
            btn_EdytujWizyte.TabIndex = 3;
            btn_EdytujWizyte.Text = "Edytuj wizytę";
            btn_EdytujWizyte.UseVisualStyleBackColor = true;
            btn_EdytujWizyte.Click += btn_EdytujWizyte_Click;
            // 
            // btn_DodajWizyte
            // 
            btn_DodajWizyte.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_DodajWizyte.Location = new Point(397, 4);
            btn_DodajWizyte.Name = "btn_DodajWizyte";
            btn_DodajWizyte.Size = new Size(367, 94);
            btn_DodajWizyte.TabIndex = 2;
            btn_DodajWizyte.Text = "Dodaj wizytę";
            btn_DodajWizyte.UseVisualStyleBackColor = true;
            btn_DodajWizyte.Click += btn_DodajWizyte_Click;
            // 
            // panel_NowaWizyta
            // 
            panel_NowaWizyta.Controls.Add(comboBox_lekarz);
            panel_NowaWizyta.Controls.Add(comboBox_wlasciciel);
            panel_NowaWizyta.Controls.Add(comboBox_Pacjent);
            panel_NowaWizyta.Controls.Add(dateTimePicker_godzinaWizyty);
            panel_NowaWizyta.Controls.Add(label_godzinaWizyty);
            panel_NowaWizyta.Controls.Add(btn_ZapiszWizyte);
            panel_NowaWizyta.Controls.Add(dateTimePicker_dataWizyty);
            panel_NowaWizyta.Controls.Add(comboBox_TypWizyty);
            panel_NowaWizyta.Controls.Add(label_NowaWizyta);
            panel_NowaWizyta.Controls.Add(label_TypWizyty);
            panel_NowaWizyta.Controls.Add(label_IdWizyty);
            panel_NowaWizyta.Controls.Add(textBox_IdWizyty);
            panel_NowaWizyta.Controls.Add(label_Lekarz);
            panel_NowaWizyta.Controls.Add(label_DataWizyty);
            panel_NowaWizyta.Controls.Add(label_Pacjent);
            panel_NowaWizyta.Controls.Add(label_Wlasciciel);
            panel_NowaWizyta.Location = new Point(327, 12);
            panel_NowaWizyta.Name = "panel_NowaWizyta";
            panel_NowaWizyta.Size = new Size(1465, 247);
            panel_NowaWizyta.TabIndex = 25;
            panel_NowaWizyta.Visible = false;
            // 
            // comboBox_lekarz
            // 
            comboBox_lekarz.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_lekarz.FormattingEnabled = true;
            comboBox_lekarz.Location = new Point(1060, 89);
            comboBox_lekarz.Name = "comboBox_lekarz";
            comboBox_lekarz.Size = new Size(238, 38);
            comboBox_lekarz.Sorted = true;
            comboBox_lekarz.TabIndex = 11;
            // 
            // comboBox_wlasciciel
            // 
            comboBox_wlasciciel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_wlasciciel.FormattingEnabled = true;
            comboBox_wlasciciel.Location = new Point(801, 90);
            comboBox_wlasciciel.Name = "comboBox_wlasciciel";
            comboBox_wlasciciel.Size = new Size(238, 38);
            comboBox_wlasciciel.Sorted = true;
            comboBox_wlasciciel.TabIndex = 10;
            // 
            // comboBox_Pacjent
            // 
            comboBox_Pacjent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_Pacjent.FormattingEnabled = true;
            comboBox_Pacjent.Location = new Point(627, 90);
            comboBox_Pacjent.Name = "comboBox_Pacjent";
            comboBox_Pacjent.Size = new Size(145, 38);
            comboBox_Pacjent.Sorted = true;
            comboBox_Pacjent.TabIndex = 9;
            comboBox_Pacjent.SelectedIndexChanged += comboBox_Pacjent_SelectedIndexChanged;
            // 
            // dateTimePicker_godzinaWizyty
            // 
            dateTimePicker_godzinaWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_godzinaWizyty.Format = DateTimePickerFormat.Time;
            dateTimePicker_godzinaWizyty.Location = new Point(466, 92);
            dateTimePicker_godzinaWizyty.Name = "dateTimePicker_godzinaWizyty";
            dateTimePicker_godzinaWizyty.ShowUpDown = true;
            dateTimePicker_godzinaWizyty.Size = new Size(141, 35);
            dateTimePicker_godzinaWizyty.TabIndex = 8;
            // 
            // label_godzinaWizyty
            // 
            label_godzinaWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_godzinaWizyty.Location = new Point(466, 69);
            label_godzinaWizyty.Name = "label_godzinaWizyty";
            label_godzinaWizyty.Size = new Size(96, 21);
            label_godzinaWizyty.TabIndex = 23;
            label_godzinaWizyty.Text = "Godzina wizyty";
            // 
            // btn_ZapiszWizyte
            // 
            btn_ZapiszWizyte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_ZapiszWizyte.Location = new Point(1332, 195);
            btn_ZapiszWizyte.Name = "btn_ZapiszWizyte";
            btn_ZapiszWizyte.Size = new Size(130, 46);
            btn_ZapiszWizyte.TabIndex = 12;
            btn_ZapiszWizyte.Text = "Zapisz wizytę";
            btn_ZapiszWizyte.UseVisualStyleBackColor = true;
            btn_ZapiszWizyte.Click += btn_ZapiszWizyte_Click;
            // 
            // dateTimePicker_dataWizyty
            // 
            dateTimePicker_dataWizyty.Checked = false;
            dateTimePicker_dataWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_dataWizyty.Format = DateTimePickerFormat.Short;
            dateTimePicker_dataWizyty.ImeMode = ImeMode.NoControl;
            dateTimePicker_dataWizyty.Location = new Point(296, 93);
            dateTimePicker_dataWizyty.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dateTimePicker_dataWizyty.MinDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dateTimePicker_dataWizyty.Name = "dateTimePicker_dataWizyty";
            dateTimePicker_dataWizyty.Size = new Size(152, 35);
            dateTimePicker_dataWizyty.TabIndex = 7;
            dateTimePicker_dataWizyty.Value = new DateTime(2024, 11, 22, 0, 0, 0, 0);
            dateTimePicker_dataWizyty.ValueChanged += dateTimePicker_dataWizyty_ValueChanged;
            // 
            // comboBox_TypWizyty
            // 
            comboBox_TypWizyty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TypWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_TypWizyty.FormattingEnabled = true;
            comboBox_TypWizyty.Items.AddRange(new object[] { "Badanie", "Kontrola", "Szczepienie", "Zabieg" });
            comboBox_TypWizyty.Location = new Point(153, 93);
            comboBox_TypWizyty.Name = "comboBox_TypWizyty";
            comboBox_TypWizyty.Size = new Size(119, 38);
            comboBox_TypWizyty.Sorted = true;
            comboBox_TypWizyty.TabIndex = 6;
            // 
            // label_NowaWizyta
            // 
            label_NowaWizyta.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_NowaWizyta.Location = new Point(15, 16);
            label_NowaWizyta.Name = "label_NowaWizyta";
            label_NowaWizyta.Size = new Size(115, 27);
            label_NowaWizyta.TabIndex = 11;
            label_NowaWizyta.Text = "Nowa wizyta";
            label_NowaWizyta.TextAlign = ContentAlignment.MiddleLeft;
            label_NowaWizyta.Visible = false;
            // 
            // label_TypWizyty
            // 
            label_TypWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_TypWizyty.Location = new Point(153, 69);
            label_TypWizyty.Name = "label_TypWizyty";
            label_TypWizyty.Size = new Size(74, 21);
            label_TypWizyty.TabIndex = 22;
            label_TypWizyty.Text = "Typ wizyty";
            // 
            // label_IdWizyty
            // 
            label_IdWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_IdWizyty.Location = new Point(13, 69);
            label_IdWizyty.Name = "label_IdWizyty";
            label_IdWizyty.Size = new Size(49, 21);
            label_IdWizyty.TabIndex = 12;
            label_IdWizyty.Text = "Numer";
            // 
            // textBox_IdWizyty
            // 
            textBox_IdWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_IdWizyty.Location = new Point(15, 93);
            textBox_IdWizyty.Multiline = true;
            textBox_IdWizyty.Name = "textBox_IdWizyty";
            textBox_IdWizyty.ReadOnly = true;
            textBox_IdWizyty.Size = new Size(95, 38);
            textBox_IdWizyty.TabIndex = 5;
            // 
            // label_Lekarz
            // 
            label_Lekarz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_Lekarz.Location = new Point(1060, 67);
            label_Lekarz.Name = "label_Lekarz";
            label_Lekarz.Size = new Size(74, 21);
            label_Lekarz.TabIndex = 20;
            label_Lekarz.Text = "Lekarz";
            // 
            // label_DataWizyty
            // 
            label_DataWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_DataWizyty.Location = new Point(296, 69);
            label_DataWizyty.Name = "label_DataWizyty";
            label_DataWizyty.Size = new Size(74, 21);
            label_DataWizyty.TabIndex = 14;
            label_DataWizyty.Text = "Data wizyty";
            // 
            // label_Pacjent
            // 
            label_Pacjent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_Pacjent.Location = new Point(627, 68);
            label_Pacjent.Name = "label_Pacjent";
            label_Pacjent.Size = new Size(74, 21);
            label_Pacjent.TabIndex = 16;
            label_Pacjent.Text = "Pacjent";
            // 
            // label_Wlasciciel
            // 
            label_Wlasciciel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_Wlasciciel.Location = new Point(801, 67);
            label_Wlasciciel.Name = "label_Wlasciciel";
            label_Wlasciciel.Size = new Size(74, 21);
            label_Wlasciciel.TabIndex = 18;
            label_Wlasciciel.Text = "Właściciel";
            // 
            // pacjentBindingSource
            // 
            pacjentBindingSource.DataSource = typeof(Pacjent);
            // 
            // label_ListaWizyt
            // 
            label_ListaWizyt.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_ListaWizyt.Location = new Point(342, 272);
            label_ListaWizyt.Name = "label_ListaWizyt";
            label_ListaWizyt.Size = new Size(97, 27);
            label_ListaWizyt.TabIndex = 26;
            label_ListaWizyt.Text = "Lista wizyt";
            label_ListaWizyt.Visible = false;
            // 
            // dataGridView_listaWizyt
            // 
            dataGridView_listaWizyt.AllowUserToAddRows = false;
            dataGridView_listaWizyt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_listaWizyt.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_listaWizyt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView_listaWizyt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_listaWizyt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_listaWizyt.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_listaWizyt.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_listaWizyt.Location = new Point(327, 302);
            dataGridView_listaWizyt.MultiSelect = false;
            dataGridView_listaWizyt.Name = "dataGridView_listaWizyt";
            dataGridView_listaWizyt.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView_listaWizyt.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_listaWizyt.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_listaWizyt.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_listaWizyt.RowTemplate.Height = 50;
            dataGridView_listaWizyt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_listaWizyt.Size = new Size(1289, 429);
            dataGridView_listaWizyt.StandardTab = true;
            dataGridView_listaWizyt.TabIndex = 30;
            dataGridView_listaWizyt.Visible = false;
            // 
            // Column6
            // 
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // btn_cofnijDoMenuWizyt
            // 
            btn_cofnijDoMenuWizyt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_cofnijDoMenuWizyt.Location = new Point(1476, 842);
            btn_cofnijDoMenuWizyt.Name = "btn_cofnijDoMenuWizyt";
            btn_cofnijDoMenuWizyt.Size = new Size(130, 46);
            btn_cofnijDoMenuWizyt.TabIndex = 31;
            btn_cofnijDoMenuWizyt.Text = "Wstecz";
            btn_cofnijDoMenuWizyt.UseVisualStyleBackColor = true;
            btn_cofnijDoMenuWizyt.Visible = false;
            btn_cofnijDoMenuWizyt.Click += btn_cofnijDoMenuWizyt_Click;
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
            btn_wrocDoMenuGlownego.TabIndex = 32;
            btn_wrocDoMenuGlownego.Text = "Menu Główne";
            btn_wrocDoMenuGlownego.UseVisualStyleBackColor = false;
            btn_wrocDoMenuGlownego.Click += btn_wrocDoMenuGlownego_Click;
            // 
            // btn_edycjaWizyty
            // 
            btn_edycjaWizyty.Enabled = false;
            btn_edycjaWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_edycjaWizyty.Location = new Point(838, 748);
            btn_edycjaWizyty.Name = "btn_edycjaWizyty";
            btn_edycjaWizyty.Size = new Size(291, 46);
            btn_edycjaWizyty.TabIndex = 33;
            btn_edycjaWizyty.Text = "Edytuj";
            btn_edycjaWizyty.UseVisualStyleBackColor = true;
            btn_edycjaWizyty.Visible = false;
            btn_edycjaWizyty.Click += btn_edycjaWizyty_Click;
            // 
            // panel_edycjaWizyty
            // 
            panel_edycjaWizyty.Controls.Add(comboBox_lekarzEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(comboBox_wlascicielEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(comboBox_pacjentEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(dateTimePicker_godzinaEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(label_godzinaEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(btn_zapiszEdytowanaWizyte);
            panel_edycjaWizyty.Controls.Add(dateTimePicker_dataEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(comboBox_typEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(label_EdycjaWizyty);
            panel_edycjaWizyty.Controls.Add(label_typEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(label_idEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(textBox_idEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(label_lekarzEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(label_dataEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(label_pacjentEdytowanejWizyty);
            panel_edycjaWizyty.Controls.Add(label_wlascicielEdytowanejWizyty);
            panel_edycjaWizyty.Location = new Point(327, 9);
            panel_edycjaWizyty.Name = "panel_edycjaWizyty";
            panel_edycjaWizyty.Size = new Size(1468, 247);
            panel_edycjaWizyty.TabIndex = 26;
            panel_edycjaWizyty.Visible = false;
            // 
            // comboBox_lekarzEdytowanejWizyty
            // 
            comboBox_lekarzEdytowanejWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_lekarzEdytowanejWizyty.FormattingEnabled = true;
            comboBox_lekarzEdytowanejWizyty.Location = new Point(1079, 89);
            comboBox_lekarzEdytowanejWizyty.Name = "comboBox_lekarzEdytowanejWizyty";
            comboBox_lekarzEdytowanejWizyty.Size = new Size(238, 38);
            comboBox_lekarzEdytowanejWizyty.Sorted = true;
            comboBox_lekarzEdytowanejWizyty.TabIndex = 11;
            // 
            // comboBox_wlascicielEdytowanejWizyty
            // 
            comboBox_wlascicielEdytowanejWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_wlascicielEdytowanejWizyty.FormattingEnabled = true;
            comboBox_wlascicielEdytowanejWizyty.Location = new Point(801, 90);
            comboBox_wlascicielEdytowanejWizyty.Name = "comboBox_wlascicielEdytowanejWizyty";
            comboBox_wlascicielEdytowanejWizyty.Size = new Size(238, 38);
            comboBox_wlascicielEdytowanejWizyty.Sorted = true;
            comboBox_wlascicielEdytowanejWizyty.TabIndex = 10;
            // 
            // comboBox_pacjentEdytowanejWizyty
            // 
            comboBox_pacjentEdytowanejWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_pacjentEdytowanejWizyty.FormattingEnabled = true;
            comboBox_pacjentEdytowanejWizyty.Location = new Point(629, 90);
            comboBox_pacjentEdytowanejWizyty.Name = "comboBox_pacjentEdytowanejWizyty";
            comboBox_pacjentEdytowanejWizyty.Size = new Size(145, 38);
            comboBox_pacjentEdytowanejWizyty.Sorted = true;
            comboBox_pacjentEdytowanejWizyty.TabIndex = 9;
            // 
            // dateTimePicker_godzinaEdytowanejWizyty
            // 
            dateTimePicker_godzinaEdytowanejWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_godzinaEdytowanejWizyty.Format = DateTimePickerFormat.Time;
            dateTimePicker_godzinaEdytowanejWizyty.Location = new Point(466, 92);
            dateTimePicker_godzinaEdytowanejWizyty.Name = "dateTimePicker_godzinaEdytowanejWizyty";
            dateTimePicker_godzinaEdytowanejWizyty.ShowUpDown = true;
            dateTimePicker_godzinaEdytowanejWizyty.Size = new Size(141, 35);
            dateTimePicker_godzinaEdytowanejWizyty.TabIndex = 8;
            // 
            // label_godzinaEdytowanejWizyty
            // 
            label_godzinaEdytowanejWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_godzinaEdytowanejWizyty.Location = new Point(466, 69);
            label_godzinaEdytowanejWizyty.Name = "label_godzinaEdytowanejWizyty";
            label_godzinaEdytowanejWizyty.Size = new Size(96, 21);
            label_godzinaEdytowanejWizyty.TabIndex = 23;
            label_godzinaEdytowanejWizyty.Text = "Godzina wizyty";
            // 
            // btn_zapiszEdytowanaWizyte
            // 
            btn_zapiszEdytowanaWizyte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_zapiszEdytowanaWizyte.Location = new Point(1335, 198);
            btn_zapiszEdytowanaWizyte.Name = "btn_zapiszEdytowanaWizyte";
            btn_zapiszEdytowanaWizyte.Size = new Size(130, 46);
            btn_zapiszEdytowanaWizyte.TabIndex = 12;
            btn_zapiszEdytowanaWizyte.Text = "Zapisz wizytę";
            btn_zapiszEdytowanaWizyte.UseVisualStyleBackColor = true;
            btn_zapiszEdytowanaWizyte.Click += btn_zapiszEdytowanaWizyte_Click;
            // 
            // dateTimePicker_dataEdytowanejWizyty
            // 
            dateTimePicker_dataEdytowanejWizyty.Checked = false;
            dateTimePicker_dataEdytowanejWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateTimePicker_dataEdytowanejWizyty.Format = DateTimePickerFormat.Short;
            dateTimePicker_dataEdytowanejWizyty.ImeMode = ImeMode.NoControl;
            dateTimePicker_dataEdytowanejWizyty.Location = new Point(296, 93);
            dateTimePicker_dataEdytowanejWizyty.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dateTimePicker_dataEdytowanejWizyty.MinDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dateTimePicker_dataEdytowanejWizyty.Name = "dateTimePicker_dataEdytowanejWizyty";
            dateTimePicker_dataEdytowanejWizyty.Size = new Size(152, 35);
            dateTimePicker_dataEdytowanejWizyty.TabIndex = 7;
            dateTimePicker_dataEdytowanejWizyty.Value = new DateTime(2024, 11, 22, 0, 0, 0, 0);
            dateTimePicker_dataEdytowanejWizyty.ValueChanged += dateTimePicker_dataEdytowanejWizyty_ValueChanged;
            // 
            // comboBox_typEdytowanejWizyty
            // 
            comboBox_typEdytowanejWizyty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_typEdytowanejWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            comboBox_typEdytowanejWizyty.FormattingEnabled = true;
            comboBox_typEdytowanejWizyty.Items.AddRange(new object[] { "Badanie", "Kontrola", "Szczepienie", "Zabieg" });
            comboBox_typEdytowanejWizyty.Location = new Point(153, 93);
            comboBox_typEdytowanejWizyty.Name = "comboBox_typEdytowanejWizyty";
            comboBox_typEdytowanejWizyty.Size = new Size(119, 38);
            comboBox_typEdytowanejWizyty.Sorted = true;
            comboBox_typEdytowanejWizyty.TabIndex = 6;
            // 
            // label_EdycjaWizyty
            // 
            label_EdycjaWizyty.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_EdycjaWizyty.Location = new Point(15, 19);
            label_EdycjaWizyty.Name = "label_EdycjaWizyty";
            label_EdycjaWizyty.Size = new Size(124, 27);
            label_EdycjaWizyty.TabIndex = 11;
            label_EdycjaWizyty.Text = "Edytuj wizytę";
            label_EdycjaWizyty.TextAlign = ContentAlignment.MiddleLeft;
            label_EdycjaWizyty.Visible = false;
            // 
            // label_typEdytowanejWizyty
            // 
            label_typEdytowanejWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_typEdytowanejWizyty.Location = new Point(153, 69);
            label_typEdytowanejWizyty.Name = "label_typEdytowanejWizyty";
            label_typEdytowanejWizyty.Size = new Size(74, 21);
            label_typEdytowanejWizyty.TabIndex = 22;
            label_typEdytowanejWizyty.Text = "Typ wizyty";
            // 
            // label_idEdytowanejWizyty
            // 
            label_idEdytowanejWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_idEdytowanejWizyty.Location = new Point(13, 69);
            label_idEdytowanejWizyty.Name = "label_idEdytowanejWizyty";
            label_idEdytowanejWizyty.Size = new Size(49, 21);
            label_idEdytowanejWizyty.TabIndex = 12;
            label_idEdytowanejWizyty.Text = "Numer";
            // 
            // textBox_idEdytowanejWizyty
            // 
            textBox_idEdytowanejWizyty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_idEdytowanejWizyty.Location = new Point(15, 93);
            textBox_idEdytowanejWizyty.Multiline = true;
            textBox_idEdytowanejWizyty.Name = "textBox_idEdytowanejWizyty";
            textBox_idEdytowanejWizyty.ReadOnly = true;
            textBox_idEdytowanejWizyty.Size = new Size(95, 38);
            textBox_idEdytowanejWizyty.TabIndex = 5;
            // 
            // label_lekarzEdytowanejWizyty
            // 
            label_lekarzEdytowanejWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_lekarzEdytowanejWizyty.Location = new Point(1079, 67);
            label_lekarzEdytowanejWizyty.Name = "label_lekarzEdytowanejWizyty";
            label_lekarzEdytowanejWizyty.Size = new Size(74, 21);
            label_lekarzEdytowanejWizyty.TabIndex = 20;
            label_lekarzEdytowanejWizyty.Text = "Lekarz";
            // 
            // label_dataEdytowanejWizyty
            // 
            label_dataEdytowanejWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_dataEdytowanejWizyty.Location = new Point(296, 69);
            label_dataEdytowanejWizyty.Name = "label_dataEdytowanejWizyty";
            label_dataEdytowanejWizyty.Size = new Size(74, 21);
            label_dataEdytowanejWizyty.TabIndex = 14;
            label_dataEdytowanejWizyty.Text = "Data wizyty";
            // 
            // label_pacjentEdytowanejWizyty
            // 
            label_pacjentEdytowanejWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_pacjentEdytowanejWizyty.Location = new Point(627, 68);
            label_pacjentEdytowanejWizyty.Name = "label_pacjentEdytowanejWizyty";
            label_pacjentEdytowanejWizyty.Size = new Size(74, 21);
            label_pacjentEdytowanejWizyty.TabIndex = 16;
            label_pacjentEdytowanejWizyty.Text = "Pacjent";
            // 
            // label_wlascicielEdytowanejWizyty
            // 
            label_wlascicielEdytowanejWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_wlascicielEdytowanejWizyty.Location = new Point(801, 67);
            label_wlascicielEdytowanejWizyty.Name = "label_wlascicielEdytowanejWizyty";
            label_wlascicielEdytowanejWizyty.Size = new Size(74, 21);
            label_wlascicielEdytowanejWizyty.TabIndex = 18;
            label_wlascicielEdytowanejWizyty.Text = "Właściciel";
            // 
            // btn_usuwanieWizyty
            // 
            btn_usuwanieWizyty.Enabled = false;
            btn_usuwanieWizyty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_usuwanieWizyty.Location = new Point(838, 748);
            btn_usuwanieWizyty.Name = "btn_usuwanieWizyty";
            btn_usuwanieWizyty.Size = new Size(291, 46);
            btn_usuwanieWizyty.TabIndex = 34;
            btn_usuwanieWizyty.Text = "Usuń";
            btn_usuwanieWizyty.UseVisualStyleBackColor = true;
            btn_usuwanieWizyty.Visible = false;
            btn_usuwanieWizyty.Click += btn_usuwanieWizyty_Click;
            // 
            // label_usuwanieWizyty
            // 
            label_usuwanieWizyty.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_usuwanieWizyty.Location = new Point(342, 272);
            label_usuwanieWizyty.Name = "label_usuwanieWizyty";
            label_usuwanieWizyty.Size = new Size(236, 27);
            label_usuwanieWizyty.TabIndex = 35;
            label_usuwanieWizyty.Text = "Wybierz wizytę do usunięcia";
            label_usuwanieWizyty.Visible = false;
            // 
            // label_edytowanieWizyty
            // 
            label_edytowanieWizyty.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_edytowanieWizyty.Location = new Point(342, 272);
            label_edytowanieWizyty.Name = "label_edytowanieWizyty";
            label_edytowanieWizyty.Size = new Size(236, 27);
            label_edytowanieWizyty.TabIndex = 36;
            label_edytowanieWizyty.Text = "Wybierz wizytę do edycji";
            label_edytowanieWizyty.Visible = false;
            // 
            // Menu_Wizyty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1808, 894);
            Controls.Add(btn_usuwanieWizyty);
            Controls.Add(btn_edycjaWizyty);
            Controls.Add(btn_wrocDoMenuGlownego);
            Controls.Add(dataGridView_listaWizyt);
            Controls.Add(label_VetAnimal);
            Controls.Add(btn_cofnijDoMenuWizyt);
            Controls.Add(panel_edycjaWizyty);
            Controls.Add(panel_Wizyty);
            Controls.Add(panel_NowaWizyta);
            Controls.Add(label_edytowanieWizyty);
            Controls.Add(label_usuwanieWizyty);
            Controls.Add(label_ListaWizyt);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Name = "Menu_Wizyty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wizyty";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Wizyty_Load;
            panel_Wizyty.ResumeLayout(false);
            panel_NowaWizyta.ResumeLayout(false);
            panel_NowaWizyta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pacjentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_listaWizyt).EndInit();
            panel_edycjaWizyty.ResumeLayout(false);
            panel_edycjaWizyty.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_VetAnimal;
        private Panel panel_Wizyty;
        private Button btn_ListaWizyt;
        private Button btn_UsunWizyte;
        private Button btn_EdytujWizyte;
        private Button btn_DodajWizyte;
        private Panel panel_NowaWizyta;
        private DateTimePicker dateTimePicker_godzinaWizyty;
        private Label label_godzinaWizyty;
        private Button btn_ZapiszWizyte;
        private DateTimePicker dateTimePicker_dataWizyty;
        private ComboBox comboBox_TypWizyty;
        private Label label_NowaWizyta;
        private Label label_TypWizyty;
        private Label label_IdWizyty;
        private TextBox textBox_IdWizyty;
        private Label label_Lekarz;
        private Label label_DataWizyty;
        private Label label_Pacjent;
        private Label label_Wlasciciel;
        private Label label_ListaWizyt;
        private DataGridView dataGridView_listaWizyt;
        private Button btn_cofnijDoMenuWizyt;
        private Button btn_WrocDoMenuGlownego;
        private Button btn_wrocDoMenuGlownego;
        private Button btn_edycjaWizyty;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Panel panel_edycjaWizyty;
        private DateTimePicker dateTimePicker_godzinaEdytowanejWizyty;
        private Label label_godzinaEdytowanejWizyty;
        private Button btn_zapiszEdytowanaWizyte;
        private DateTimePicker dateTimePicker_dataEdytowanejWizyty;
        private ComboBox comboBox_typEdytowanejWizyty;
        private Label label_EdycjaWizyty;
        private Label label_typEdytowanejWizyty;
        private Label label_idEdytowanejWizyty;
        private TextBox textBox_idEdytowanejWizyty;
        private Label label_lekarzEdytowanejWizyty;
        private Label label_dataEdytowanejWizyty;
        private Label label_pacjentEdytowanejWizyty;
        private Label label_wlascicielEdytowanejWizyty;
        private ComboBox comboBox_Pacjent;
        private BindingSource pacjentBindingSource;
        private ComboBox comboBox_pacjentEdytowanejWizyty;
        private Button btn_usuwanieWizyty;
        private Label label_usuwanieWizyty;
        private ComboBox comboBox_wlasciciel;
        private ComboBox comboBox_wlascicielEdytowanejWizyty;
        private ComboBox comboBox_lekarzEdytowanejWizyty;
        private ComboBox comboBox_lekarz;
        private Label label_edytowanieWizyty;
    }
}