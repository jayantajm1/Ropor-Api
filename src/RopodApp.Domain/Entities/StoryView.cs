using System;
using RopodApp.Domain.Common;

namespace RopodApp.Domain.Entities
{
    public class StoryView : BaseEntity
    {
        public Guid StoryId { get; set; }
        public Guid ViewerId { get; set; }
        public DateTime ViewedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Story Story { get; set; } = null!;
        public virtual User Viewer { get; set; } = null!;
    }
}
