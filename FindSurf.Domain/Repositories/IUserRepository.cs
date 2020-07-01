using FindSurf.Domain.Entities;
using System;

namespace FindSurf.Domain.Repositories
{
    public interface IUserRepository
    {
        void Insert(UserEntity user);
        UserEntity GetByIdFacebook(string idFacebook);

        UserEntity GetById(Guid id);

    }
}


