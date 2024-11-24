using System;
using System.Windows.Forms;

namespace WarehouseApp
{
    internal static class Program
    {
        // Metadata
        // Attribute
        [STAThread]   //Single threaded apartment thread
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
