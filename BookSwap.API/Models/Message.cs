using System;
using System.Collections.Generic;

namespace BookSwap.API.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public string From { get; set; }
        public int? BookId { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }
    }
}