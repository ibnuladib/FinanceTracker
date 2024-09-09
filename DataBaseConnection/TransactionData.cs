using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using LabForm.Models;

namespace LabForm.DataBaseConnection
{
    public class TransactionData
    {
        private readonly string connectionString = "Server=(localdb)\\login;Database=FinanceTracker;Trusted_Connection=True;";


        public List<Transactions> GetAllTransactions()
        {
            var transactions = new List<Transactions>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT t.TransactionId, t.CategoryId, t.Amount, t.TransactionDate, t.TransactionType, t.Comments, c.CategoryName
            FROM Transactions t
            INNER JOIN Category c ON t.CategoryId = c.CategoryId
            ORDER BY t.TransactionDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactions.Add(new Transactions
                            {
                                TransactionId = reader.GetInt32(0),
                                CategoryId = reader.GetInt32(1),
                                Amount = reader.GetDecimal(2),
                                TransactionDate = reader.GetDateTime(3),
                                TransactionType = reader.GetString(4),
                                Comments = reader.GetString(5),
                                CategoryName = reader.GetString(6) 
                            });
                        }
                    }
                }
            }

            return transactions;
        }


        public void AddTransaction(Transactions transaction)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Transactions (CategoryId, Amount, TransactionDate, Comments, TransactionType) VALUES (@CategoryId, @Amount, @TransactionDate, @Comments, @TransactionType)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", transaction.CategoryId);
                    command.Parameters.AddWithValue("@Amount", transaction.Amount);
                    command.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                    command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType);
                    command.Parameters.AddWithValue("@Comments", transaction.Comments);
                    command.ExecuteNonQuery();
                }
            }
        }


        public DataTable LoadSelectedTransaction(string searchTerm)
        {
            DataTable transactionsTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT t.TransactionId, t.CategoryId, t.Amount, t.TransactionDate, 
                       t.TransactionType, t.Comments, c.CategoryName
                FROM Transactions t
                INNER JOIN Category c ON t.CategoryId = c.CategoryId
                WHERE t.Comments LIKE @SearchTerm
                   OR t.TransactionId LIKE @SearchTerm
                   OR c.CategoryName LIKE @SearchTerm
                   OR t.Amount LIKE @SearchTerm                   
                   OR t.TransactionDate LIKE @SearchTerm
                   OR t.TransactionType LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(transactionsTable);
                        }
                    }
                }

                if (transactionsTable.Rows.Count == 0)
                {
                    MessageBox.Show("No matching records found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return transactionsTable;
        }


        public decimal GetNetTransaction()
        {
            decimal netTransaction = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open ();
                string query = "SELECT SUM(CASE WHEN TransactionType = 'Income' THEN Amount WHEN TransactionType = 'Expense' THEN -Amount END) AS NetAmount FROM Transactions";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    netTransaction = (decimal)result;
                }

            }
            return netTransaction;
        }

        public Transactions GetTransactionById(int transactionId)
        {
            Transactions transaction = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open ();
                string query = @"
                    SELECT t.TransactionId, t.Amount, t.TransactionDate, t.TransactionType, t.Comments, c.CategoryName
                    FROM Transactions t
                    INNER JOIN Category c ON t.CategoryId = c.CategoryId
                    WHERE t.TransactionId = @TransactionId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionId",transactionId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                             transaction = new Transactions
                            {
                                TransactionId = reader.GetInt32(0),
                                Amount = reader.GetDecimal(1),
                                TransactionDate = reader.GetDateTime(2),
                                TransactionType = reader.GetString(3),
                                Comments = reader.GetString(4),
                                CategoryName = reader.GetString(5)
                            };
                        }
                    }
                }
            }
            return transaction;
        }

        public bool DeleteTransactionById(int transactionId)
        {
            string query = "DELETE FROM Transactions WHERE TransactionId = @TransactionId";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionId", transactionId);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public bool UpdateTransaction(Transactions transaction)
        {
            string query = @"
        UPDATE Transactions
        SET Amount = @Amount,
            TransactionDate = @TransactionDate,
            TransactionType = @TransactionType,
            Comments = @Comments,
            CategoryId = @CategoryId
        WHERE TransactionId = @TransactionId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Amount", transaction.Amount);
                    command.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                    command.Parameters.AddWithValue("@TransactionType", transaction.TransactionType);
                    command.Parameters.AddWithValue("@Comments", transaction.Comments);
                    command.Parameters.AddWithValue("@CategoryId", transaction.CategoryId);
                    command.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }


    }
}
