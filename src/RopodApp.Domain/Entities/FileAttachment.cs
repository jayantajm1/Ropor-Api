using System;
using RopodApp.Domain.Common;
using RopodApp.Domain.Enums;

namespace RopodApp.Domain.Entities
{
    public class FileAttachment : BaseEntity
    {
        public Guid MessageId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public string? ThumbnailUrl { get; set; }
        public FileType FileType { get; set; }
        public long FileSize { get; set; }
        public string ContentType { get; set; } = string.Empty;

        // Navigation properties
        public virtual Message Message { get; set; } = null!;
    }
}
