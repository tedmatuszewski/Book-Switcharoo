using System;
using System.Collections.Generic;

namespace BookSwap.API.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ThreadId { get; set; }
        public string SentBy { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Thread Thread { get; set; }
    }
}