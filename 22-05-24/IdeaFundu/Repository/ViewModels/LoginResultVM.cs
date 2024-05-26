using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.ViewModels
{
    public class LoginResultVM
    {
        public bool IsSuccess { set; get; }
        public string ErrorMessage { set; get; }
        public Int64 LoggedInID { set; get; }
        public string LoggedInName { set; get; }
    }
}
