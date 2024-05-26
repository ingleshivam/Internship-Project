using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SubCategoryTbl")]
    public class SubCategory
    {
        [Key]
        public Int64 SubCategoryID { set; get; }

        [Required(ErrorMessage ="Sub Catgory Name Required")]
        public string SubCategoryName { set; get; }

        [ForeignKey("Category")]
        [Range(1,int.MaxValue,ErrorMessage ="Category Name Required")]
        public Int64 CategoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
