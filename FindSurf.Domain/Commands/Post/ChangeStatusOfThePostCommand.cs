using FindSurf.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Commands.Post
{
    class ChangeStatusOfThePostCommand : Notifiable, ICommand
    {

        public ChangeStatusOfThePostCommand() { }
        public ChangeStatusOfThePostCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public void Validate()
        {
            AddNotifications(
                    new Contract() 
                        .Requires()
                        .IsNull(Id, "Id", "O campo ID não pode ser null")
                );
        }
    }
}
