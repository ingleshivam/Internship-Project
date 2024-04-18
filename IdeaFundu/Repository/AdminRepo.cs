using Infra;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdminRepo : IAdmin
    {
        CompanyContext cc;
        public AdminRepo(CompanyContext cc)
        {
            this.cc = cc;   
        }
        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var userExits = this.cc.Admins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            if(userExits != null)
            {
                res.IsSuccess = true;
                res.LoggedInID = userExits.AdminID;
                res.LoggedInName = userExits.FullName;
            }
            else
            {
                res.IsSuccess = false;
                res.ErrorMessage = "Email ID and Password cannot match !";
            }
            return res;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
