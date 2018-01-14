using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitstampTransactionHistoryApp {
    public partial class PrivateTransactionsView : Form {
        private TransactionParser transactionParser = null;
        public PrivateTransactionsView() {
            InitializeComponent();
        }

        private TransactionParser GetTransactionParser() {
            if (transactionParser == null) {
                string apiKey = textBoxApiKey.Text;
                string apiSecret = textBoxApiSecret.Text;
                string customerId = textBoxCustomerId.Text;
                if (apiKey == null || apiSecret == null || customerId == null) {
                    MessageBox.Show("Please provide your authentication details");
                    return null;
                }
                this.transactionParser = new TransactionParser(apiKey, apiSecret, customerId);
            }
            return transactionParser;
        }

        private void buttonParseTransactions_Click(object sender, EventArgs e) {
            TransactionParser parser = GetTransactionParser();
            if (parser != null) {
                List<Transaction> transactions = parser.UpdatedPrivateTransactions();
                transactions.ForEach(t => {
                    TransactionType type = (TransactionType)t.type;
                    ListViewItem item = new ListViewItem(t.id.ToString());
                    item.SubItems.Add(t.datetime.ToString());
                    item.SubItems.Add(t.btc.ToString());
                    item.SubItems.Add(type.ToString());
                    item.SubItems.Add(t.fee.ToString());
                    tableTransactions.Items.Add(item);
                }
                );
            }
        }

        private void buttonClearTable_Click(object sender, EventArgs e) {
            tableTransactions.Items.Clear();
        }

        private void buttonLoadTransactions_Click(object sender, EventArgs e) {
            tableTransactions.Items.Clear();
            using (var ctx = new TransactionHistoriesEntities()) {
                foreach (var t in ctx.Transactions) {
                    TransactionType type = (TransactionType)t.type;
                    ListViewItem item = new ListViewItem(t.id.ToString());
                    item.SubItems.Add(t.datetime.ToString());
                    item.SubItems.Add(t.btc.ToString());
                    item.SubItems.Add(type.ToString());
                    item.SubItems.Add(t.fee.ToString());
                    tableTransactions.Items.Add(item);
                }
            }
        }

        private void buttonClearDatabase_Click(object sender, EventArgs e) {
            using (var ctx = new TransactionHistoriesEntities()) {
                foreach (var id in ctx.Transactions.Select(t => t.id)) {
                    var entity = new Transaction { id = id };
                    ctx.Transactions.Attach(entity);
                    ctx.Transactions.Remove(entity);
                }
                ctx.SaveChanges();
            }
        }
    }
}
