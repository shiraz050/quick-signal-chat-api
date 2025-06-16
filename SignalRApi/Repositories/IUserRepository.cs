// File: Repositories/IUserRepository.cs
using SignalRApi.Models.Entities;

namespace SignalRApi.Repositories
{
    public interface IUserRepository
    {
        User? GetByUsername(string username);
    }
}
