using Microsoft.AspNetCore.Identity;

namespace MicroServicesExample.Services.AuthApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
