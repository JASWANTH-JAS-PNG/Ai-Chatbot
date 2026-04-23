using System;
using System.Collections.Generic;
namespace backend.Models
{
    public class AIChat
    {
        public Guid Id { get; set; }
      
        public List<AIChatMessage> Messages { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? botresponse { get; set; }
    }

    public class AIChatMessage
    {
        public string Role { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}