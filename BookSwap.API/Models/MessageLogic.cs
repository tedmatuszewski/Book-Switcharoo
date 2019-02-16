using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSwap.API.Models
{
    public partial class Message
    {
        public string DateAddedDisplay
        {
            get
            {
                return this.DateAdded.ToString("h:mm tt | MMM dd yyyy");
            }
        }

        [NotMapped]
        public string To { get; private set; }

        internal Message SetTo()
        {
            if (this.Thread == null)
            {
                return this;
            }

            if (this.SentBy == "From")
            {
                this.To = this.Thread.From;
            }

            if (this.SentBy == "To")
            {
                this.To = this.Thread.To;
            }

            return this;
        }
    }
}