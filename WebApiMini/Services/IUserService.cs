using WebApiMini.Models;

namespace WebApiMini.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
