﻿namespace SignalRApi.Models.DTOs
{
    public class AuthResponse
    {
        public string Token { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
