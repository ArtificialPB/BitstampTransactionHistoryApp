using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitstampTransactionHistoryApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var dialog = new ViewSelectionForm();
            var result = dialog.ShowDialog();
            Type viewType = result == DialogResult.OK ? typeof(PrivateTransactionsView) : typeof(PublicTransactionsView);
            Application.Run((Form)Activator.CreateInstance(viewType));
        }
    }
}
