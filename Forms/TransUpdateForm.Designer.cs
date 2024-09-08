namespace LabForm.Forms
{
    partial class TransUpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionIdLabel = new System.Windows.Forms.Label();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.TransactionIdBox = new System.Windows.Forms.TextBox();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Transaction";
            // 
            // TransactionIdLabel
            // 
            this.TransactionIdLabel.AutoSize = true;
            this.TransactionIdLabel.Location = new System.Drawing.Point(74, 100);
            this.TransactionIdLabel.Name = "TransactionIdLabel";
            this.TransactionIdLabel.Size = new System.Drawing.Size(110, 20);
            this.TransactionIdLabel.TabIndex = 1;
            this.TransactionIdLabel.Text = "Transaction Id";
            this.TransactionIdLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(74, 134);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(119, 20);
            this.CategoryNameLabel.TabIndex = 2;
            this.CategoryNameLabel.Text = "Category Name";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(74, 169);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 3;
            this.AmountLabel.Text = "Amount";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(74, 254);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 20);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(74, 291);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(86, 20);
            this.CommentLabel.TabIndex = 5;
            this.CommentLabel.Text = "Comments";
            this.CommentLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // TransactionIdBox
            // 
            this.TransactionIdBox.Location = new System.Drawing.Point(204, 100);
            this.TransactionIdBox.Name = "TransactionIdBox";
            this.TransactionIdBox.Size = new System.Drawing.Size(277, 26);
            this.TransactionIdBox.TabIndex = 6;
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(204, 134);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(277, 26);
            this.CategoryNameBox.TabIndex = 7;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(204, 169);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(277, 26);
            this.AmountBox.TabIndex = 8;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(204, 254);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(277, 26);
            this.DateTimePicker.TabIndex = 9;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(204, 291);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(277, 79);
            this.CommentBox.TabIndex = 10;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(78, 391);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(89, 47);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(237, 391);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(89, 47);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(392, 391);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(89, 52);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Transaction Type";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(204, 211);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(277, 28);
            this.TypeComboBox.TabIndex = 15;
            // 
            // TransUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 484);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.CategoryNameBox);
            this.Controls.Add(this.TransactionIdBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.TransactionIdLabel);
            this.Controls.Add(this.label1);
            this.Name = "TransUpdateForm";
            this.Text = "TransUpdateForm";
            this.Load += new System.EventHandler(this.TransUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TransactionIdLabel;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox TransactionIdBox;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TypeComboBox;
    }
}