using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class StateVM
    {
        public Int64 StateID { set; get; }
        public string StateName { set; get; }
    }
}
