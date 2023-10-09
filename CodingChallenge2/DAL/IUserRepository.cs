using OrderManagementSystem.Models;

namespace DAL
{
    /*
	 * Should not modify this interface. You have to implement these methods in
	 * corresponding Impl classes
	 */

    public interface IUserRepository
    {
        bool RegisterUser(User user);
        User GetUserById(int userId);
        bool ValidateUser(int userId, string password);
       
    }
}
