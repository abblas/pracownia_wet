namespace Przychodnia
{
    partial class Przychodnia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_VetAnimal = new Label();
            btn_Wizyty = new Button();
            btn_Pacjenci = new Button();
            btn_Wlasciciele = new Button();
            btn_Lekarze = new Button();
            btn_zakonczProgram = new Button();
            btn_wrocDoMenuGlownego = new Button();
            btn_wyloguj = new Button();
            SuspendLayout();
            // 
            // label_VetAnimal
            // 
            label_VetAnimal.BackColor = SystemColors.HotTrack;
            label_VetAnimal.Dock = DockStyle.Left;
            label_VetAnimal.Font = new Font("Sitka Banner", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_VetAnimal.Location = new Point(0, 0);
            label_VetAnimal.Name = "label_VetAnimal";
            label_VetAnimal.Size = new Size(321, 851);
            label_VetAnimal.TabIndex = 0;
            label_VetAnimal.Text = "VetAnimal";
            label_VetAnimal.TextAlign = ContentAlignment.TopCenter;
            label_VetAnimal.Click += label_VetAnimal_Click;
            // 
            // btn_Wizyty
            // 
            btn_Wizyty.BackColor = SystemColors.Highlight;
            btn_Wizyty.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Wizyty.ForeColor = SystemColors.ButtonFace;
            btn_Wizyty.ImageAlign = ContentAlignment.TopCenter;
            btn_Wizyty.Location = new Point(95, 160);
            btn_Wizyty.Name = "btn_Wizyty";
            btn_Wizyty.Size = new Size(129, 34);
            btn_Wizyty.TabIndex = 1;
            btn_Wizyty.Text = "Wizyty";
            btn_Wizyty.UseVisualStyleBackColor = false;
            btn_Wizyty.Click += btn_Wizyty_Click;
            // 
            // btn_Pacjenci
            // 
            btn_Pacjenci.BackColor = SystemColors.Highlight;
            btn_Pacjenci.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pacjenci.ForeColor = SystemColors.ButtonFace;
            btn_Pacjenci.ImageAlign = ContentAlignment.TopCenter;
            btn_Pacjenci.Location = new Point(95, 220);
            btn_Pacjenci.Name = "btn_Pacjenci";
            btn_Pacjenci.Size = new Size(129, 34);
            btn_Pacjenci.TabIndex = 2;
            btn_Pacjenci.Text = "Pacjenci";
            btn_Pacjenci.UseVisualStyleBackColor = false;
            btn_Pacjenci.Click += btn_Pacjenci_Click;
            // 
            // btn_Wlasciciele
            // 
            btn_Wlasciciele.BackColor = SystemColors.Highlight;
            btn_Wlasciciele.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Wlasciciele.ForeColor = SystemColors.ButtonFace;
            btn_Wlasciciele.ImageAlign = ContentAlignment.TopCenter;
            btn_Wlasciciele.Location = new Point(95, 280);
            btn_Wlasciciele.Name = "btn_Wlasciciele";
            btn_Wlasciciele.Size = new Size(129, 34);
            btn_Wlasciciele.TabIndex = 3;
            btn_Wlasciciele.Text = "Właściciele";
            btn_Wlasciciele.UseVisualStyleBackColor = false;
            btn_Wlasciciele.Click += btn_Wlasciciele_Click;
            // 
            // btn_Lekarze
            // 
            btn_Lekarze.BackColor = SystemColors.Highlight;
            btn_Lekarze.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Lekarze.ForeColor = SystemColors.ButtonFace;
            btn_Lekarze.ImageAlign = ContentAlignment.TopCenter;
            btn_Lekarze.Location = new Point(95, 340);
            btn_Lekarze.Name = "btn_Lekarze";
            btn_Lekarze.Size = new Size(129, 34);
            btn_Lekarze.TabIndex = 4;
            btn_Lekarze.Text = "Lekarze";
            btn_Lekarze.UseVisualStyleBackColor = false;
            btn_Lekarze.Click += btn_Lekarze_Click;
            // 
            // btn_zakonczProgram
            // 
            btn_zakonczProgram.BackColor = SystemColors.Highlight;
            btn_zakonczProgram.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_zakonczProgram.ForeColor = SystemColors.ButtonFace;
            btn_zakonczProgram.ImageAlign = ContentAlignment.TopCenter;
            btn_zakonczProgram.Location = new Point(95, 793);
            btn_zakonczProgram.Name = "btn_zakonczProgram";
            btn_zakonczProgram.Size = new Size(129, 34);
            btn_zakonczProgram.TabIndex = 6;
            btn_zakonczProgram.Text = "Wyjście";
            btn_zakonczProgram.UseVisualStyleBackColor = false;
            btn_zakonczProgram.Click += btn_zakonczProgram_Click;
            // 
            // btn_wrocDoMenuGlownego
            // 
            btn_wrocDoMenuGlownego.BackColor = SystemColors.Highlight;
            btn_wrocDoMenuGlownego.Enabled = false;
            btn_wrocDoMenuGlownego.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_wrocDoMenuGlownego.ForeColor = SystemColors.ButtonFace;
            btn_wrocDoMenuGlownego.ImageAlign = ContentAlignment.TopCenter;
            btn_wrocDoMenuGlownego.Location = new Point(95, 100);
            btn_wrocDoMenuGlownego.Name = "btn_wrocDoMenuGlownego";
            btn_wrocDoMenuGlownego.Size = new Size(129, 34);
            btn_wrocDoMenuGlownego.TabIndex = 33;
            btn_wrocDoMenuGlownego.Text = "Menu Główne";
            btn_wrocDoMenuGlownego.UseVisualStyleBackColor = false;
            // 
            // btn_wyloguj
            // 
            btn_wyloguj.BackColor = SystemColors.Highlight;
            btn_wyloguj.Font = new Font("DejaVu Sans Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_wyloguj.ForeColor = SystemColors.ButtonFace;
            btn_wyloguj.ImageAlign = ContentAlignment.TopCenter;
            btn_wyloguj.Location = new Point(95, 733);
            btn_wyloguj.Name = "btn_wyloguj";
            btn_wyloguj.Size = new Size(129, 34);
            btn_wyloguj.TabIndex = 5;
            btn_wyloguj.Text = "Wyloguj";
            btn_wyloguj.UseVisualStyleBackColor = false;
            btn_wyloguj.Click += btn_wyloguj_Click;
            // 
            // Przychodnia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1582, 851);
            Controls.Add(btn_wyloguj);
            Controls.Add(btn_wrocDoMenuGlownego);
            Controls.Add(btn_zakonczProgram);
            Controls.Add(btn_Lekarze);
            Controls.Add(btn_Wlasciciele);
            Controls.Add(btn_Pacjenci);
            Controls.Add(btn_Wizyty);
            Controls.Add(label_VetAnimal);
            Name = "Przychodnia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VetAnimal";
            WindowState = FormWindowState.Maximized;
            Load += Przychodnia_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label_VetAnimal;
        private Button btn_Wizyty;
        private Button btn_Pacjenci;
        private Button btn_Wlasciciele;
        private Button btn_Lekarze;
        private Button btn_zakonczProgram;
        private Button btn_wrocDoMenuGlownego;
        private Button btn_wyloguj;
    }
}
