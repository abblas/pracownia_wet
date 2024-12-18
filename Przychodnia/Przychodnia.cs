using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Przychodnia
{
    public partial class Przychodnia : Form
    {
        public Przychodnia()
        {
            InitializeComponent();
        }
        private void label_VetAnimal_Click(object sender, EventArgs e)
        {

        }
        private void btn_Wizyty_Click(object sender, EventArgs e)
        {
            Menu_Wizyty menu_Wizyty = new Menu_Wizyty();
            menu_Wizyty.Show();
        }
        private void btn_Pacjenci_Click(object sender, EventArgs e)
        {
            Menu_Pacjenci menu_Pacjenci = new Menu_Pacjenci();
            menu_Pacjenci.Show();
        }
        private void btn_Wlasciciele_Click(object sender, EventArgs e)
        {
            Menu_Wlascicieli menu_wlascicieli = new Menu_Wlascicieli();
            menu_wlascicieli.Show();
        }
        private void Przychodnia_Load(object sender, EventArgs e)
        {

        }
        private void btn_zakonczProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lekarze_Click(object sender, EventArgs e)
        {
            Menu_Lekarze menu_Lekarze = new Menu_Lekarze();
            menu_Lekarze.Show();
        }
    }
}

        