using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Commands
{
    public class CreateBookCommand : Types.Command<BookDTO>
    {
        private BookDTO book;

        public CreateBookCommand(BookDTO _book)
        {
            this.book = _book;
        }

        public override string Title => "";

        public override void Execute(IUnitOfWork _unit)
        {
            var result = _unit.bookRepository.Create(BookConvertor.Convert(book));

            _unit.Save();

            this.Message = "";
            this.Result = BookConvertor.Convert(result);
        }
    }
}
