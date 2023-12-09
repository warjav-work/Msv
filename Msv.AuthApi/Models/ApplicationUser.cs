using Microsoft.AspNetCore.Identity;

namespace Msv.Services.AuthApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
