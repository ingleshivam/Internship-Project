using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CountryTbl")]
    public class Country
    {
        [Key]
        public Int64 CountryID { set; get; }
        [Required(ErrorMessage ="Country Name Required")]
        public string CountryName { set; get; }
        public virtual List<State> States { set; get; }
    }
}
