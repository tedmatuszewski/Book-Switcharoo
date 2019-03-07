using BS.Domain.Convertors;
using BS.Domain.Types;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Queries
{
    public class GetMessageByIdQuery : Query<MessageDTO>
    {
        private int _id;

        public override string Title => "";

        public GetMessageByIdQuery(int id)
        {
            this._id = id;
        }

        public override void Execute(IUnitOfWork _unit)
        {
            var entity = _unit.messageRepository.Get(_id);

            this.Result = MessageConvertor.Convert(entity);
            this.Message = "Successfully retrieved messages";
        }
    }
}
