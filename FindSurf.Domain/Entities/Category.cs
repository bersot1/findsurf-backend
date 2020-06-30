using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Entities
{
    class Category : Entity
    {
        public Category(string name)
        {
            Name = name;
        }

        public string  Name { get; private set; }

    }
}
