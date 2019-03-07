using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Commands
{
    public class UpdateBookCommand : Types.Command<BookDTO>
    {
        private BookDTO book;

        public UpdateBookCommand(BookDTO _book)
        {
            this.book = _book;
        }

        public override string Title => "";

        public override void Execute(IUnitOfWork _unit)
        {
            var result = _unit.bookRepository.Update(book.Id, BookConvertor.Convert(book));

            _unit.Save();

            this.Message = "Successfully updated book";
            this.Result = BookConvertor.Convert(result);
        }
    }
}
