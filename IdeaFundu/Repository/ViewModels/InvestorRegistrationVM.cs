using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.ValidationAttributes;
namespace Repository.ViewModels
{
    public class InvestorRegistrationVM
    {
        [Required(ErrorMessage = "First Name Required")]
        public string FirstName { set; get; }

        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { set; get; }
        
        [Required(ErrorMessage = "Email ID Required")]
        [EmailAddress(ErrorMessage = "Email Id is not Valid !")]
        public string InvestorEmail { set; get; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { set; get; }

        [SelectRequired(ErrorMessage ="City Name Required")]
        public Int64 CityID { set; get; }

        [SelectRequired(ErrorMessage = "Country Name Required")]
        public Int64 CountryID { set; get; }

        [SelectRequired(ErrorMessage = "State Name Required")]
        public Int64 StateID { set; get; }
        
        [CheckboxRequired(ErrorMessage ="Please agree to all the terms and conditions")]
        public bool isChecked { set; get; }

    }
}
