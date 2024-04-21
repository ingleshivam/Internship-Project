using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class State
    {
        [Key]
        public Int64 StateID { set; get; }
        [Required(ErrorMessage ="State Name Required")]
        public string StateName { set; get; }

        [ForeignKey("Country")]
        [Required(ErrorMessage ="Country Name Required")]
        public Int64 CountryID { set; get; }
        public virtual Country Country { set; get; }
        public virtual List<City> Cities { set; get; }
    }
}
