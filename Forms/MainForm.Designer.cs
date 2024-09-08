namespace LabForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DateTimePicker transactionDatePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox transactionTypeComboBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TransactionDelete = new System.Windows.Forms.Button();
            this.TransactionDetails = new System.Windows.Forms.Button();
            this.TransactionEdit = new System.Windows.Forms.Button();
            this.TransactionAdd = new System.Windows.Forms.Button();
            this.TransactionHeading = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CategoryDelete = new System.Windows.Forms.Button();
            this.CategoryAdd = new System.Windows.Forms.Button();
            this.CategoryHeading = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Heading = new System.Windows.Forms.Label();
            this.transactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financeTrackerDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeTrackerDataSet3 = new LabForm.FinanceTrackerDataSet3();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter1 = new LabForm.FinanceTrackerDataSet3TableAdapters.CategoryTableAdapter();
            this.transactionsTableAdapter1 = new LabForm.FinanceTrackerDataSet3TableAdapters.TransactionsTableAdapter();
            this.netTransactionLabel = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 668);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.TransactionDelete);
            this.panel3.Controls.Add(this.TransactionDetails);
            this.panel3.Controls.Add(this.TransactionEdit);
            this.panel3.Controls.Add(this.TransactionAdd);
            this.panel3.Controls.Add(this.TransactionHeading);
            this.panel3.Location = new System.Drawing.Point(12, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 280);
            this.panel3.TabIndex = 1;
            // 
            // TransactionDelete
            // 
            this.TransactionDelete.Location = new System.Drawing.Point(17, 220);
            this.TransactionDelete.Name = "TransactionDelete";
            this.TransactionDelete.Size = new System.Drawing.Size(114, 41);
            this.TransactionDelete.TabIndex = 10;
            this.TransactionDelete.Text = "Delete";
            this.TransactionDelete.UseVisualStyleBackColor = true;
            // 
            // TransactionDetails
            // 
            this.TransactionDetails.Location = new System.Drawing.Point(17, 126);
            this.TransactionDetails.Name = "TransactionDetails";
            this.TransactionDetails.Size = new System.Drawing.Size(114, 41);
            this.TransactionDetails.TabIndex = 9;
            this.TransactionDetails.Text = "View";
            this.TransactionDetails.UseVisualStyleBackColor = true;
            this.TransactionDetails.Click += new System.EventHandler(this.TransactionDetails_Click);
            // 
            // TransactionEdit
            // 
            this.TransactionEdit.Location = new System.Drawing.Point(17, 173);
            this.TransactionEdit.Name = "TransactionEdit";
            this.TransactionEdit.Size = new System.Drawing.Size(114, 41);
            this.TransactionEdit.TabIndex = 8;
            this.TransactionEdit.Text = "Edit";
            this.TransactionEdit.UseVisualStyleBackColor = true;
            this.TransactionEdit.Click += new System.EventHandler(this.TransactionEdit_Click);
            // 
            // TransactionAdd
            // 
            this.TransactionAdd.Location = new System.Drawing.Point(17, 79);
            this.TransactionAdd.Name = "TransactionAdd";
            this.TransactionAdd.Size = new System.Drawing.Size(114, 41);
            this.TransactionAdd.TabIndex = 7;
            this.TransactionAdd.Text = "Add";
            this.TransactionAdd.UseVisualStyleBackColor = true;
            this.TransactionAdd.Click += new System.EventHandler(this.button5_Click);
            // 
            // TransactionHeading
            // 
            this.TransactionHeading.AutoSize = true;
            this.TransactionHeading.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransactionHeading.Location = new System.Drawing.Point(4, 27);
            this.TransactionHeading.Name = "TransactionHeading";
            this.TransactionHeading.Size = new System.Drawing.Size(153, 43);
            this.TransactionHeading.TabIndex = 4;
            this.TransactionHeading.Text = "Transaction";
            this.TransactionHeading.Click += new System.EventHandler(this.TransactionHeading_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.CategoryDelete);
            this.panel2.Controls.Add(this.CategoryAdd);
            this.panel2.Controls.Add(this.CategoryHeading);
            this.panel2.Location = new System.Drawing.Point(11, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 203);
            this.panel2.TabIndex = 0;
            // 
            // CategoryDelete
            // 
            this.CategoryDelete.Location = new System.Drawing.Point(18, 123);
            this.CategoryDelete.Name = "CategoryDelete";
            this.CategoryDelete.Size = new System.Drawing.Size(114, 41);
            this.CategoryDelete.TabIndex = 4;
            this.CategoryDelete.Text = "Delete";
            this.CategoryDelete.UseVisualStyleBackColor = true;
            this.CategoryDelete.Click += new System.EventHandler(this.CategoryDelete_Click);
            // 
            // CategoryAdd
            // 
            this.CategoryAdd.BackColor = System.Drawing.Color.Transparent;
            this.CategoryAdd.Location = new System.Drawing.Point(18, 76);
            this.CategoryAdd.Name = "CategoryAdd";
            this.CategoryAdd.Size = new System.Drawing.Size(114, 41);
            this.CategoryAdd.TabIndex = 3;
            this.CategoryAdd.Text = "Add";
            this.CategoryAdd.UseVisualStyleBackColor = false;
            this.CategoryAdd.Click += new System.EventHandler(this.CategoryAdd_Click);
            // 
            // CategoryHeading
            // 
            this.CategoryHeading.AutoSize = true;
            this.CategoryHeading.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryHeading.Location = new System.Drawing.Point(21, 14);
            this.CategoryHeading.Name = "CategoryHeading";
            this.CategoryHeading.Size = new System.Drawing.Size(122, 43);
            this.CategoryHeading.TabIndex = 3;
            this.CategoryHeading.Text = "Category";
            this.CategoryHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(216, 82);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend2";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(292, 327);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(362, -6);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(465, 70);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "Personal Finance Tracker";
            // 
            // transactionsBindingSource1
            // 
            this.transactionsBindingSource1.DataMember = "Transactions";
            this.transactionsBindingSource1.DataSource = this.financeTrackerDataSet3BindingSource;
            // 
            // financeTrackerDataSet3BindingSource
            // 
            this.financeTrackerDataSet3BindingSource.DataSource = this.financeTrackerDataSet3;
            this.financeTrackerDataSet3BindingSource.Position = 0;
            // 
            // financeTrackerDataSet3
            // 
            this.financeTrackerDataSet3.DataSetName = "FinanceTrackerDataSet3";
            this.financeTrackerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.financeTrackerDataSet3BindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(217, 416);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(835, 200);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleCLick_2);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.transactionDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.transactionTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionsBindingSource2
            // 
            this.transactionsBindingSource2.DataMember = "Transactions";
            this.transactionsBindingSource2.DataSource = this.financeTrackerDataSet3BindingSource;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter1
            // 
            this.transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // netTransactionLabel
            // 
            this.netTransactionLabel.AutoSize = true;
            this.netTransactionLabel.BackColor = System.Drawing.Color.Lime;
            this.netTransactionLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netTransactionLabel.Location = new System.Drawing.Point(671, 82);
            this.netTransactionLabel.Name = "netTransactionLabel";
            this.netTransactionLabel.Size = new System.Drawing.Size(83, 43);
            this.netTransactionLabel.TabIndex = 4;
            this.netTransactionLabel.Text = "label1";
            this.netTransactionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // chart2
            // 
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(509, 145);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(543, 203);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1064, 628);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.netTransactionLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CategoryHeading;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Button TransactionDelete;
        private System.Windows.Forms.Button TransactionDetails;
        private System.Windows.Forms.Button TransactionEdit;
        private System.Windows.Forms.Button TransactionAdd;
        private System.Windows.Forms.Label TransactionHeading;
        private System.Windows.Forms.Button CategoryDelete;
        private System.Windows.Forms.Button CategoryAdd;
        private FinanceTrackerDataSet3 financeTrackerDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private FinanceTrackerDataSet3TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private FinanceTrackerDataSet3TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource financeTrackerDataSet3BindingSource;
        private FinanceTrackerDataSet3 financeTrackerDataSet3;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private FinanceTrackerDataSet3TableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private System.Windows.Forms.BindingSource transactionsBindingSource1;
        private FinanceTrackerDataSet3TableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource transactionsBindingSource2;
        private System.Windows.Forms.Label netTransactionLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}
