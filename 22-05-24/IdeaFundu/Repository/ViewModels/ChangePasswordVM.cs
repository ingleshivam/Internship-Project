using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class ChangePasswordVM
    {
        [Required(ErrorMessage = "Please Enter Old Password First")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "Please Enter New Password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("NewPassword", ErrorMessage = "New Password does not match with the Confirm Password !")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
