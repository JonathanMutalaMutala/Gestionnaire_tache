using Microsoft.AspNetCore.Identity;

namespace Gestionnaire_tache_API.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
