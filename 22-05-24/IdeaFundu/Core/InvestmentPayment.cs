using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("InvestmentPaymentTbl")]
    public class InvestmentPayment
    {
        [Key]
        public Int64 PaymentID { set; get; }
        public decimal PaymentAmount { set; get; }
        public DateTime PaymentDate { set; get; }
        public int PaymentMode { set; get; }

        [ForeignKey("AcceptInvestment")]
        public Int64 AcceptIVID { set; get; }
        public virtual AcceptInvestment AcceptInvestment { set; get; }
    }
}
