namespace LabForm.Forms
{
    partial class TransAddForm
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
            this.AddTransactionHeading = new System.Windows.Forms.Label();
            this.TransactionComment = new System.Windows.Forms.TextBox();
            this.TransactionTypeBox = new System.Windows.Forms.ComboBox();
            this.AmountGenerator = new System.Windows.Forms.NumericUpDown();
            this.TransactionAddDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TransactionType = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountGenerator)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTransactionHeading
            // 
            this.AddTransactionHeading.AutoSize = true;
            this.AddTransactionHeading.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionHeading.Location = new System.Drawing.Point(106, 9);
            this.AddTransactionHeading.Name = "AddTransactionHeading";
            this.AddTransactionHeading.Size = new System.Drawing.Size(255, 56);
            this.AddTransactionHeading.TabIndex = 0;
            this.AddTransactionHeading.Text = "Add Transaction";
            this.AddTransactionHeading.Click += new System.EventHandler(this.AddTransactionHeading_Click);
            // 
            // TransactionComment
            // 
            this.TransactionComment.Location = new System.Drawing.Point(116, 274);
            this.TransactionComment.Multiline = true;
            this.TransactionComment.Name = "TransactionComment";
            this.TransactionComment.Size = new System.Drawing.Size(294, 82);
            this.TransactionComment.TabIndex = 1;
            this.TransactionComment.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TransactionTypeBox
            // 
            this.TransactionTypeBox.FormattingEnabled = true;
            this.TransactionTypeBox.Location = new System.Drawing.Point(116, 92);
            this.TransactionTypeBox.Name = "TransactionTypeBox";
            this.TransactionTypeBox.Size = new System.Drawing.Size(182, 28);
            this.TransactionTypeBox.TabIndex = 2;
            this.TransactionTypeBox.SelectedIndexChanged += new System.EventHandler(this.TransactionTypeBox_SelectedIndexChanged);
            // 
            // AmountGenerator
            // 
            this.AmountGenerator.Location = new System.Drawing.Point(116, 186);
            this.AmountGenerator.Name = "AmountGenerator";
            this.AmountGenerator.Size = new System.Drawing.Size(91, 26);
            this.AmountGenerator.TabIndex = 3;
            this.AmountGenerator.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TransactionAddDateTimePicker
            // 
            this.TransactionAddDateTimePicker.Location = new System.Drawing.Point(116, 233);
            this.TransactionAddDateTimePicker.Name = "TransactionAddDateTimePicker";
            this.TransactionAddDateTimePicker.Size = new System.Drawing.Size(294, 26);
            this.TransactionAddDateTimePicker.TabIndex = 4;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(116, 136);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(182, 28);
            this.CategoryComboBox.TabIndex = 5;
            // 
            // TransactionType
            // 
            this.TransactionType.AutoSize = true;
            this.TransactionType.Location = new System.Drawing.Point(26, 92);
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.Size = new System.Drawing.Size(43, 20);
            this.TransactionType.TabIndex = 6;
            this.TransactionType.Text = "Type";
            this.TransactionType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(26, 136);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(73, 20);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category";
            this.CategoryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(26, 186);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(65, 20);
            this.Amount.TabIndex = 8;
            this.Amount.Text = "Amount";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(26, 233);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(44, 20);
            this.Date.TabIndex = 9;
            this.Date.Text = "Date";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Location = new System.Drawing.Point(26, 274);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(78, 20);
            this.Comment.TabIndex = 10;
            this.Comment.Text = "Comment";
            this.Comment.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(168, 382);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 52);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.TransAdd_Click);
            // 
            // TransAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 462);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TransactionType);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TransactionAddDateTimePicker);
            this.Controls.Add(this.AmountGenerator);
            this.Controls.Add(this.TransactionTypeBox);
            this.Controls.Add(this.TransactionComment);
            this.Controls.Add(this.AddTransactionHeading);
            this.Name = "TransAddForm";
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.TransAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmountGenerator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddTransactionHeading;
        private System.Windows.Forms.TextBox TransactionComment;
        private System.Windows.Forms.ComboBox TransactionTypeBox;
        private System.Windows.Forms.NumericUpDown AmountGenerator;
        private System.Windows.Forms.DateTimePicker TransactionAddDateTimePicker;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label TransactionType;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Button AddButton;
    }
}