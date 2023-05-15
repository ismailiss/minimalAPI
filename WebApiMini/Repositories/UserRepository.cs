using WebApiMini.Models;

namespace WebApiMini.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { UserName = "luke_admin", EmailAdress = "luke.admin@email.com", Password = "MyPass_w0rd", GivenName = "Luke", SurName = "Rogers", Role = "Administrator" },
            new() { UserName = "lydia_standard", EmailAdress = "lydia.standard@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", SurName = "Burton", Role = "Standard" },

        };

    }
}
