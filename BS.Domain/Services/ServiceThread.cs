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
        public ServiceResponse<List<ThreadDTO>> GetThreads(string user)
        {
            var threads = _unitOfWork.threadRepository.Get(user)
                            .Select(t => ThreadConvertor.Convert(t).SetMessageTitle(user))
                            .ToList();

            return App.SuccessResponse("Successfully returned threads.", threads);
        }

        public ServiceResponse<ThreadDTO> OpenNewThread(string From, int BookId)
        {
            var book = _unitOfWork.bookRepository.Get(BookId);
            var thread = new ThreadDTO(book.User, From, BookId);
            var message = new MessageDTO(thread.Id);

            _unitOfWork.threadRepository.Create(ThreadConvertor.Convert(thread));
            _unitOfWork.messageRepository.Create(MessageConvertor.Convert(message));
            _unitOfWork.Save();

            return App.SuccessResponse("Successfully created thread.", thread);
        }
    }
}
