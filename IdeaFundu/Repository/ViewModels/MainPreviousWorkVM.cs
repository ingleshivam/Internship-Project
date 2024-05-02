using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class MainPreviousWorkVM
    {
        public string WorkTitle { set; get; }

        public string WorkDescription { set; get; }

        public int Duration { set; get; }

        public decimal TentativeBudget { set; get; }
        public List<PreviousWorkVM> ListOfPreviousWork { set; get; }
    }
}
