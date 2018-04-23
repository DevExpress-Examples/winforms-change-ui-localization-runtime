using System;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace SchedulerSwitchLocale {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            cbLocale.SelectedIndex = cbLocale.Items.IndexOf(CultureSwitcher.CultureId);
        }

        private void cbLocale_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedLocale = cbLocale.SelectedItem.ToString();
            CultureSwitcher.ChangeCulture(selectedLocale);
        }
    }
}