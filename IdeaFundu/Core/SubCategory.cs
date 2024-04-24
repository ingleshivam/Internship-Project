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
        public string SubCategoryName { set; get; }

        [ForeignKey("Category")]
        public Int64 CategoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
