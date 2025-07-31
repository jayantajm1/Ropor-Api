using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RopodApp.Domain.Entities;

namespace RopodApp.Domain.Interfaces
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task<IEnumerable<Message>> GetChatMessagesAsync(Guid chatId, int page = 1, int pageSize = 50);
        Task<IEnumerable<Message>> GetUnreadMessagesAsync(Guid userId, Guid chatId);
        Task<int> GetUnreadMessageCountAsync(Guid userId, Guid chatId);
        Task<Message?> GetLastChatMessageAsync(Guid chatId);
        Task MarkMessagesAsReadAsync(Guid userId, Guid chatId);
        Task<IEnumerable<Message>> SearchMessagesAsync(string searchTerm, Guid? chatId = null, Guid? userId = null);
    }
}
