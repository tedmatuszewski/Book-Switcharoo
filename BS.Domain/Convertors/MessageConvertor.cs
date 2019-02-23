using BS.Domain.Entities;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Convertors
{
    public static class MessageConvertor
    {
        public static Message Convert(MessageDTO dto)
        {
            return new Message()
            {
                Id = dto.Id,
                Text = dto.Text,
                ThreadId = dto.ThreadId,
                SentBy = dto.SentBy,
                DateAdded = dto.DateAdded,
                IsDeleted = dto.IsDeleted,
                Thread = new Thread()
                {
                    Id = dto.Thread.Id,
                    To = dto.Thread.To,
                    From = dto.Thread.From,
                    BookId = dto.Thread.BookId,
                    DateAdded = dto.Thread.DateAdded,
                    IsDeleted = dto.Thread.IsDeleted
                }
            };
        }

        public static MessageDTO Convert(Message entity)
        {
            return new MessageDTO()
            {
                Text = entity.Text,
                ThreadId = entity.ThreadId,
                SentBy = entity.SentBy,
                Thread = new ThreadDTO()
                {
                    To = entity.Thread.To,
                    From = entity.Thread.From,
                    BookId = entity.Thread.BookId,
                    Id = entity.Thread.Id,
                    DateAdded = entity.Thread.DateAdded,
                    IsDeleted = entity.Thread.IsDeleted
                },
                Id = entity.Id,
                DateAdded = entity.DateAdded,
                IsDeleted = entity.IsDeleted
            };
        }
    }
}
