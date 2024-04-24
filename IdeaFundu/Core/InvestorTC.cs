using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("InvestorTCTbl")]
    public class InvestorTC
    {
        [Key]
        public Int64 InvestorTCID { set; get; }
        public string InvestorTCTitle { set; get; }
        public string InvestorTCDesc { set; get; }         
    }
}
