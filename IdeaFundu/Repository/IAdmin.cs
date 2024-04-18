using Repository.ViewModels;
namespace Repository
{
    public interface IAdmin
    {
        LoginResultVM Login(LoginVM rec);
        void Logout();
    }
}