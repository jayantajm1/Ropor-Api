using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RopodApp.Domain.Common;
using RopodApp.Domain.Enums;

namespace RopodApp.Domain.Entities
{
    public class Message : AuditableEntity
    {
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }

        [MaxLength(Constants.MAX_MESSAGE_LENGTH)]
        public string? Content { get; set; }

        public MessageType Type { get; set; } = MessageType.Text;
        public MessageStatus Status { get; set; } = MessageStatus.Sending;

        public Guid? ReplyToMessageId { get; set; }
        public Guid? ForwardedFromMessageId { get; set; }

        public bool IsEdited { get; set; } = false;
        public DateTime? EditedAt { get; set; }

        // Navigation properties
        public virtual Chat Chat { get; set; } = null!;
        public virtual User Sender { get; set; } = null!;
        public virtual Message? ReplyToMessage { get; set; }
        public virtual Message? ForwardedFromMessage { get; set; }
        public virtual ICollection<Message> Replies { get; set; } = new List<Message>();
        public virtual ICollection<Message> ForwardedMessages { get; set; } = new List<Message>();
        public virtual ICollection<MessageReaction> Reactions { get; set; } = new List<MessageReaction>();
        public virtual ICollection<FileAttachment> Attachments { get; set; } = new List<FileAttachment>();
    }
}
