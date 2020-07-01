using FindSurf.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Commands.User
{
    class SearchUserCommand : Notifiable, ICommand
    {
        public SearchUserCommand() { }
        public SearchUserCommand(string idFacebook)
        {
            IdFacebook = idFacebook;
        }

        public string IdFacebook { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNull(IdFacebook, "IdFacebbok","O campo IdFacebook não pode ser nulo")
                );;
        }
    }
}
