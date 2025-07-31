namespace RopodApp.Domain.Common
{
    public static class Constants
    {
        public const int MAX_MESSAGE_LENGTH = 4096;
        public const int MAX_USERNAME_LENGTH = 50;
        public const int MAX_DISPLAY_NAME_LENGTH = 100;
        public const int MAX_STATUS_LENGTH = 139;
        public const int MAX_CHAT_NAME_LENGTH = 100;
        public const int MAX_FILE_SIZE_BYTES = 100 * 1024 * 1024; // 100MB
        public const int STORY_EXPIRY_HOURS = 24;

        public static class Roles
        {
            public const string Admin = "Admin";
            public const string User = "User";
            public const string Moderator = "Moderator";
        }

        public static class Claims
        {
            public const string UserId = "UserId";
            public const string Email = "Email";
            public const string Role = "Role";
        }
    }
}
