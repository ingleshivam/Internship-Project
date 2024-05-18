﻿using Core;
using Infra;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InvestorRepo : IInvestor
    {
        CompanyContext cc;
        public InvestorRepo(CompanyContext cc)
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

        public RepoResultVM EditProfile(InvestorProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.cc.Users.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.MobileNumber = rec.InvestorMobile;
                oldrec.Address = rec.InvestorAddress;
                oldrec.ShortProfileDesc = rec.ShortProfileDesc;
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
            var userExits = this.cc.Investors.SingleOrDefault(p => p.InvestorEmail == rec.EmailID && p.Password == rec.Password);
            if(userExits != null)
            {
                res.IsSuccess = true;
                res.LoggedInID = userExits.InvestorID;
                res.LoggedInName = userExits.FullName;
            }
            else
            {
                res.IsSuccess = false;
                res.ErrorMessage = "Email ID and Password cannot match !";
            }
            return res;
        }

        public RepoResultVM SignUp(InvestorRegistrationVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                Investor investor = new Investor();
                investor.FirstName = rec.FirstName;
                investor.LastName = rec.LastName;
                investor.InvestorEmail= rec.InvestorEmail;
                investor.CityID = rec.CityID;
                investor.Password = rec.Password;
                this.cc.Investors.Add(investor);
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

        public List<Investor> GetAllUsers()
        {
            return this.cc.Investors.ToList();
        }
    }
}