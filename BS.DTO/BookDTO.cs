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
    }
}
