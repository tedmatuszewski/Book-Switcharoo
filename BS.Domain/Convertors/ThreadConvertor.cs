using BS.Domain.Entities;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Convertors
{
    public static class ThreadConvertor
    {
        public static ThreadDTO Convert(Thread entity)
        {
            return new ThreadDTO()
            {
                To = entity.To,
                From = entity.From,
                BookId = entity.BookId,
                Id = entity.Id,
                DateAdded = entity.DateAdded,
                IsDeleted = entity.IsDeleted,
                Book = BookConvertor.Convert(entity.Book)
            };
        }

        public static Thread Convert(ThreadDTO dto)
        {
            return new Thread()
            {
                Id = dto.Id,
                To = dto.To,
                From = dto.From,
                BookId = dto.BookId,
                DateAdded = dto.DateAdded,
                IsDeleted = dto.IsDeleted
            };
        }
    }
}
