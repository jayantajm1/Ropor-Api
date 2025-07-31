using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RopodApp.Domain.Common;
using RopodApp.Domain.Enums;

namespace RopodApp.Domain.Entities
{
    public class Chat : AuditableEntity
    {
        [MaxLength(Constants.MAX_CHAT_NAME_LENGTH)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public ChatType Type { get; set; } = ChatType.Private;

        public string? ImageUrl { get; set; }

        public Guid? CreatedByUserId { get; set; }

        public DateTime? LastMessageAt { get; set; }

        // Navigation properties
        public virtual User? CreatedByUser { get; set; }
        public virtual ICollection<ChatMember> Members { get; set; } = new List<ChatMember>();
        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
