using OrderManagementSystem.Models;

namespace Service
{


    public interface IUserService
    {
        bool RegisterUser(User user);
        User GetUserById(int userId);
        string GenerateJwtToken(int userId, string userName);
        bool ValidateUser(int userId, string password);
        
    }
}
