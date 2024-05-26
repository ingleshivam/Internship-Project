using Repository.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class IdeaInvestmentTotalVM
    {
        [SelectRequired(ErrorMessage ="Idea Name is Required")]
        public Int64 IdeaID { set; get; }
        public string IdeaName { set; get; }
        public decimal MinimumInvestmentLimit { set; get; }
        public decimal TotalAmount { set; get; }
    }
}
