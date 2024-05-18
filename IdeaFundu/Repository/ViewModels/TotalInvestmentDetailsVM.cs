using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class TotalInvestmentDetailsVM
    {
        public string FullName { set; get; }
        public string InvestorMobile { set; get; }
        public string InvestorEmail { set; get; }
        public string InvestorAddress { set; get; }
        public string CityName { set; get; }
        public decimal PaymentAmount { set; get; }
        public int PaymentMode { set; get; }
        public DateTime PaymentDate { set; get; }
        public decimal TotalInvAmount { set; get; }
        public Int64 IdeaID { set; get; }
    }
}
