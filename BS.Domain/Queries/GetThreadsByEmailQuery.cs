using BS.Domain.Convertors;
using BS.Domain.Types;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Queries
{
    public class GetThreadsByEmailQuery : Query<IEnumerable<ThreadDTO>>
    {
        private string _email;

        public override string Title => "";

        public GetThreadsByEmailQuery(string email)
        {
            this._email = email;
        }

        public override void Execute(IUnitOfWork _unit)
        {
            var threads = _unit.threadRepository.Get(_email)
                            .Select(t => ThreadConvertor.Convert(t).SetMessageTitle(_email))
                            .ToList();

            this.Result = threads;
            this.Message = "Successfully retrieved threads";
        }
    }
}
