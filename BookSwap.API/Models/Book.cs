using System;
using System.Collections.Generic;

namespace BookSwap.API.Models
{
    public partial class Book
    {
        public Book()
        {
            Thread = new HashSet<Thread>();
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string User { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string University { get; set; }
        public string Class { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Thread> Thread { get; set; }
    }
}