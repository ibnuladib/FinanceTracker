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
    public partial class CatAddForm : Form
    {
        private readonly CategoryData categoryRepository = new CategoryData();

        public CatAddForm()
        {
            InitializeComponent();
        }

        private void CatAddForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CatAddButton_Click(object sender, EventArgs e)
        {
                try
                {
                    var newCategory = new Category
                    {
                        CategoryName = NewCatTextBox.Text
                    };

                    categoryRepository.AddCategory(newCategory);

                    MessageBox.Show("Transaction added successfully!");

                    // Close the form after adding the transaction
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        private void NewCatTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
