using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("PreviousWorkTbl")]
    public class PreviousWork
    {
        [Key]
        public Int64 PreviousWorkID { set; get; }
        
        public string WorkTitle { set; get; }

        public string WorkDescription { set; get; }

        public Int64 Duration { set; get; }

        public decimal TentativeBudget { set; get; }

        [ForeignKey("User")]
        public Int64 UserID {set;get;}
        public virtual User User { set; get; }
    }
}
