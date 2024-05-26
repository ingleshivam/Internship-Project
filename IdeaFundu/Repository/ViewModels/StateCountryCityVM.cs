using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.ValidationAttributes;

namespace Repository.ViewModels
{
    public class StateCountryCityVM
    {
        [SelectRequired(ErrorMessage = "Country Name Required")]
        public Int64 CountryID { set; get; }

        [Required(ErrorMessage ="Country Name Required")]
        public string CountryName { set; get; }

        [SelectRequired(ErrorMessage ="State Name Required")]
        public Int64 StateID { set; get; }

        [Required(ErrorMessage = "State Name Required")]
        public string StateName { set; get; }

        [SelectRequired(ErrorMessage ="City Name Required")]
        public Int64 CityID { set; get; }

        [Required(ErrorMessage = "City Name Required")]
        public string CityName { set; get; }
    }
}
