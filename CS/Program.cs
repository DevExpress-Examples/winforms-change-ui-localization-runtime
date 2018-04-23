using System;
using System.Windows.Forms;

namespace SchedulerSwitchLocale {
    static class Program {
        [STAThread]
        static void Main() {
            
            CultureSwitcher.RestoreCulture();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}