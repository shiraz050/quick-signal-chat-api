// File: Repositories/IUserRepository.cs
using SignalRApi.Models.Entities;

namespace SignalRApi.Repositories
{
    public interface IUserRepository
    {
        User? GetByUsername(string username);
        Task<User?> GetByIdAsync(int id);
        Task AddUserAsync(User user);
        Task SaveChangesAsync();
    }
}
