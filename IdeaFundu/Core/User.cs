using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserTbl")]
    public class User
    {
        [Key]
        public Int64 UserID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        [NotMapped]
        public string FullName { 
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Password { set; get; }

        public string Address { set; get; }
        [ForeignKey("City")]
        public Int64 CityID { set; get; }
        public string EmailID { set; get; }
        public string MobileNumber { set; get; }
        public string ShortProfileDesc { set; get; }
        public string EducationDetails { set; get; }
        public string Pincode { set; get; }
        public bool IsVerified {
            get
            {
                return true;
            }
        }
        public virtual City City { set; get; }
    }
}
