﻿namespace MusicAgent.Blazor.Auth
{
    public class UserInfo
    {
        public required string UserId { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Sub { get; set; }

    }
}
