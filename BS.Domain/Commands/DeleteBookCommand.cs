using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Commands
{
    public class DeleteBookCommand : Types.Command<BookDTO>
    {
        private int id;

        public DeleteBookCommand(int _id)
        {
            this.id = _id;
        }

        public override string Title => "";

        public override void Execute(IUnitOfWork _unit)
        {
            var result = _unit.bookRepository.Delete(id);

            _unit.Save();

            this.Message = "Successfully deleted book";
            this.Result = BookConvertor.Convert(result);
        }
    }
}
