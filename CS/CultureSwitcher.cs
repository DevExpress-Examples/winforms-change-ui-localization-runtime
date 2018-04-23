using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SchedulerSwitchLocale {
    public static class CultureSwitcher {
        public static string CultureId { get; private set; }

        public static void ChangeCulture(string newCultureId) {
            if (CultureSwitcher.CultureId == newCultureId)
                return;
            
            string pathSettings = Path.Combine(Directory.GetCurrentDirectory(), "culture.ini");

            File.WriteAllText(pathSettings, newCultureId);
            Application.Restart();
            Environment.Exit(0);
        }

        public static void RestoreCulture() {
            string pathSettings = Path.Combine(Directory.GetCurrentDirectory(), "culture.ini");

            if (File.Exists(pathSettings))
                CultureId = File.ReadAllText(pathSettings);
            else
                CultureId = "en";

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(CultureId);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(CultureId);
        }
    }
}
