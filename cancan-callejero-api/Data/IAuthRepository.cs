using System.Threading.Tasks;
using cancan_callejero_api.Models;

namespace cancan_callejero_api.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);

    }
}