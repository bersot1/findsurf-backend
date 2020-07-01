using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Entities
{
    public class UserEntity : Entity
    {
        public UserEntity(string firstName, string lastName, string email, string idFacebook)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IdFacebook = idFacebook;
        }

        public string FirstName { get;  private set; }

        public string LastName { get;  private set; }

        public string Email { get;  private set; }

        public string IdFacebook { get;  private set; }

    }
}
