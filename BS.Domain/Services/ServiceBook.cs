using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Services
{
    public partial class Service
    {
        public BookDTO GetBook(int id)
        {
            var book = _bookRepository.Get(id);

            return BookConvertor.Convert(book);
        }

        public BookDTO GetBook(string email)
        {
            var book = _bookRepository.Get(email);

            return BookConvertor.Convert(book);
        }

        public BookDTO UpdateBook(int id, BookDTO book)
        {
            var result = _bookRepository.Update(id, BookConvertor.Convert(book));

            return BookConvertor.Convert(result);
        }

        public BookDTO CreateBook(BookDTO book)
        {
            var result = _bookRepository.Create(BookConvertor.Convert(book));

            return BookConvertor.Convert(result);
        }

        public BookDTO DeleteBook(int id)
        {
            var result = _bookRepository.Delete(id);

            return BookConvertor.Convert(result);
        }
    }
}
