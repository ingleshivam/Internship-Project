using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserTCTbl")]
    public class UserTC
    {
        [Key]
        public Int64 UserTCID { set; get; }
        public string UserTCTitle { set; get; }
        public string USerTCDesc { set; get; }
    }
}
