using BS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Repositories
{
    public interface IBookRepository
    {
        Book Get(int id);

        IEnumerable<Book> Get(string email);

        Book Update(int id, Book book);

        Book Create(Book book);

        Book Delete(int id);

        IEnumerable<Book> Get();
    }
}
