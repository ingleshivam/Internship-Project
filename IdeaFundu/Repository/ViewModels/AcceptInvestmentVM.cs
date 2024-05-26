using Core;
using Repository.Enums;
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
    public class AcceptInvestmentVM
    {
        public Int64 AcceptIVID { set; get; }
        public string AcceptIVDesc { set; get; }

        [ForeignKey("IVRequest")]
        public Int64 IVRequestID { set; get; }
        public decimal AmountAccepted { set; get; }
        public DateTime CloseBeforeDate { set; get; }
        public virtual IVRequest IVRequest { set; get; }

        [SelectRequired(ErrorMessage ="Please, Select Payment Mode")]
        public int PaymentMode { set; get; }
    }
}
