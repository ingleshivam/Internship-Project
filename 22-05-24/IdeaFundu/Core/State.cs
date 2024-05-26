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
        public string StateName { set; get; }

        [ForeignKey("Country")]
        public Int64 CountryID { set; get; }
        public virtual Country Country { set; get; }
    }
}
