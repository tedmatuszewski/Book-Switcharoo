using System;
using System.Collections.Generic;
using System.Text;

namespace BS.DTO
{
    public class MessageDTO : BaseDTO
    {
        public MessageDTO()
        {

        }

        public MessageDTO(int threadId)
        {
            this.Text = "Hello, I am interested in your book.";
            this.ThreadId = threadId;
            this.SentBy = "From";
        }

        public string Text { get; set; }

        public int ThreadId { get; set; }

        public string SentBy { get; set; }

        public string DateAddedDisplay
        {
            get
            {
                return this.DateAdded.ToString("h:mm tt | MMM dd yyyy");
            }
        }

        public string To { get; private set; }

        public MessageDTO SetTo()
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

        public ThreadDTO Thread { get; set; }
    }
}
