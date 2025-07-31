namespace RopodApp.Shared.Models
{
    public class ErrorResponse
    {
        public string Message { get; set; } = string.Empty;
        public List<string>? Details { get; set; }
        public string? StackTrace { get; set; }
        public int StatusCode { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
