using LabForm.DataBaseConnection;
using LabForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForm.Forms
{
    public partial class TransViewForm : Form
    {

        private readonly TransactionData transactionRepository = new TransactionData();



        public TransViewForm()
        {
            InitializeComponent();

        }
        private void TransViewForm_Load(object sender, EventArgs e)
        {
            this.transactionsTableAdapter.Fill(this.financeTrackerDataSet3.Transactions);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text;
            DataTable transactions = transactionRepository.LoadSelectedTransaction(searchTerm);

            TransactionDataGridView.DataSource = transactions;
        }
    }
}
