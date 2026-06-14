using SchoolManagementSystem.Application.DTOs.Auth;

namespace SchoolManagementSystem.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponse?> LoginAsync(LoginRequest request);
    }
}