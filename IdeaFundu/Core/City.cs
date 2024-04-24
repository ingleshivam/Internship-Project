using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CityTbl")]
    public class City
    {
        [Key]
        public Int64 CityID { set; get; }
        public string CityName { set; get; }
        [ForeignKey("State")]
        public Int64 StateID { set; get; }
        public virtual State State { set; get; }
    }
}
