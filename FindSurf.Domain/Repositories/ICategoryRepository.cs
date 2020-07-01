using FindSurf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Repositories
{
    public interface ICategoryRepository
    {
        CategoryEntity GetById(Guid id); 
    }
}
