using Core;
using Infra;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public List<InvestorIdNameVM> GetAllInvestorsIdeaWise(Int64 UserID)
        {
            //var record = from t in this.cc.Investors
            //             select t;
            //where t.IdeaID == t1.IdeaID && t1.InvestorID == t2.InvestorID
            //select new InvestorIdNameVM
            //{
            //    InvestorID = t2.InvestorID,
            //    FullName = t2.FullName
            //};

            var record = (from t1 in this.cc.IVRequests
                          join t2 in this.cc.Investors
                          on t1.InvestorID equals t2.InvestorID
                          where t1.Idea.UserID == UserID
                          select new InvestorIdNameVM
                          {
                              FullName = t2.FullName,
                              InvestorID = t2.InvestorID
                          }).Distinct();



            return record.ToList();
             
        }

        public List<TotalInvestmentDetailsVM> GetInvestorWiseReport(long InvestorID, long UserID)
        {
            var v = from t1 in this.cc.Investors.ToList()
                    join t2 in this.cc.IVRequests.ToList()
                    on t1.InvestorID equals t2.InvestorID
                    join t3 in this.cc.AcceptInvestments.ToList()
                    on t2.IVRequestID equals t3.IVRequestID
                    join t4 in this.cc.InvestmentPayments.ToList()
                    on t3.AcceptIVID equals t4.AcceptIVID
                    where t2.InvestorID == InvestorID && t2.Idea.UserID == UserID
                    group t4 by new
                    {
                        t1.FullName,
                        t2.Idea.IdeaName,
                        t4.PaymentAmount,
                        t4.PaymentDate,

                    } into g
                    select new TotalInvestmentDetailsVM
                    {
                        FullName = g.Key.FullName,
                        PaymentAmount = g.Key.PaymentAmount,
                        PaymentDate = g.Key.PaymentDate,
                        TotalInvAmount = g.Sum(p => p.PaymentAmount),
                        IdeaName = g.Key.IdeaName
                    };

            return v.ToList();
        }
    }
}
