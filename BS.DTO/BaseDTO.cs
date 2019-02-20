using System;
using System.Collections.Generic;
using System.Text;

namespace BS.DTO
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsDeleted { get; set; }
    }
}
