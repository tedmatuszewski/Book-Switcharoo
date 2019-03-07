using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Commands
{
    public class CreateThreadCommand : Types.Command<ThreadDTO>
    {
        private string _from;
        private int _bookId;

        public CreateThreadCommand(string from, int bookId)
        {
            this._from = from;
            this._bookId = bookId;
        }

        public override string Title => "";

        public override void Execute(IUnitOfWork _unit)
        {
            var book = _unit.bookRepository.Get(_bookId);
            var thread = new ThreadDTO(book.User, _from, _bookId);
            var message = new MessageDTO(thread.Id);

            _unit.threadRepository.Create(ThreadConvertor.Convert(thread));
            _unit.messageRepository.Create(MessageConvertor.Convert(message));
            _unit.Save();

            this.Message = "Successfully created thread";
            this.Result = thread;
        }
    }
}
