using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Commands
{
    public class CreateMessageCommand : Types.Command<MessageDTO>
    {
        private MessageDTO message;

        public CreateMessageCommand(MessageDTO _message)
        {
            this.message = _message;
        }

        public override string Title => "";

        public override void Execute(IUnitOfWork _unit)
        {
            var entity = _unit.messageRepository.Create(MessageConvertor.Convert(message));

            _unit.Save();

            var entity2 = _unit.messageRepository.Get(entity.Id);

            this.Result = MessageConvertor.Convert(entity2).SetTo();
            this.Message = "Successfully created message";
        }
    }
}
