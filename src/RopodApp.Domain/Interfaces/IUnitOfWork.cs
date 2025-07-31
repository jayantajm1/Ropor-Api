using System;
using System.Threading.Tasks;
using RopodApp.Domain.Common;

namespace RopodApp.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IChatRepository Chats { get; }
        IMessageRepository Messages { get; }
        IStoryRepository Stories { get; }
        IRepository<T> Repository<T>() where T : BaseEntity;

        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
