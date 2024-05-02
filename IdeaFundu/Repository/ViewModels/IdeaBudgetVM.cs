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
    public class IdeaBudgetVM
    {
        public Int64 IdeaID { set; get; }
        [Required(ErrorMessage ="Idea Name is Required")]
        public string IdeaName { set; get; }

        public string SubCategoryName { set; get; }
        [Required(ErrorMessage ="Sub Category Required")]
        [ForeignKey("SubCategory")]
        public Int64 SubCategoryID { set; get; }

        [Required(ErrorMessage ="Budget Amount Requied")]
        public decimal BudgetAmount { set; get; }

        [Required(ErrorMessage ="Maximum Investment Limit Required")]
        public decimal MaximumInvestmentLimit { set; get; }

        [Required(ErrorMessage ="Minimum Investment Limit Required")]
        public decimal MinimumInvestmentLimit { set; get; }

        [ForeignKey("User")]
        public Int64 UserID { set; get; }
        public virtual SubCategory SubCategory { set; get; }
        public virtual User User { set; get; }
    }
}




