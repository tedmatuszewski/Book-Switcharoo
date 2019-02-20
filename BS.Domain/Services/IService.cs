using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Services
{
    public interface IService
    {
        BookDTO GetBook(int id);

        BookDTO GetBook(string email);

        BookDTO UpdateBook(int id, BookDTO book);

        BookDTO CreateBook(BookDTO book);

        BookDTO DeleteBook(int id);
    }
}
