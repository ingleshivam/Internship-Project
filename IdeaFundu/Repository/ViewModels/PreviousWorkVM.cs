using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class PreviousWorkVM
    {
        public Int64 PreviousWorkID { set; get; }

        //[Required(ErrorMessage = "Work Title Required")]
        public string WorkTitle { set; get; }

        //[Required(ErrorMessage = "Work Description Required")]
        public string WorkDescription { set; get; }

        //[Range(1, int.MaxValue, ErrorMessage = "Duration Required")]
        public Int64 Duration { set; get; }

        //[Range(0.01, double.MaxValue, ErrorMessage = "Tentative Budget Required")]
        public decimal TentativeBudget { set; get; }
        public Int64 UserID { set; get; }
        public virtual PreviousWorksVM PreviousWorks { set; get; }
        public virtual User User { set; get; }
    }
}
