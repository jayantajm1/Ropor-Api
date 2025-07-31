using System;
using RopodApp.Domain.Common;

namespace RopodApp.Domain.Entities
{
    public class MessageReaction : BaseEntity
    {
        public Guid MessageId { get; set; }
        public Guid UserId { get; set; }
        public string Emoji { get; set; } = string.Empty;

        // Navigation properties
        public virtual Message Message { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
