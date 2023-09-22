using Zatca_CSID.Models;

namespace Zatca_CSID
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
            //Application.Run(new frmLogin());
            
            frmLogin fLogin = new frmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
            else
            {
                Application.Exit();
            }

        }
    }
}