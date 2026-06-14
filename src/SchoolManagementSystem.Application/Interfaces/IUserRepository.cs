using SchoolManagementSystem.Domain.Entities;
using SchoolManagementSystem.Domain.Entities.Response;

namespace SchoolManagementSystem.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserResponse>> GetAllUsersAsync();
        Task<UserResponse?> GetByIdAsync(int id);
        Task<int> CreateUserAsync(User user);
    }
}
