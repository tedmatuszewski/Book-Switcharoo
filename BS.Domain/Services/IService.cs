using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Services
{
    public interface IService
    {
        ServiceResponse<BookDTO> GetBook(int id);

        ServiceResponse<List<BookDTO>> GetBook(string email);

        ServiceResponse<BookDTO> UpdateBook(int id, BookDTO book);

        ServiceResponse<BookDTO> CreateBook(BookDTO book);

        ServiceResponse<BookDTO> DeleteBook(int id);

        ServiceResponse<List<BookDTO>> SearchBooks(string term);

        ServiceResponse<List<MessageDTO>> GetMessages(int threadId);

        ServiceResponse<MessageDTO> GetMessage(int id);

        ServiceResponse<MessageDTO> CreateMessage(MessageDTO message);

        ServiceResponse<List<ThreadDTO>> GetThreads(string user);

        ServiceResponse<ThreadDTO> OpenNewThread(string From, int BookId);

        ServiceResponse<UserDTO> GetUser(int id);

        ServiceResponse<UserDTO> RegisterUser(UserDTO user);
    }
}
