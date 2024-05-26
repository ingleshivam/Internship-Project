using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserTCTbl")]
    public class UserTC
    {
        [Key]
        public Int64 UserTCID { set; get; }

        [Required(ErrorMessage = "Terms & Condition Title is required")]
        public string UserTCTitle { set; get; }

        [Required(ErrorMessage = "Terms & Condition Description is Required")]
        [MinLength(70, ErrorMessage = "Minimum length of the description is 70 Characters")]
        public string USerTCDesc { set; get; }
    }
}
