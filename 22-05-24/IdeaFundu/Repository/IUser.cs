using Core;
using Repository.ViewModels;
namespace Repository
{
    public interface IUser
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);

        RepoResultVM SignUp(UserRegistrationVM rec);

        RepoResultVM EditProfile(UserProfileVM rec, Int64 id);
        UserProfileVM GetById(Int64 id);
        List<User> GetAllUsers();
        //void Logout();
    }
}