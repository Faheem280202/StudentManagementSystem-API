using SchoolManagementSystem.Domain.Entities;

namespace SchoolManagementSystem.Application.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAllRolesAsync();
    }
}
