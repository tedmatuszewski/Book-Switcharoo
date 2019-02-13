using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSwap.API.Models
{
    public partial class Thread
    {
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
    }
}
