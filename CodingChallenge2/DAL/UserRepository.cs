using System;
using System.Linq;
using OrderManagementSystem;
using OrderManagementSystem.DAL;
using OrderManagementSystem.Models;

namespace DAL
{
    // Repository class is used to implement all Data access operations
    public class UserRepository : IUserRepository
    {
        private readonly KeepDbContext _dbContext;

        public UserRepository(KeepDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool RegisterUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return true;
        }

        public User GetUserById(int userId)
        {
            return _dbContext.Users.Find(userId);
        }

        public bool ValidateUser(int userId, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UserId == userId && u.Password == password);
            return user != null;
        }

    }
}
