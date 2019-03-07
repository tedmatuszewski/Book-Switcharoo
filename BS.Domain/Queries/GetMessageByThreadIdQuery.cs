using BS.Domain.Convertors;
using BS.Domain.Types;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Queries
{
    public class GetMessageByThreadIdQuery : Query<List<MessageDTO>>
    {
        private int _threadId;

        public override string Title => "";

        public GetMessageByThreadIdQuery(int threadId)
        {
            this._threadId = threadId;
        }

        public override void Execute(IUnitOfWork _unit)
        {
            this.Result = _unit.messageRepository.GetByThread(_threadId).Select(m => MessageConvertor.Convert(m)).ToList();
            this.Message = "Successfully retrieved messages.";
        }
    }
}
