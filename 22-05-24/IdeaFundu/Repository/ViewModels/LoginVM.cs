using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage ="Email Address is not valid !")]
        [Display(Name ="Email Address")]
        public string EmailID { set; get; }

        [Required(ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        public string Password { set; get; }
    }
}
