using FindSurf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Repositories
{
    public interface IPostRepository
    {
        void Insert(PostEntity post);

        PostEntity GetById(Guid id);
    }
}
