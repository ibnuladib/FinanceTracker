using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForm.Models
{
    public class Category
    {
            public int CategoryId { get; set; }

            public string CategoryName { get; set; }

            public List<Transactions> Transactions { get; set; } = new List<Transactions>();
    }
    }

