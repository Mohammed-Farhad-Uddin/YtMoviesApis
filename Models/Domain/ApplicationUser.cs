using Microsoft.AspNetCore.Identity;

namespace YtMoviesApis.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
    }
}
