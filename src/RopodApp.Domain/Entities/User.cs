using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RopodApp.Domain.Common;
using RopodApp.Domain.Enums;

namespace RopodApp.Domain.Entities
{
    public class User : AuditableEntity
    {
        [Required]
        [MaxLength(Constants.MAX_USERNAME_LENGTH)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [MaxLength(Constants.MAX_DISPLAY_NAME_LENGTH)]
        public string DisplayName { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public string? ProfilePictureUrl { get; set; }

        [MaxLength(Constants.MAX_STATUS_LENGTH)]
        public string? About { get; set; }

        public UserStatus Status { get; set; } = UserStatus.Offline;

        public DateTime? LastSeenAt { get; set; }

        public bool IsEmailVerified { get; set; } = false;

        public bool IsPhoneVerified { get; set; } = false;

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiryTime { get; set; }

        // Navigation properties
        public virtual ICollection<ChatMember> ChatMemberships { get; set; } = new List<ChatMember>();
        public virtual ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public virtual ICollection<Contact> ContactsOf { get; set; } = new List<Contact>();
        public virtual ICollection<Story> Stories { get; set; } = new List<Story>();
        public virtual ICollection<MessageReaction> MessageReactions { get; set; } = new List<MessageReaction>();
    }
}
