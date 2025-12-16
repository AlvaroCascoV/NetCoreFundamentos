using NetCoreFundamentos.Forms;

namespace NetCoreFundamentos
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
            //Application.Run(new Form1());
            //Application.Run(new Form01SumarNumeros());
            //Application.Run(new Form02ColoresPosicion());
            //Application.Run(new Form03DiaNacimiento());
            //Application.Run(new Form04DateTime());
            //Application.Run(new Form05Char());
            //Application.Run(new Form06Email());
            //Application.Run(new Form07SumarString());
            //Application.Run(new Form08StringBuilder());
            //Application.Run(new Form09Isbn());
            //Application.Run(new Form10ColeccionGrafica());
            //Application.Run(new Form11ColeccionMultiple());
            Application.Run(new Form12ColeccionNumeros());
        }
    }
}