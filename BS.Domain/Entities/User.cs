using System;
using System.Collections.Generic;

namespace BS.Domain.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }
    }
}