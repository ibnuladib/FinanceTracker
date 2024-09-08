using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForm.Models
{
    public class Category
    {
            // Unique identifier for each category
            public int CategoryId { get; set; }

            // Name of the category (e.g., "Food", "Rent")
            public string CategoryName { get; set; }

            public List<Transactions> Transactions { get; set; } = new List<Transactions>();
    }
    }

