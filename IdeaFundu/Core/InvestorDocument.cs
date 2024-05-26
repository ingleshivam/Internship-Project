using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("InvestorDocumentTbl")]
    public class InvestorDocument
    {
        [Key]
        public Int64 InvestorDocumentID { set; get; }
        public bool isOrganization { set; get; }
        public bool isNRI { set; get; }

        [Required(ErrorMessage ="CIN Number Required")]
        public string CIN { set; get; }
        
        [ForeignKey("Investor")]
        public Int64 InvestorID { set; get; }
        public virtual Investor Investor { set; get; }
    }
}
