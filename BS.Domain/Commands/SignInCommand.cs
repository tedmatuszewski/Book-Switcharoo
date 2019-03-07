using BS.Domain.Convertors;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Commands
{
    public class SignInCommand : Types.Command<UserDTO>
    {
        private LoginDTO login;

        public SignInCommand(LoginDTO _login)
        {
            this.login = _login;
        }

        public override string Title => "";

        public override void Execute(IUnitOfWork _unit)
        {
            var entity = _unit.userRepository.Get(login.Email, login.Password);
            var dto = UserConvertor.Convert(entity);

            if (dto == null)
            {
                this.Message = "Could not find user. Please make sure that you entered your email and password correctly. If you have not registered please click sign up to create an account.";
            }
            else
            {
                this.Message = "Successfully signed in";
            }

            this.Result = dto;
        }
    }
}
