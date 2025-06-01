using Authentication.Domain.Entities;
using Authentication.Infra.Identity;

namespace Authentication.Infra.Services
{
    public interface IAccessService
    {
        Task<List<Facility>> GetAccessibleFacilities(ApplicationUser user);
        Task<List<YoungPerson>> GetAccessibleYoungPeople(ApplicationUser user);
    }
}
