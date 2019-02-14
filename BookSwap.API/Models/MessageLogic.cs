using System;
using System.Collections.Generic;

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
    }
}