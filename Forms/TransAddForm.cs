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
    public partial class TransAddForm : Form
    {
        private readonly CategoryData categoryRepository = new CategoryData();
        private readonly TransactionData transactionRepository = new TransactionData();


        private void LoadCategories()
        {
            var categories = categoryRepository.GetAllCategories();
            CategoryComboBox.DataSource = categories;
            CategoryComboBox.DisplayMember = "CategoryName";
            CategoryComboBox.ValueMember = "CategoryId";

            // Populate TransactionTypeBox with predefined options
            TransactionTypeBox.Items.Add("Expense");
            TransactionTypeBox.Items.Add("Income");
        }

        public TransAddForm()
        {
            InitializeComponent();
        }

        private void TransAddForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            AmountGenerator.Maximum = 100000000;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddTransactionHeading_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TransAdd_Click(object sender, EventArgs e)
        {
            // Check if a valid category is selected
            if (CategoryComboBox.SelectedIndex != -1)
            {
                try
                {
                    var newTransaction = new Transactions
                    {
                        CategoryId = (int)CategoryComboBox.SelectedValue,
                        TransactionType = TransactionTypeBox.Text,
                        Amount = decimal.Parse(AmountGenerator.Text),
                        TransactionDate = TransactionAddDateTimePicker.Value,
                        Comments = TransactionComment.Text
                    };

                    transactionRepository.AddTransaction(newTransaction);
                    MessageBox.Show("Transaction added successfully!");

                    // Close the form after adding the transaction
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid category.");
            }
        }



        private void TransactionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
