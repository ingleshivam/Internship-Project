using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("QueryTbl")]
    public class Query
    {
        [Key]
        public Int64 QueryID { set; get; }
        public string QueryDescription { set; get; }
        
        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }
        public DateTime QueryDate { set; get; }

        [ForeignKey("Investor")]
        public Int64 InvestorID { set; get; }
        public virtual Idea Idea { set; get; }
        public virtual Investor Investor { set; get; }
    }
}
