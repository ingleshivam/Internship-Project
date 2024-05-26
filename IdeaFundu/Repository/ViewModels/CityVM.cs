using Core;
using Repository.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class CityVM
    {
        public Int64 CityID { set; get; }
        [Required(ErrorMessage ="City Name Required")]
        public string CityName { set; get; }

        [SelectRequired(ErrorMessage ="State Name Required")]
        public Int64 StateID { set; get; }

        [SelectRequired(ErrorMessage ="Country Name Required")]
        public Int64 CountryID { set; get; }
        //public State State { set; get; }
        //public Country Country { set; get; }
    }
}
