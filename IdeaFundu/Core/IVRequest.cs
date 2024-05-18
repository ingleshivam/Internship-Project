using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("IVRequestTbl")]
    public class IVRequest
    {
        [Key]
        public Int64 IVRequestID { set; get; }
        [Required(ErrorMessage ="Investment Request Description Required")]
        public string IVRequestDesc { set; get; }

        [ForeignKey("Investor")]
        public Int64 InvestorID { set; get; }
        [Required]
        public decimal AmountToBeInvested { set; get; }
        public virtual Investor Investor { set; get; }

        [ForeignKey("Idea")]
        public Int64 IdeaID { set; get; }
        public virtual Idea Idea { set; get; }

    }
}
