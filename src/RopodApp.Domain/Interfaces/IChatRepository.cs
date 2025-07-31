using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RopodApp.Domain.Entities;
using RopodApp.Domain.Enums;

namespace RopodApp.Domain.Interfaces
{
    public interface IChatRepository : IRepository<Chat>
    {
        Task<IEnumerable<Chat>> GetUserChatsAsync(Guid userId);
        Task<Chat?> GetPrivateChatAsync(Guid userId1, Guid userId2);
        Task<IEnumerable<Chat>> GetChatsByTypeAsync(ChatType chatType);
        Task<bool> IsUserMemberOfChatAsync(Guid chatId, Guid userId);
        Task<IEnumerable<ChatMember>> GetChatMembersAsync(Guid chatId);
    }
}
