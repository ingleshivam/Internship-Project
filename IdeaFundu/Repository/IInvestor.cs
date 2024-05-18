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
        //void Logout();
    }
}