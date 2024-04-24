using Core;
using Infra;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepo : IUser
    {
        CompanyContext cc;
        public UserRepo(CompanyContext cc)
        {
            this.cc = cc;   
        }

        public RepoResultVM ChangePassword(ChangePasswordVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            var oldrec = this.cc.Admins.Find(id);
            if (oldrec.Password == rec.OldPassword)
            {
                oldrec.Password = rec.NewPassword;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Password Changed Successfully!";
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid Old Password!";
            }

            return res;
        }

        //public RepoResultVM EditProfile(AdminProfileVM rec, long id)
        //{
        //    RepoResultVM res = new RepoResultVM();
        //    try
        //    {
        //        var oldrec = this.cc.Admins.Find(id);
        //        oldrec.FirstName = rec.FirstName;
        //        oldrec.LastName = rec.LastName;
        //        oldrec.MobileNumber = rec.MobileNumber;
        //        this.cc.SaveChanges();
        //        res.IsSuccess = true;
        //        res.Message = "Profile Updated Successfully !";
        //    }
        //    catch (Exception ex)
        //    {
        //        res.IsSuccess = false;
        //        res.Message = ex.Message.ToString();
        //    }

        //    return res;
        //}

        //public AdminProfileVM GetById(long id)
        //{
        //    var rec = (from t in this.cc.Admins
        //               where t.AdminID == id
        //               select new AdminProfileVM
        //               {
        //                   FirstName = t.FirstName,
        //                   LastName = t.LastName,
        //                   MobileNumber = t.MobileNumber
        //               }).FirstOrDefault();
        //    return rec;
        //}

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

        public RepoResultVM SignUp(User rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.Users.Add(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "SignUp Successfull!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
