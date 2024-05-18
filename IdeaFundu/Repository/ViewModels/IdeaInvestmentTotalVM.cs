using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class IdeaInvestmentTotalVM
    {
        public Int64 IdeaID { set; get; }
        public string IdeaName { set; get; }
        public decimal TotalAmount { set; get; }
    }
}
