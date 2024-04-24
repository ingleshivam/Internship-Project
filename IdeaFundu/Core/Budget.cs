using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("BudgetTbl")]
    public class Budget
    {
        [Key]
        public Int64 BudgetID { set; get; }

        public decimal BudgetAmount { set; get; }

        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }

        public decimal MaximumInvestmentLimit { set; get; }
        public decimal MinimumInvestmentLimit { set; get; }
        public virtual Idea Idea { set; get; }
    }
}
