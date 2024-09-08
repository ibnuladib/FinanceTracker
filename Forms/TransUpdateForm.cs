using LabForm.DataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabForm.Models;

namespace LabForm.Forms
{
    public partial class TransUpdateForm : Form
    {
        private readonly TransactionData transactionRepository = new TransactionData();
        private readonly CategoryData categoryRepository = new CategoryData();
        public TransUpdateForm()
        {
            InitializeComponent();
            TypeComboBox.Items.Add("Expense");
            TypeComboBox.Items.Add("Income");
        }

        private void TransUpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            int transactionId;
            if(int.TryParse(TransactionIdBox.Text, out transactionId))
            {
                var transaction = transactionRepository.GetTransactionById(transactionId);
                if (transaction != null) { 
                    CategoryNameBox.Text = transaction.CategoryName;
                    AmountBox.Text = transaction.Amount.ToString();
                    DateTimePicker.Value = transaction.TransactionDate;
                    CommentBox.Text = transaction.Comments;
                    string option = transaction.TransactionType.ToString();
                    TypeComboBox.SelectedItem = option;
                    
                }
                else
                {
                    MessageBox.Show("No Transaction available for this Transaction Id");
                }
            }
            else
            {
                MessageBox.Show("Enter a Transaction Id");
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            TransactionIdBox.Clear();
            CategoryNameBox.Clear();
            AmountBox.Clear();
            DateTimePicker.Value = DateTime.Now; 
            CommentBox.Clear();
            TypeComboBox.SelectedIndex = -1; 
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int transactionId;
            if (int.TryParse(TransactionIdBox.Text, out transactionId))
            {
                var transaction = new Transactions
                {
                    TransactionId = transactionId,
                    CategoryName = CategoryNameBox.Text,
                    Amount = decimal.Parse(AmountBox.Text),
                    TransactionDate = DateTimePicker.Value,
                    Comments = CommentBox.Text,
                    TransactionType = TypeComboBox.SelectedItem.ToString(),
                    CategoryId = categoryRepository.GetCategoryIdByName(CategoryNameBox.Text)
                };

                bool success = transactionRepository.UpdateTransaction(transaction);
                if (success)
                {
                    MessageBox.Show("Transaction updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error updating transaction.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Transaction Id");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int transactionId;
            if (int.TryParse(TransactionIdBox.Text, out transactionId))
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this transaction?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = transactionRepository.DeleteTransactionById(transactionId);
                    if (success)
                    {
                        MessageBox.Show("Transaction deleted successfully.");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting transaction or transaction not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Transaction Id");
            }
        }
    }
}
