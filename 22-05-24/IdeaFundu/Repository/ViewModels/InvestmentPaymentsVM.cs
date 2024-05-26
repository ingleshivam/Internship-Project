using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class InvestmentPaymentsVM
    {
        public Int64 IdeaID { set; get; }
        public string IdeaName { set; get; }
        public DateTime PaymentDate { set; get; }
        public int PaymentMode { set; get; }
        public decimal TotalAmount { set; get; }
    }
}
