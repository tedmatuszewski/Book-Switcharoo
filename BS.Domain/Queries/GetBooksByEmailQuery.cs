using BS.Domain.Convertors;
using BS.Domain.Types;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Queries
{
    public class GetBooksByEmailQuery : Query<IEnumerable<BookDTO>>
    {
        private string _email;

        public override string Title => "";

        public GetBooksByEmailQuery(string email)
        {
            this._email = email;
        }

        public override void Execute(IUnitOfWork _unit)
        {
            if (_email != null)
            {
                this.Result = _unit.bookRepository.Get(this._email).Select(b => BookConvertor.Convert(b)).ToList();
            }
            else
            {
                this.Result = _unit.bookRepository.Get().OrderByDescending(b => b.DateAdded).Take(15).Select(b => BookConvertor.Convert(b)).ToList();
            }
        }
    }
}
