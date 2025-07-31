using System;
using RopodApp.Domain.Common;

namespace RopodApp.Domain.Entities
{
    public class Contact : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ContactUserId { get; set; }
        public string? NickName { get; set; }
        public bool IsBlocked { get; set; } = false;
        public bool IsFavorite { get; set; } = false;

        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual User ContactUser { get; set; } = null!;
    }
}
