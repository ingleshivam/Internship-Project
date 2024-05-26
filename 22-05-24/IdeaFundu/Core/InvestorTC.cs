using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("InvestorTCTbl")]
    public class InvestorTC
    {
        [Key]
        public Int64 InvestorTCID { set; get; }
        [Required(ErrorMessage = "Terms & Condition Title is required")]
        public string InvestorTCTitle { set; get; }

        [Required(ErrorMessage ="Terms & Condition Description is Required")]
        [MinLength(70,ErrorMessage = "Minimum length of the description is 70 Characters")]
        public string InvestorTCDesc { set; get; }
    }
}



