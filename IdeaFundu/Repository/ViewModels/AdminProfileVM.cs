using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class AdminProfileVM
    {
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { set; get; }
        
        [Required(ErrorMessage ="Last Name Required")]
        public string LastName { set; get; }

        [Required(ErrorMessage ="Mobile Number Required")]
        public string MobileNumber { set; get; }
    }
}
