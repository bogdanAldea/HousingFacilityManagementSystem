using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int IssueDate { get; set; }
        public decimal Payment { get; set; }
        public decimal  Penalties { get; set; }
        public bool IsPaid { get; set; }
    }
}
