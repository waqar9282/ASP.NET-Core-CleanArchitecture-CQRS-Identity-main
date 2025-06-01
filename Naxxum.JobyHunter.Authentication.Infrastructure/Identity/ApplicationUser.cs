using Authentication.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Authentication.Infra.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public ICollection<UserYoungPerson> UserYoungPersons { get; set; }
        public ICollection<UserFacility> UserFacilities { get; set; }
    }
}
