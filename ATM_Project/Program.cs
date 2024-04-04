using ATMBusiness;

namespace ATM_Project
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
            ApplicationConfiguration.Initialize();

            clsPerson person = clsPerson.findPersonByID(1);

            Application.Run(new frmLoginScreen());
        }
    }
}