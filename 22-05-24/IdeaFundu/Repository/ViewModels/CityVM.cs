using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class CityVM
    {
        public string CityName { set; get; }
        [ForeignKey("State")]
        public Int64 StateID { set; get; }
        [ForeignKey("Country")]
        public Int64 CountryID { set; get; }
        public State State { set; get; }
        public Country Country { set; get; }
    }
}
