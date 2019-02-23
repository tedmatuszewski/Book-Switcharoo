using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Services
{
    public partial class Service
    {
        public ServiceResponse<BookDTO> GetBook(int id)
        {
            var book = _unitOfWork.bookRepository.Get(id);

            return App.SuccessResponse("Successfully returned book.",BookConvertor.Convert(book));
        }

        public ServiceResponse<List<BookDTO>> GetBook(string email)
        {
            var books = _unitOfWork.bookRepository.Get(email).Select(b => BookConvertor.Convert(b)).ToList();

            return App.SuccessResponse("Successfully returned book.", books);
        }

        public ServiceResponse<BookDTO> UpdateBook(int id, BookDTO book)
        {
            var result = _unitOfWork.bookRepository.Update(id, BookConvertor.Convert(book));

            _unitOfWork.Save();

            return App.SuccessResponse("Successfully updated book.", BookConvertor.Convert(result));
        }

        public ServiceResponse<BookDTO> CreateBook(BookDTO book)
        {
            var result = _unitOfWork.bookRepository.Create(BookConvertor.Convert(book));

            _unitOfWork.Save();

            return App.SuccessResponse("Successfully created book.", BookConvertor.Convert(result));
        }

        public ServiceResponse<BookDTO> DeleteBook(int id)
        {
            var result = _unitOfWork.bookRepository.Delete(id);

            _unitOfWork.Save();

            return App.SuccessResponse("Successfully deleted book.", BookConvertor.Convert(result));
        }

        public ServiceResponse<List<BookDTO>> SearchBooks(string term)
        {
            var books = _unitOfWork.bookRepository.Get().Select(b => BookConvertor.Convert(b)).Where(b => b.IsMatch(term)).ToList();

            return App.SuccessResponse("Successfully searched books.", books);
        }
    }
}
