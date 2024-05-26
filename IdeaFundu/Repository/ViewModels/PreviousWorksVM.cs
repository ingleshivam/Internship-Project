using Microsoft.Identity.Client;
using Repository.ValidationAttributes;
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
        [ListString(ErrorMessage = "Work Title Required")]
        public List<string> WorkTitle { set; get; }

        [ListString(ErrorMessage = "Work Description Required")]
        public List<string> WorkDescription { set; get; }

        [ListString(ErrorMessage = "Duration Required")]
        public List<string> Duration { set; get; }

        [ListString(ErrorMessage ="Tentative Budget Required")]
        public List<string> TentativeBudget { set; get; }

        //[Required(ErrorMessage = "User ID is required")]
        public List<Int64> UserID { set; get; }

        public PreviousWorksVM()
        {
            WorkTitle = new List<string>();
            WorkDescription = new List<string>();
            Duration = new List<string>();
            TentativeBudget = new List<string>();
            UserID = new List<long>();
        }
    }
}
