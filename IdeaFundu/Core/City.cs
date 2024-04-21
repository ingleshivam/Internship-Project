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
        [Required(ErrorMessage ="City Name Required")]
        public string CityName { set; get; }
        [ForeignKey("State")]
        [Required(ErrorMessage ="State Name Required")]
        public Int64 StateID { set; get; }
        public virtual State State { set; get; }
    }
}
