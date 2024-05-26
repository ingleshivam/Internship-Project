using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class WorkProgressClosureVM
    {
        public Int64 WorkProgressID { set; get; }
        public DateTime StartDate { set; get; }
        public string CurrentStatus { set; get; }
        public DateTime ExpectedCompletionDate { set; get; }
        public Int64 WorkClosureID { set; get; }
        public DateTime ClosureDate { set; get; }
        public string ClosureStatus { set; get; }
        public string WorkStatus { set; get; }
    }
}
