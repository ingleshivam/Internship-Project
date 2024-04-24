using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("InvestorTbl")]
    public class Investor
    {
        [Key]
        public Int64 InvestorID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string InvestorAddress { set; get; }
        public string InvestorMobile { set; get; }

        [ForeignKey("City")]
        public Int64 CityID { set; get; }
        public string Password { set; get; }
        public string InvestorEmail { set; get; }
        public string ShortProfileDesc { set; get; }
        public virtual City City { set; get; }
    }
}
