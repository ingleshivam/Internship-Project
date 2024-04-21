using Repository.ViewModels;
namespace Repository
{
    public interface IAdmin
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);

        RepoResultVM EditProfile(AdminProfileVM rec, Int64 id);
        AdminProfileVM GetById(Int64 id);
        void Logout();
    }
}