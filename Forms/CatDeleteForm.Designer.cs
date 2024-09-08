namespace LabForm.Forms
{
    partial class CatDeleteForm
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
            this.deleteLabelHeading = new System.Windows.Forms.Label();
            this.SelectCategoryLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectCategoryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteLabelHeading
            // 
            this.deleteLabelHeading.AutoSize = true;
            this.deleteLabelHeading.Font = new System.Drawing.Font("Myanmar Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabelHeading.Location = new System.Drawing.Point(92, 9);
            this.deleteLabelHeading.Name = "deleteLabelHeading";
            this.deleteLabelHeading.Size = new System.Drawing.Size(253, 56);
            this.deleteLabelHeading.TabIndex = 0;
            this.deleteLabelHeading.Text = "Delete Category";
            this.deleteLabelHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectCategoryLabel
            // 
            this.SelectCategoryLabel.AutoSize = true;
            this.SelectCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCategoryLabel.Location = new System.Drawing.Point(53, 161);
            this.SelectCategoryLabel.Name = "SelectCategoryLabel";
            this.SelectCategoryLabel.Size = new System.Drawing.Size(138, 22);
            this.SelectCategoryLabel.TabIndex = 1;
            this.SelectCategoryLabel.Text = "Select Category";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(158, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SelectCategoryBox
            // 
            this.SelectCategoryBox.FormattingEnabled = true;
            this.SelectCategoryBox.Location = new System.Drawing.Point(206, 158);
            this.SelectCategoryBox.Name = "SelectCategoryBox";
            this.SelectCategoryBox.Size = new System.Drawing.Size(162, 28);
            this.SelectCategoryBox.TabIndex = 4;
            // 
            // CatDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 462);
            this.Controls.Add(this.SelectCategoryBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectCategoryLabel);
            this.Controls.Add(this.deleteLabelHeading);
            this.Name = "CatDeleteForm";
            this.Text = "Delete Category";
            this.Load += new System.EventHandler(this.CatDel_FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteLabelHeading;
        private System.Windows.Forms.Label SelectCategoryLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SelectCategoryBox;
    }
}