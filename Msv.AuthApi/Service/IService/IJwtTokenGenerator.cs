using Msv.Services.AuthApi.Models;

namespace Msv.Services.AuthApi.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
