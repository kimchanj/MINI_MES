using System;
using System.Windows.Forms;
using MiniMes.LotTraceSample.Forms;

namespace MiniMes.LotTraceSample
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
