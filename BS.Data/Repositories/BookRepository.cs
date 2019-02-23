using BS.Domain.Entities;
using BS.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        readonly BookSwapContext _context;

        public BookRepository(BookSwapContext context)
        {
            _context = context;
        }

        public Book Create(Book book)
        {
            var result = _context.Book.Add(book);

            result.State = EntityState.Added;

            return result.Entity;
        }

        public Book Delete(int id)
        {
            var result = _context.Book.Find(id);

            result.IsDeleted = true;
            _context.Entry(result).State = EntityState.Modified;

            return result;
        }

        public Book Get(int id)
        {
            var result = _context.Book.Find(id);

            return result;
        }

        public IEnumerable<Book> Get(string email)
        {
            var result = _context.Book.Where(b => b.IsDeleted == false && b.User.ToLower().Trim() == email.ToLower().Trim()).AsEnumerable();

            return result;
        }

        public Book Update(int id, Book book)
        {
            var entity = _context.Attach(book);

            entity.State = EntityState.Modified;

            return entity.Entity;
        }

        public IEnumerable<Book> Get()
        {
            var result = _context.Book.Where(b => b.IsDeleted == false).AsEnumerable();

            return result;
        }
    }
}
