using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("WorkProgressTbl")]
    public class WorkProgress
    {
        [Key]
        public Int64 WorkProgressID { set; get; }
        public DateTime StartDate { set; get; }
        public string CurrentStatus { set; get; }
        public DateTime ExpectedCompletionDate { set; get; }
        public string Remarks { set; get; }

        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }
        public virtual Idea Idea { set; get; }
    }
}
