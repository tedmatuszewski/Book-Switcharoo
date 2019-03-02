using BS.Domain.Entities;
using BS.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BS.Domain.Convertors
{
    public static class UserConvertor
    {
        public static User Convert(UserDTO dto)
        {
            if(dto == null)
            {
                return null;
            }

            return new User()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Password = dto.Password,
                Email = dto.Email,
                DateAdded = dto.DateAdded,
                IsDeleted = dto.IsDeleted
            };
        }

        public static UserDTO Convert(User entity)
        {
            if(entity == null)
            {
                return null;
            }

            return new UserDTO()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Password = entity.Password,
                Email = entity.Email,
                Id = entity.Id,
                DateAdded = entity.DateAdded,
                IsDeleted = entity.IsDeleted
            };
        }
    }
}
