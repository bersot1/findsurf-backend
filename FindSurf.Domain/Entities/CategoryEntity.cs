using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Entities
{
    public class CategoryEntity : Entity
    {
        public CategoryEntity(string name)
        {
            Name = name;
        }

        public string  Name { get; private set; }

    }
}
