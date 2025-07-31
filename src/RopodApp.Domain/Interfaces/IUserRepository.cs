using System;
using System.Threading.Tasks;
using RopodApp.Domain.Entities;

namespace RopodApp.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByUsernameAsync(string username);
        Task<User?> GetByPhoneNumberAsync(string phoneNumber);
        Task<bool> IsEmailExistsAsync(string email);
        Task<bool> IsUsernameExistsAsync(string username);
        Task<User?> GetByRefreshTokenAsync(string refreshToken);
    }
}
