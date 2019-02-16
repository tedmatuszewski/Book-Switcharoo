using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookSwap.API.Models
{
    public partial class Thread
    {
        [NotMapped]
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

        public Thread SetMessageTitle(string user)
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
    }
}
