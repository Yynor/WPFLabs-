﻿namespace Entities
{
    public class UserModel
    {
        public required int Id { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Name { get; set; }
    }
}
