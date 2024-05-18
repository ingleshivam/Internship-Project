using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class PreviousWorksVM
    {
        public List<string> WorkTitle { set; get; }
        public List<string> WorkDescription { set; get; }
        public List<int> Duration { set; get; }
        public List<decimal> TentativeBudget { set; get; }
        public List<Int64> UserID { set; get; }

        public PreviousWorksVM()
        {
            WorkTitle = new List<string>();
            WorkDescription = new List<string>();
            Duration = new List<int>();
            TentativeBudget = new List<decimal>();
            UserID = new List<long>();
        }
    }
}
