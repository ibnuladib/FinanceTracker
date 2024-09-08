namespace LabForm.Forms
{
    partial class TransViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.financeTrackerDataSet3 = new LabForm.FinanceTrackerDataSet3();
            this.financeTrackerDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new LabForm.FinanceTrackerDataSet3TableAdapters.TransactionsTableAdapter();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(120, 45);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(176, 26);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(312, 44);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.AutoGenerateColumns = false;
            this.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.TransactionDataGridView.DataSource = this.transactionsBindingSource;
            this.TransactionDataGridView.Location = new System.Drawing.Point(12, 106);
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.RowHeadersWidth = 62;
            this.TransactionDataGridView.RowTemplate.Height = 28;
            this.TransactionDataGridView.Size = new System.Drawing.Size(953, 344);
            this.TransactionDataGridView.TabIndex = 3;
            // 
            // financeTrackerDataSet3
            // 
            this.financeTrackerDataSet3.DataSetName = "FinanceTrackerDataSet3";
            this.financeTrackerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financeTrackerDataSet3BindingSource
            // 
            this.financeTrackerDataSet3BindingSource.DataSource = this.financeTrackerDataSet3;
            this.financeTrackerDataSet3BindingSource.Position = 0;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.financeTrackerDataSet3BindingSource;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // TransViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 462);
            this.Controls.Add(this.TransactionDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Name = "TransViewForm";
            this.Text = "View Transactions";
            this.Load += new System.EventHandler(this.TransViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeTrackerDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView TransactionDataGridView;
        private System.Windows.Forms.BindingSource financeTrackerDataSet3BindingSource;
        private FinanceTrackerDataSet3 financeTrackerDataSet3;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private FinanceTrackerDataSet3TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
    }
}