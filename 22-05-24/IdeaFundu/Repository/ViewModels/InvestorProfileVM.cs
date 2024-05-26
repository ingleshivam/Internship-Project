using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class InvestorProfileVM
    {
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { set; get; }

        [Required(ErrorMessage ="Last Name Required")]
        public string LastName { set; get; }

        [Required(ErrorMessage ="Address Required")]
        public string InvestorAddress { set; get; }

        [Required(ErrorMessage ="Mobile Number Required")]
        public string InvestorMobile { set; get; }

        [Required(ErrorMessage ="Short Profile Description Required")]
        public string ShortProfileDesc { set; get; }
        public Int64 CityID { set; get; }
        public Int64 StateID { set; get; }
        public Int64 CountryID { set; get; }
    }
}
