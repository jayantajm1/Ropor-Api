using System;
using RopodApp.Domain.Common;

namespace RopodApp.Domain.Entities
{
    public class ChatMember : BaseEntity
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }
        public bool IsAdmin { get; set; } = false;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastReadAt { get; set; }
        public bool IsMuted { get; set; } = false;
        public DateTime? MutedUntil { get; set; }

        // Navigation properties
        public virtual Chat Chat { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
