using System;

namespace BS.DTO
{
    public class BookDTO : BaseDTO
    {
        public string Image { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public string User { get; set; }

        public string Condition { get; set; }

        public string Description { get; set; }

        public string University { get; set; }

        public string Class { get; set; }

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

            if (query == null)
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
