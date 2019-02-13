using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSwap.API.Models
{
    public class MessageList
    {
        public DateTime DateAdded { get; set; }

        public string User { get; set; }

        public string Text { get; set; }

        public string From { get; set; }

        public string Title { get; set; }

        public int BookId { get; set; }


        public string DateAddedDisplay
        {
            get
            {
                return this.DateAdded.ToString("MMM dd yyyy");
            }
        }
    }
}
