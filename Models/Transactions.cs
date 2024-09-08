using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForm.Models
{
    public class Transactions
    {
        public int TransactionId { get; set; }

        // Foreign key referencing the Category
        public int CategoryId { get; set; }

        // The amount involved in the transaction
        public decimal Amount { get; set; }

        // Date and time when the transaction occurred
        public DateTime TransactionDate { get; set; }

        // Additional details or notes about the transaction
        public string Comments { get; set; }

        // Type of transaction (e.g., "Income" or "Expense")
        public string TransactionType { get; set; }

        public string CategoryName { get; set; }

        public Category Category { get; set; }

    }
}
