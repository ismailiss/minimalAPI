using WebApiMini.Models;
using WebApiMini.Repositories;

namespace WebApiMini.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user =UserRepository.Users.FirstOrDefault(o=>o.UserName.Equals(userLogin.UserName, StringComparison.OrdinalIgnoreCase) && o.Password.Equals(userLogin .Password));
            return user;
         }
    }
}
