using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class WorkProgressVM
    {
        [Required(ErrorMessage ="Start Date Required")]
        public DateTime StartDate { set; get; }

        [Required(ErrorMessage ="Current Status Requied")]
        public string CurrentStatus { set; get; }

        [Required(ErrorMessage ="Expected Completion Date Required")]
        public DateTime ExpectedCompletionDate { set; get; }

        [Required(ErrorMessage ="Remarks Required")]
        public string Remarks { set; get; }

        public Int64 IdeaID { set; get; }
    }
}
