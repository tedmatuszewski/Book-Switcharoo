using BS.Domain.Entities;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Convertors
{
    public static class BookConvertor
    {
        public static BookDTO Convert(Book data)
        {
            return new BookDTO()
            {
                Image = data.Image,
                Title = data.Title,
                Isbn = data.Isbn,
                User = data.User,
                Condition = data.Condition,
                Description = data.Description,
                University = data.University,
                Class = data.Class,
                Id = data.Id,
                DateAdded = data.DateAdded,
                IsDeleted = data.IsDeleted
            };
        }

        public static Book Convert(BookDTO dto)
        {
            return new Book()
            {
                Id = dto.Id,
                Image = dto.Image,
                Title = dto.Title,
                Isbn = dto.Isbn,
                User = dto.User,
                Condition = dto.Condition,
                Description = dto.Description,
                University = dto.University,
                Class = dto.Class,
                DateAdded = dto.DateAdded,
                IsDeleted = dto.IsDeleted
            };
        }
    }
}
