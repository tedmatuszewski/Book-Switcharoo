using BS.Domain.Convertors;
using BS.Domain.Types;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Queries
{
    public class SearchBooksQuery : Query<IEnumerable<BookDTO>>
    {
        private string _term;

        public override string Title => "";

        public SearchBooksQuery(string term)
        {
            this._term = term;
        }

        public override void Execute(IUnitOfWork _unit)
        {
            this.Result = _unit.bookRepository.Get().Select(b => BookConvertor.Convert(b)).Where(b => b.IsMatch(_term)).ToList();
            this.Message = "Successfully searched books";
        }
    }
}
