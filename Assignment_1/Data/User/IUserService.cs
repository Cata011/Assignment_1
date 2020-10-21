using Models;

namespace Assignment_1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);

        void CreateNewUser(string username, string password, string role, int securityLevel);
        
    }
}