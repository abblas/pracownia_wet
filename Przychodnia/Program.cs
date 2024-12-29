namespace Przychodnia
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Wyœwietlenie formularza logowania
            using (var logowanie = new Logowanie()) // Tworzymy instancjê formularza logowania
            {
                if (logowanie.ShowDialog() == DialogResult.OK) // Jeœli u¿ytkownik kliknie "Zaloguj"
                {
                    Uzytkownik zalogowanyUzytkownik = logowanie.ZalogowanyUzytkownik;
                    // Uruchamiamy g³ówny formularz po zalogowaniu
                    Application.Run(new Przychodnia(zalogowanyUzytkownik));
                }
                else
                {
                    // Jeœli logowanie siê nie powiod³o, zamykamy aplikacjê
                    Application.Exit();
                }
            }
        }
    }
}
