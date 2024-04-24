using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("MemberTbl")]
    public class Member
    {
        [Key]
        public Int64 MemberID { set; get; }
        
        public string MemberName { set; get; }
        
        public string MemberRole { set; get; }

        public string ShortProfileDesc { set; get; }

        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }
        public virtual Idea Idea { set; get; }
    }
}
