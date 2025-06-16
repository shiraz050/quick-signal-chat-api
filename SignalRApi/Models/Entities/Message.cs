// File: Models/Entities/Message.cs
using System;

namespace SignalRApi.Models.Entities
{
    public class Message
    {
        public int Id { get; set; }

        public string SenderUsername { get; set; } = null!;

        public string ReceiverUsername { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
