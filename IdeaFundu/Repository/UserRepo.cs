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
            var oldrec = this.cc.Users.Find(id);
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

        public RepoResultVM EditProfile(UserProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.cc.Users.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.MobileNumber = rec.MobileNumber;
                oldrec.Address = rec.Address;
                oldrec.ShortProfileDesc = rec.ShortProfileDesc;
                oldrec.EducationDetails = rec.EducationDetails;
                oldrec.Pincode = rec.Pincode;
                oldrec.CityID = rec.CityID;
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Updated Successfully !";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message.ToString();
            }

            return res;
        }

        public UserProfileVM GetById(long id)
        {
            var rec = (from t in this.cc.Users
                       where t.UserID == id
                       select new UserProfileVM
                       {
                           FirstName = t.FirstName,
                           LastName = t.LastName,
                           MobileNumber = t.MobileNumber,
                           Address = t.Address,
                           ShortProfileDesc = t.ShortProfileDesc,
                           EducationDetails = t.EducationDetails,
                           Pincode = t.Pincode,
                           CityID = t.CityID
                       }).FirstOrDefault();
            return rec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var userExits = this.cc.Users.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);
            if(userExits != null)
            {
                res.IsSuccess = true;
                res.LoggedInID = userExits.UserID;
                res.LoggedInName = userExits.FullName;
            }
            else
            {
                res.IsSuccess = false;
                res.ErrorMessage = "Email ID and Password cannot match !";
            }
            return res;
        }

        public RepoResultVM SignUp(UserRegistrationVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                User user = new User();
                user.FirstName = rec.FirstName;
                user.LastName = rec.LastName;
                user.EmailID = rec.EmailID;
                user.CityID = rec.CityID;
                user.Password = rec.Password;
                this.cc.Users.Add(user);
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

        public List<User> GetAllUsers()
        {
            return this.cc.Users.ToList();
        }
    }
}
