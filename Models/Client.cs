using System;
using System.Collections.Generic;

namespace Dairy.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateBirth { get; set; }
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime LastEnter { get; set; }
        public DateTime DateCreated { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
