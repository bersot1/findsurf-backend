using FindSurf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Repositories
{
    public interface ICheckRepository
    {
        void Insert(CheckEntity check);
    }
}
