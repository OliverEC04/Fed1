using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.UI.Models
{
    public class Debtor
    {
        [PrimaryKey, AutoIncrement]
        public int DebtorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public double TotalAmount { get; set; } = 0;
    }
}