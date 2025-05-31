using System;
using System.Windows.Forms;

namespace HealthcareApplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HealthcareForm());
        }
    }
}
