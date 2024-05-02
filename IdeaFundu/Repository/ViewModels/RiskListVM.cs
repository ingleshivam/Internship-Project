using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class RiskListVM
    {
        public Int64 RiskID { set; get; }
        public string RiskTitle { set; get; }
        public string RiskDescription { set; get; }
        public int RiskLevel { set; get; }
        public Int64 IdeaID { set; get; }
    }
}
