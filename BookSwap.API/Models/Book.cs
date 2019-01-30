using System;
using System.Collections.Generic;

namespace BookSwap.API.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string User { get; set; }
        public string Condition { get; set; }
        public bool IsDeleted { get; set; }
    }
}