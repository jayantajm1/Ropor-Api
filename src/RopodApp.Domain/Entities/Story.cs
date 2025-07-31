using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RopodApp.Domain.Common;

namespace RopodApp.Domain.Entities
{
    public class Story : AuditableEntity
    {
        public Guid UserId { get; set; }

        [MaxLength(500)]
        public string? Caption { get; set; }

        public string MediaUrl { get; set; } = string.Empty;
        public string? ThumbnailUrl { get; set; }
        public string MediaType { get; set; } = string.Empty; // image, video

        public DateTime ExpiresAt { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual ICollection<StoryView> Views { get; set; } = new List<StoryView>();
    }
}
