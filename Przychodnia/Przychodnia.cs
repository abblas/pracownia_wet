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
            {
                // Wybierz drugi monitor (jeœli istnieje)
                var drugiekran = Screen.AllScreens.FirstOrDefault(s => !s.Primary);

                if (drugiekran != null)
                {
                    // Ustaw pozycjê na drugim monitorze
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = drugiekran.WorkingArea.Location; // Pocz¹tek obszaru roboczego monitora
                    this.Size = drugiekran.WorkingArea.Size;
                }
            }
        }
        private void btn_zakonczProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

        