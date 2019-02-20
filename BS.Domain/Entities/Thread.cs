using System;
using System.Collections.Generic;

namespace BS.Domain.Entities
{
    public partial class Thread
    {
        public Thread()
        {
            Message = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int BookId { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Book Book { get; set; }
        public virtual ICollection<Message> Message { get; set; }
    }
}