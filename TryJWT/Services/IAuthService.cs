using System.Threading.Tasks;
using TryJWT.Models;

namespace TryJWT.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegiserModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
