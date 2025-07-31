using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RopodApp.Domain.Entities;

namespace RopodApp.Domain.Interfaces
{
    public interface IStoryRepository : IRepository<Story>
    {
        Task<IEnumerable<Story>> GetActiveStoriesAsync();
        Task<IEnumerable<Story>> GetUserStoriesAsync(Guid userId);
        Task<IEnumerable<Story>> GetContactsStoriesAsync(Guid userId);
        Task ExpireOldStoriesAsync();
        Task<bool> HasUserViewedStoryAsync(Guid storyId, Guid userId);
    }
}
