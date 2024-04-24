using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("AcceptInvestmentTbl")]
    public class AcceptInvestment
    {
        [Key]
        public Int64 AcceptIVID { set; get; }
        public string AcceptIVDesc { set; get; }

        [ForeignKey("IVRequest")]
        public Int64 IVRequestID { set; get; }
        public decimal AmountAccepted { set; get; }
        public DateTime CloseBeforeDate { set; get; }
        public virtual IVRequest IVRequest { set; get; }
    }
}
