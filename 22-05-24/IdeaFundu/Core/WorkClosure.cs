using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("WorkClosureTbl")]
    public class WorkClosure
    {
        [Key]
        public Int64 WorkClosureID { set; get; }
        public DateTime ClosureDate { set; get; }
        public string ClosureStatus { set; get; }

        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }
        public virtual Idea Idea { set; get; }
    }
}
