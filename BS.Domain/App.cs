using BS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain
{
    public class App
    {
        public static ServiceResponse<T> SuccessResponse<T>(string message, T data)
        {
            var response = new ServiceResponse<T>();

            response.data = data;
            response.message = message;
            response.success = true;

            return response;
        }

        public static ServiceResponse<T> ErrorResponse<T>(string message = "You do not have permission to perform this action.")
        {
            var response = new ServiceResponse<T>();

            response.data = default(T);
            response.message = message;
            response.success = false;

            return response;
        }
    }

    public class ServiceResponse<T>
    {
        public ServiceResponse()
        {
            data = default(T);
            success = false;
        }

        public bool success { get; set; }

        public string message { get; set; }

        public string content { get; set; }

        public T data { get; set; }
    }

    public interface IUnitOfWork : IDisposable
    {
        IMessageRepository messageRepository { get; }

        IThreadRepository threadRepository { get; }

        IBookRepository bookRepository { get; }

        IUserRepository userRepository { get; }

        void Save();

        void SaveAsync();
    }
}
