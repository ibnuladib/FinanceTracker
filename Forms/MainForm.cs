using LabForm.Models;
using System;
using System.Windows.Forms;
using LabForm.DataBaseConnection;
using LabForm.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;


namespace LabForm
{
    public partial class MainForm : Form
    {
        private readonly CategoryData categoryRepository = new CategoryData();
        private readonly TransactionData transactionRepository = new TransactionData();


        private DataTable GetCategoryTotals()
        {
            DataTable dataTable = new DataTable();


            string connectionString = "Server=(localdb)\\login;Database=FinanceTracker;Trusted_Connection=True;";

            string query = @"
             SELECT c.CategoryName, SUM(t.Amount) AS TotalAmount
                FROM Transactions t
                INNER JOIN Category c ON t.CategoryId = c.CategoryId
                WHERE t.TransactionType = 'Expense'
                GROUP BY c.CategoryName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void ConfigureChart()
        {

            var chartArea = new ChartArea();
            chartArea.Name = "ChartArea1";
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(chartArea);

            var legend = new Legend();
            legend.Name = "Legend1";
            
            chart1.Legends.Clear(); 
            //chart1.Legends.Add(legend);

            var series = new Series();
            series.ChartType = SeriesChartType.Doughnut; 
            series.Name = "Series1";

            chart1.Series.Clear();
            chart1.Series.Add(series);

            LoadChartData();
        }

        private void LoadChartData()
        {
            DataTable categoryTotals = GetCategoryTotals();
            decimal totalAmount = Convert.ToDecimal(categoryTotals.Compute("SUM(TotalAmount)", string.Empty));

            chart1.Series["Series1"].Points.Clear();

            if (totalAmount == 0)
            {
                MessageBox.Show("Total amount is zero. Cannot calculate percentages.");
                return;
            }

            foreach (DataRow row in categoryTotals.Rows)
            {
                string categoryName = row["CategoryName"].ToString();
                decimal categoryTotal = Convert.ToDecimal(row["TotalAmount"]);
                decimal percentage = (categoryTotal / totalAmount) * 100;
            
                chart1.Series["Series1"].Points.AddXY(categoryName, percentage);
            }
        }


        public MainForm()
        {
            
            InitializeComponent();
            ConfigureChart();
            AddNetTransaction();
            InitializeChart2();
            UpdateChartData();
        }

        public void AddNetTransaction()
        {
            decimal netTransactions = transactionRepository.GetNetTransaction();
            if (netTransactions>=0) {
                netTransactionLabel.BackColor = System.Drawing.Color.Lime;
                netTransactionLabel.Text = $"Net Transactions: + {netTransactions:F2} BDT";

            }
            else
            {
                netTransactionLabel.BackColor= System.Drawing.Color.Red;
                netTransactionLabel.Text = $"Net Transactions: {netTransactions:F2} BDT";
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.transactionsTableAdapter1.Fill(this.financeTrackerDataSet3.Transactions);
           
            this.categoryTableAdapter1.Fill(this.financeTrackerDataSet3.Category);
           
            LoadCategories();
            LoadTransactions();
        }

        private void LoadCategories()
        {
            var categories = categoryRepository.GetAllCategories();
        }

        private void LoadTransactions()
        {
            var transactions = transactionRepository.GetAllTransactions();
            dataGridView1.DataSource = transactions;

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void TransAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadTransactions();
            ConfigureChart();
            AddNetTransaction();
            UpdateChartData();


        }
        private void button5_Click(object sender, EventArgs e)
        {
            var transAddForm = new TransAddForm();
            transAddForm.FormClosed += TransAddForm_FormClosed; 
            transAddForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter.Fill(this.financeTrackerDataSet3.Category);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TransactionHeading_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleCLick_2(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CategoryAdd_Click(object sender, EventArgs e)
        {
            CatAddForm catAddForm = new CatAddForm();
            catAddForm.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //chart2
        private void InitializeChart2()
        {

            chart2.Series.Clear();

            Series netTransactionsSeries = new Series("Net Transactions");
            netTransactionsSeries.ChartType = SeriesChartType.Line; 

            chart2.Series.Add(netTransactionsSeries);
        }

        private void UpdateChartData()
        {
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddDays(-7);

            var filteredTransactions = transactionRepository.GetAllTransactions()
                .Where(t => t.TransactionDate.Date >= startDate.Date && t.TransactionDate.Date <= endDate.Date)
                .OrderBy(t => t.TransactionDate)
                .ToList();

            var netTransactions = filteredTransactions
                .GroupBy(t => t.TransactionDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    NetAmount = g.Sum(t => t.TransactionType == "Income" ? t.Amount : -t.Amount)
                })
                .ToList();

            if (!chart2.Series.IsUniqueName("Net Transactions"))
            {
                InitializeChart2();
            }

            chart2.Series["Net Transactions"].Points.Clear();

            foreach (var dataPoint in netTransactions)
            {
                chart2.Series["Net Transactions"].Points.AddXY(dataPoint.Date.ToShortDateString(), dataPoint.NetAmount);
            }
        }

        private void CategoryDelete_Click(object sender, EventArgs e)
        {
            CatDeleteForm catDeleteForm = new CatDeleteForm();
            catDeleteForm.FormClosed += TransAddForm_FormClosed;
            catDeleteForm.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransactionDetails_Click(object sender, EventArgs e)
        {
            TransViewForm transViewForm = new TransViewForm();
            transViewForm.Show();
        }

        private void TransactionEdit_Click(object sender, EventArgs e)
        {
            TransUpdateForm transUpdateForm = new TransUpdateForm();
            transUpdateForm.FormClosed += TransAddForm_FormClosed;
            transUpdateForm.Show();
        }
    }
}
