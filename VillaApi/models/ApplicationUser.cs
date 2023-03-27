using Microsoft.AspNetCore.Identity;

namespace VillaApi.models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
