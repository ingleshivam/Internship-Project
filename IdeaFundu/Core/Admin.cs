using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    [Table("AdminTbl")]
    public class Admin
    {
        [Key]
        public Int64 AdminID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }

        [NotMapped]
        public string FullName { 
            get
            {
                return FirstName + LastName;
            }
        }
        public string EmailID { set; get; }
        public string MobileNumber { set; get; }
        public string Password { set; get; }
    }
}