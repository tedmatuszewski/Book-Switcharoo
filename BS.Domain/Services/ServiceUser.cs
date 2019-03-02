using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Services
{
    public partial class Service
    {
        public ServiceResponse<UserDTO> GetUser(int id)
        {
            var entity = this._unitOfWork.userRepository.Get(id);
            var dto = UserConvertor.Convert(entity);

            return App.SuccessResponse("Successfully returned book.", dto);
        }

        public ServiceResponse<UserDTO> RegisterUser(UserDTO user)
        {
            var entity = this._unitOfWork.userRepository.Create(UserConvertor.Convert(user));

            this._unitOfWork.Save();

            return App.SuccessResponse("Successfully registered user.", UserConvertor.Convert(entity));
        }
    }
}
