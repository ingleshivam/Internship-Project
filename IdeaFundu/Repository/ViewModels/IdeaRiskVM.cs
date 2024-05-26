using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.ValidationAttributes;

namespace Repository.ViewModels
{
    public class IdeaRiskVM
    {
        [SelectRequired(ErrorMessage ="Idea Name Required")]
        public Int64 IdeaID { set; get; }

        [Required(ErrorMessage = "Risk Title Required")]
        public string RiskTitle { set; get; }
        [Required]
        [StringLength(1000, MinimumLength = 200, ErrorMessage = "Description should be minimum of 200 chars and maximum of 1000 chars.")]
        public string RiskDescription { set; get; }

        [SelectRequired(ErrorMessage = "Risk Level Required")]
        public int RiskLevel { set; get; }
    }
}
