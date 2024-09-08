using LabForm.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace LabForm.DataBaseConnection
{
    public class CategoryData
    {
        private readonly string connectionString = "Server=(localdb)\\login;Database=FinanceTracker;Trusted_Connection=True;";

        public List<Category> GetAllCategories()
        {
            var categories = new List<Category>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Category";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new Category
                            {
                                CategoryId = reader.GetInt32(0),
                                CategoryName = reader.GetString(1)
                            });
                        }
                    }
                }
            }

            return categories;
        }

        public void AddCategory(Category category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Category (CategoryName) VALUES (@CategoryName)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCategory(int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete associated transactions
                        string deleteTransactionsQuery = "DELETE FROM Transactions WHERE CategoryId = @CategoryId";
                        using (SqlCommand deleteTransactionsCommand = new SqlCommand(deleteTransactionsQuery, connection, transaction))
                        {
                            deleteTransactionsCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                            deleteTransactionsCommand.ExecuteNonQuery();
                        }

                        // Delete category
                        string deleteCategoryQuery = "DELETE FROM Category WHERE CategoryId = @CategoryId";
                        using (SqlCommand deleteCategoryCommand = new SqlCommand(deleteCategoryQuery, connection, transaction))
                        {
                            deleteCategoryCommand.Parameters.AddWithValue("@CategoryId", categoryId);
                            deleteCategoryCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error deleting category and associated transactions: " + ex.Message);
                    }
                }
            }
        }

        public int GetCategoryIdByName(string categoryName)
        {
            string query = "SELECT CategoryId FROM Category WHERE CategoryName = @CategoryName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Category not found.");
                    }
                }
            }
        }


    }
}
