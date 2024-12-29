namespace Przychodnia
{
    partial class Logowanie
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
            panel1 = new Panel();
            btn_zaloguj = new Button();
            textBox_haslo = new TextBox();
            textBox_login = new TextBox();
            label_haslo = new Label();
            label_login = new Label();
            label_logowanie = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_zaloguj);
            panel1.Controls.Add(textBox_haslo);
            panel1.Controls.Add(textBox_login);
            panel1.Controls.Add(label_haslo);
            panel1.Controls.Add(label_login);
            panel1.Controls.Add(label_logowanie);
            panel1.Location = new Point(120, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 305);
            panel1.TabIndex = 0;
            // 
            // btn_zaloguj
            // 
            btn_zaloguj.Location = new Point(225, 231);
            btn_zaloguj.Name = "btn_zaloguj";
            btn_zaloguj.Size = new Size(156, 42);
            btn_zaloguj.TabIndex = 5;
            btn_zaloguj.Text = "Zaloguj";
            btn_zaloguj.UseVisualStyleBackColor = true;
            btn_zaloguj.Click += btn_zaloguj_Click;
            // 
            // textBox_haslo
            // 
            textBox_haslo.Location = new Point(109, 154);
            textBox_haslo.Name = "textBox_haslo";
            textBox_haslo.PasswordChar = '*';
            textBox_haslo.Size = new Size(210, 23);
            textBox_haslo.TabIndex = 4;
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(109, 102);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(210, 23);
            textBox_login.TabIndex = 3;
            // 
            // label_haslo
            // 
            label_haslo.AutoSize = true;
            label_haslo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_haslo.Location = new Point(40, 152);
            label_haslo.Name = "label_haslo";
            label_haslo.Size = new Size(63, 25);
            label_haslo.TabIndex = 2;
            label_haslo.Text = "Hasło:";
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_login.Location = new Point(40, 100);
            label_login.Name = "label_login";
            label_login.Size = new Size(63, 25);
            label_login.TabIndex = 1;
            label_login.Text = "Login:";
            // 
            // label_logowanie
            // 
            label_logowanie.BackColor = SystemColors.MenuHighlight;
            label_logowanie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_logowanie.Location = new Point(-5, 0);
            label_logowanie.Name = "label_logowanie";
            label_logowanie.Size = new Size(585, 52);
            label_logowanie.TabIndex = 0;
            label_logowanie.Text = "VetAnimal";
            label_logowanie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Logowanie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logowanie";
            Load += Logowanie_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox_haslo;
        private TextBox textBox_login;
        private Label label_haslo;
        private Label label_login;
        private Label label_logowanie;
        private Button btn_zaloguj;
    }
}