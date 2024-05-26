using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SolutionTbl")]
    public class Solution
    {
        [Key]
        public Int64 SolutionID { set; get; }
        public string SolutionDesc { set; get; }

        [ForeignKey("Query")]
        public Int64 QueryID { set; get; }
        public DateTime SolutionDate { set; get; }
        public virtual Query Query { set; get; }
    }
}
