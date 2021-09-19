using System;

namespace API.Entitites
{
    public record User
    {
        public int ID { get; init; }
        public string Username { get; init; }
        public string Password { get; init; }
        public string Email { get; init; }
        public string CoverLetter { get; init; }
        public string Avartar { get; init; }
        public DateTime CreatedAt { get; init; }
    }
}