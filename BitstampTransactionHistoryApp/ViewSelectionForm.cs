using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitstampTransactionHistoryApp {
    public partial class ViewSelectionForm : Form {
        public ViewSelectionForm() {
            InitializeComponent();
        }

        private void ViewSelectionForm_Load(object sender, EventArgs e) {
            buttonPrivateView.DialogResult = DialogResult.OK;
            buttonPublicView.DialogResult = DialogResult.Cancel;
        }
    }

    
}
