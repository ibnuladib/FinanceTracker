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

        public int CategoryId { get; set; }

        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Comments { get; set; }

        public string TransactionType { get; set; }

        public string CategoryName { get; set; }

        public Category Category { get; set; }

    }
}
