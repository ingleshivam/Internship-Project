using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryID { set; get; }
        public string CategoryName { set; get; }
        public virtual List<SubCategory> SubCategories { set; get; }
    }
}
