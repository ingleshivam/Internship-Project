using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class InvestorIdNameVM
    {
        public Int64 InvestorID { set; get; }
        public string FullName { set; get; }
    }
}
