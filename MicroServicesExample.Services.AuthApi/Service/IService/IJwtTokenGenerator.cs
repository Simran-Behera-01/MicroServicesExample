using MicroServicesExample.Services.AuthApi.Models;

namespace MicroServicesExample.Services.AuthApi.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
