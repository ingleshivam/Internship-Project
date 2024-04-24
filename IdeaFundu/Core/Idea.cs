using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("IdeaTbl")]
    public class Idea
    {
        [Key]
        public Int64 IdeaID { set; get; }
        public string IdeaName { set; get; }

        public string IdeaDescription { set; get; }

        [ForeignKey("IdeaRisk")]
        public Int64 RiskID { set; get; }

        [ForeignKey("SubCategory")]
        public Int64 SubCategoryID { set; get; }

        [ForeignKey("User")]
        public Int64 UserID { set; get; }
        public bool IdeaStatus {
            get 
            {
                return true ;
            }
        }
        public string PhotoFilePath { set; get; }
        [NotMapped]
        public IFormFile ActualFile { set; get; }
        public virtual User User { set; get; }
        public virtual IdeaRisk IdeaRisk { set; get; }
        public virtual SubCategory SubCategory { set; get; }
    }
}
