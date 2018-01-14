namespace BitstampTransactionHistoryApp {
    partial class PublicTransactionsView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrencyPair = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableTransactions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLoadTransactions = new System.Windows.Forms.Button();
            this.buttonClearDatabase = new System.Windows.Forms.Button();
            this.buttonClearTable = new System.Windows.Forms.Button();
            this.buttonParseTransactions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxParseWithinTime = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.9375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 370);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.textBoxCurrencyPair);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.comboBoxParseWithinTime);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(907, 31);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Currency Pair";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCurrencyPair
            // 
            this.textBoxCurrencyPair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCurrencyPair.Location = new System.Drawing.Point(79, 3);
            this.textBoxCurrencyPair.Name = "textBoxCurrencyPair";
            this.textBoxCurrencyPair.Size = new System.Drawing.Size(130, 20);
            this.textBoxCurrencyPair.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxCurrencyPair, "Provide the data in the following format: \r\nbtcusd, ethusd, etheur, ...");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.99342F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.00658F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableTransactions, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(907, 327);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableTransactions
            // 
            this.tableTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.tableTransactions.FullRowSelect = true;
            this.tableTransactions.Location = new System.Drawing.Point(5, 28);
            this.tableTransactions.Name = "tableTransactions";
            this.tableTransactions.Size = new System.Drawing.Size(561, 294);
            this.tableTransactions.TabIndex = 0;
            this.tableTransactions.UseCompatibleStateImageBehavior = false;
            this.tableTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 57;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Transactions";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Options";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonLoadTransactions, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonClearDatabase, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.buttonClearTable, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonParseTransactions, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(574, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(328, 294);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonLoadTransactions
            // 
            this.buttonLoadTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoadTransactions.Location = new System.Drawing.Point(109, 99);
            this.buttonLoadTransactions.Name = "buttonLoadTransactions";
            this.buttonLoadTransactions.Size = new System.Drawing.Size(109, 42);
            this.buttonLoadTransactions.TabIndex = 3;
            this.buttonLoadTransactions.Text = "Load Transactions";
            this.buttonLoadTransactions.UseVisualStyleBackColor = true;
            this.buttonLoadTransactions.Click += new System.EventHandler(this.buttonLoadTransactions_Click);
            // 
            // buttonClearDatabase
            // 
            this.buttonClearDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearDatabase.Location = new System.Drawing.Point(109, 195);
            this.buttonClearDatabase.Name = "buttonClearDatabase";
            this.buttonClearDatabase.Size = new System.Drawing.Size(109, 42);
            this.buttonClearDatabase.TabIndex = 2;
            this.buttonClearDatabase.Text = "Clear Database";
            this.buttonClearDatabase.UseVisualStyleBackColor = true;
            this.buttonClearDatabase.Click += new System.EventHandler(this.buttonClearDatabase_Click);
            // 
            // buttonClearTable
            // 
            this.buttonClearTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearTable.Location = new System.Drawing.Point(109, 147);
            this.buttonClearTable.Name = "buttonClearTable";
            this.buttonClearTable.Size = new System.Drawing.Size(109, 42);
            this.buttonClearTable.TabIndex = 1;
            this.buttonClearTable.Text = "Clear Table";
            this.buttonClearTable.UseVisualStyleBackColor = true;
            this.buttonClearTable.Click += new System.EventHandler(this.buttonClearTable_Click);
            // 
            // buttonParseTransactions
            // 
            this.buttonParseTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonParseTransactions.Location = new System.Drawing.Point(109, 51);
            this.buttonParseTransactions.Name = "buttonParseTransactions";
            this.buttonParseTransactions.Size = new System.Drawing.Size(109, 42);
            this.buttonParseTransactions.TabIndex = 0;
            this.buttonParseTransactions.Text = "Parse Transactions";
            this.buttonParseTransactions.UseVisualStyleBackColor = true;
            this.buttonParseTransactions.Click += new System.EventHandler(this.buttonParseTransactions_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transactions within the last";
            // 
            // comboBoxParseWithinTime
            // 
            this.comboBoxParseWithinTime.FormattingEnabled = true;
            this.comboBoxParseWithinTime.Items.AddRange(new object[] {
            "Minute",
            "Hour",
            "Day"});
            this.comboBoxParseWithinTime.Location = new System.Drawing.Point(356, 3);
            this.comboBoxParseWithinTime.Name = "comboBoxParseWithinTime";
            this.comboBoxParseWithinTime.Size = new System.Drawing.Size(110, 21);
            this.comboBoxParseWithinTime.TabIndex = 3;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 131;
            // 
            // PublicTransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PublicTransactionsView";
            this.Text = "PublicTransactionsView";
            this.Load += new System.EventHandler(this.PublicTransactionsView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrencyPair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView tableTransactions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonLoadTransactions;
        private System.Windows.Forms.Button buttonClearDatabase;
        private System.Windows.Forms.Button buttonClearTable;
        private System.Windows.Forms.Button buttonParseTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxParseWithinTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}