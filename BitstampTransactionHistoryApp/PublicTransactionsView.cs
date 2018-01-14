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
    public partial class PublicTransactionsView : Form {
        private TransactionParser transactionParser = null;
        public PublicTransactionsView() {
            InitializeComponent();
        }

        private TransactionParser GetTransactionParser() {
            if (transactionParser == null) {
                this.transactionParser = new TransactionParser(null, null, null);
            }
            return transactionParser;
        }

        private void PublicTransactionsView_Load(object sender, EventArgs e) {
            comboBoxParseWithinTime.SelectedIndex = 0;
        }

        private void buttonParseTransactions_Click(object sender, EventArgs e) {
            TransactionParser parser = GetTransactionParser();
            if (parser != null) {
                string currencyPair = textBoxCurrencyPair.Text;
                if (currencyPair == null) {
                    MessageBox.Show("Please provide the desired currency pair you'd like to parse the transactions for.");
                    return;
                }
                Dictionary<string, string> parameters = new Dictionary<string, string> {
                    { "time", comboBoxParseWithinTime.Text.ToLower() }
                };
                List<PublicTransaction> transactions = parser.UpdatedPublicTransactions(currencyPair.ToLower(),parameters);
                transactions.ForEach(t => {
                    PublicTransactionType type = (PublicTransactionType)t.type;
                    ListViewItem item = new ListViewItem(t.tid.ToString());
                    item.SubItems.Add(TimestampToDateTime(t.date).ToString());
                    item.SubItems.Add(t.amount.ToString());
                    item.SubItems.Add(t.price.ToString());
                    item.SubItems.Add(type.ToString());
                    tableTransactions.Items.Add(item);
                }
                );
            }
        }

        private DateTime TimestampToDateTime(int timestamp) {
            DateTime ret = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            ret = ret.AddSeconds(timestamp).ToLocalTime();
            return ret;
        }

        private void buttonLoadTransactions_Click(object sender, EventArgs e) {
            tableTransactions.Items.Clear();
            using (var ctx = new TransactionHistoriesEntities()) {
                foreach (var t in ctx.PublicTransactions) {
                    PublicTransactionType type = (PublicTransactionType)t.type;
                    ListViewItem item = new ListViewItem(t.tid.ToString());
                    item.SubItems.Add(t.date.ToString());
                    item.SubItems.Add(t.amount.ToString());
                    item.SubItems.Add(t.price.ToString());
                    item.SubItems.Add(type.ToString());
                    tableTransactions.Items.Add(item);
                }
            }
        }

        private void buttonClearTable_Click(object sender, EventArgs e) {
            tableTransactions.Items.Clear();
        }

        private void buttonClearDatabase_Click(object sender, EventArgs e) {
            using (var ctx = new TransactionHistoriesEntities()) {
                foreach (var id in ctx.PublicTransactions.Select(t => t.tid)) {
                    var entity = new PublicTransaction { tid = id };
                    ctx.PublicTransactions.Attach(entity);
                    ctx.PublicTransactions.Remove(entity);
                }
                ctx.SaveChanges();
            }
        }
    }
}
