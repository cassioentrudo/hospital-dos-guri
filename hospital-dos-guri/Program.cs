using System;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    static class Program
    {
        /// <summary>
        ///  Entrada principal do programa
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            
        }
    }
}
