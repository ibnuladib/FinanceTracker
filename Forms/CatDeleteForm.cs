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

namespace LabForm.Forms
{
    public partial class CatDeleteForm : Form
    {
        private readonly CategoryData categoryRepository = new CategoryData();

        public void Load_Category()
        {
            var categories = categoryRepository.GetAllCategories();
            SelectCategoryBox.DataSource = categories;
            SelectCategoryBox.DisplayMember = "CategoryName";
            SelectCategoryBox.ValueMember = "CategoryId";
        }

        private void CatDel_FormLoad(object sender, EventArgs e)
        {
            Load_Category();

        }
        public CatDeleteForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (SelectCategoryBox.SelectedValue != null)
            {
                int selectedCategoryId = (int)SelectCategoryBox.SelectedValue;

                try
                {
                    
                    categoryRepository.DeleteCategory(selectedCategoryId);

                    Load_Category();
                    MessageBox.Show("Category and associated transactions deleted successfully.");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }

    }
}
