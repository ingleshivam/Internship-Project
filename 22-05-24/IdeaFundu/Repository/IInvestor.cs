using Core;
using Repository.ViewModels;
namespace Repository
{
    public interface IInvestor
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);

        RepoResultVM SignUp(InvestorRegistrationVM rec);

        RepoResultVM EditProfile(InvestorProfileVM rec, Int64 id);
        UserProfileVM GetById(Int64 id);
        List<Investor> GetAllUsers();
        List<TotalInvestmentDetailsVM> GetInvestorWiseReport(long IdeaID, long UserID);
        List<InvestorIdNameVM> GetAllInvestorsIdeaWise(Int64 UserID);
        //void Logout();
    }
}