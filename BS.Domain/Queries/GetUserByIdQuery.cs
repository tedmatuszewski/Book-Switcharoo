using BS.Domain.Convertors;
using BS.Domain.Types;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BS.Domain.Queries
{
    public class GetUserByIdQuery : Query<UserDTO>
    {
        private int _id;

        public override string Title => "";

        public GetUserByIdQuery(int id)
        {
            this._id = id;
        }

        public override void Execute(IUnitOfWork _unit)
        {
            var entity = _unit.userRepository.Get(_id);

            this.Result = UserConvertor.Convert(entity);
            this.Message = "Successfully retrieved User";
        }
    }
}
