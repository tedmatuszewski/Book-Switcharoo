using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Services
{
    public partial class Service
    {
        public ServiceResponse<List<MessageDTO>> GetMessages(int threadId)
        {
            var messages = _unitOfWork.messageRepository.GetByThread(threadId).Select(m => MessageConvertor.Convert(m)).ToList();

            return App.SuccessResponse("Successfully retrieved messages.", messages);
        }

        public ServiceResponse<MessageDTO> GetMessage(int id)
        {
            var entity = _unitOfWork.messageRepository.Get(id);
            var dto = MessageConvertor.Convert(entity);

            return App.SuccessResponse("Successfully retrieved message.", dto);
        }

        public ServiceResponse<MessageDTO> CreateMessage(MessageDTO message)
        {
            var entity = _unitOfWork.messageRepository.Create(MessageConvertor.Convert(message));

            _unitOfWork.Save();

            var entity2 = _unitOfWork.messageRepository.Get(entity.Id);
            var dto = MessageConvertor.Convert(entity2).SetTo();

            return App.SuccessResponse("Successfully created message.", dto);
        }
    }
}
