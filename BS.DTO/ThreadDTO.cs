using System;
using System.Collections.Generic;
using System.Text;

namespace BS.DTO
{
    public class ThreadDTO : BaseDTO
    {
        public ThreadDTO()
        {

        }

        public ThreadDTO(string to, string from, int bookId)
        {
            this.To = to;
            this.From = from;
            this.BookId = bookId;
        }

        public string To { get; set; }

        public string From { get; set; }

        public int BookId { get; set; }

        public string Title { get; private set; }

        public string BookTitle
        {
            get
            {
                return this.Book?.Title;
            }
        }

        public string DateAddedDisplay
        {
            get
            {
                return this.DateAdded.ToString("MMM dd yyyy");
            }
        }

        public ThreadDTO SetMessageTitle(string user)
        {
            var from = this.From.ToLower().Trim();
            var to = this.To.ToLower().Trim();

            if (from == user.ToLower().Trim())
            {
                this.Title = $"To: {to}";
            }
            else
            {
                this.Title = $"From: {from}";
            }

            return this;
        }
        
        public BookDTO Book { get; set; }
    }
}
