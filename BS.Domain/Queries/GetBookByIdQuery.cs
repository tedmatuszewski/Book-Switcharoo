using BS.Domain.Convertors;
using BS.Domain.Types;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Queries
{
    public class GetBookByIdQuery : Query<BookDTO>
    {
        private int _id;

        public override string Title => "";

        public GetBookByIdQuery(int id)
        {
            this._id = id;
        }

        public override void Execute(IUnitOfWork _unit)
        {
            var entity = _unit.bookRepository.Get(_id);

            this.Result = BookConvertor.Convert(entity);
            this.Message = "Successfully returned book";
        }
    }
}
