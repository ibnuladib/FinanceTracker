namespace LabForm.Forms
{
    partial class CatAddForm
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
            this.AddCategoryHeading = new System.Windows.Forms.Label();
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.NewCatTextBox = new System.Windows.Forms.TextBox();
            this.CatAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCategoryHeading
            // 
            this.AddCategoryHeading.AutoSize = true;
            this.AddCategoryHeading.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryHeading.Location = new System.Drawing.Point(114, 24);
            this.AddCategoryHeading.Name = "AddCategoryHeading";
            this.AddCategoryHeading.Size = new System.Drawing.Size(220, 56);
            this.AddCategoryHeading.TabIndex = 0;
            this.AddCategoryHeading.Text = "Add Category";
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(39, 114);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(154, 20);
            this.CategoryNameLabel.TabIndex = 1;
            this.CategoryNameLabel.Text = "New Category Name";
            this.CategoryNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewCatTextBox
            // 
            this.NewCatTextBox.Location = new System.Drawing.Point(199, 114);
            this.NewCatTextBox.Name = "NewCatTextBox";
            this.NewCatTextBox.Size = new System.Drawing.Size(162, 26);
            this.NewCatTextBox.TabIndex = 2;
            this.NewCatTextBox.TextChanged += new System.EventHandler(this.NewCatTextBox_TextChanged);
            // 
            // CatAddButton
            // 
            this.CatAddButton.Location = new System.Drawing.Point(162, 331);
            this.CatAddButton.Name = "CatAddButton";
            this.CatAddButton.Size = new System.Drawing.Size(110, 62);
            this.CatAddButton.TabIndex = 3;
            this.CatAddButton.Text = "Add";
            this.CatAddButton.UseVisualStyleBackColor = true;
            this.CatAddButton.Click += new System.EventHandler(this.CatAddButton_Click);
            // 
            // CatAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 462);
            this.Controls.Add(this.CatAddButton);
            this.Controls.Add(this.NewCatTextBox);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.AddCategoryHeading);
            this.Name = "CatAddForm";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.CatAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddCategoryHeading;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.TextBox NewCatTextBox;
        private System.Windows.Forms.Button CatAddButton;
    }
}