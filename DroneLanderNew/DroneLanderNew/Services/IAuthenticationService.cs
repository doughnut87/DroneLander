using System.Threading.Tasks;

namespace DroneLanderNew.Services
{
    public interface IAuthenticationService
    {
        Task<bool> SignInAsync();
        Task<bool> SignOutAsync();
    }
}