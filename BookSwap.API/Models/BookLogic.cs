using System;
using System.Collections.Generic;

namespace BookSwap.API.Models
{
    public partial class Book
    {
        public string UniversityDisplay
        {
            get
            {
                return this.University + "/" + this.Class;
            }
        }

        public string DaysAgo
        {
            get
            {
                return $"posted {(DateTime.Now - this.DateAdded).Days} days ago";
            }
        }

        public string DateAddedDisplay
        {
            get
            {
                return $"{this.DateAdded.ToShortDateString()} {this.DateAdded.ToShortTimeString()}";
            }
        }

        public bool IsMatch(string query)
        {
            query = query?.ToLower()?.Trim();

            if(query == null)
            {
                return false;
            }

            if (this.Title.ToLower().Trim().Contains(query))
            {
                return true;
            }

            if (this.University.ToLower().Trim().Contains(query))
            {
                return true;
            }

            if (this.Class.ToLower().Trim().Contains(query))
            {
                return true;
            }

            return false;
        }
    }
}