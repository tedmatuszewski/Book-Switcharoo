using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Commands
{
    public class RegisterUserCommand : Types.Command<UserDTO>
    {
        private UserDTO user;

        public RegisterUserCommand(UserDTO _user)
        {
            this.user = _user;
        }

        public override string Title => "";

        public override void Execute(IUnitOfWork _unit)
        {
            var result = _unit.userRepository.Create(UserConvertor.Convert(user));

            _unit.Save();

            this.Message = "";
            this.Result = UserConvertor.Convert(result);
        }
    }
}
