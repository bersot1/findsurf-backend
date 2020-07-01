using FindSurf.Domain.Commands;
using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Commands.User;
using FindSurf.Domain.Handlers.Contracts;
using FindSurf.Domain.Repositories;
using Flunt.Notifications;
using FindSurf.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Tracing;

namespace FindSurf.Domain.Handlers.User
{
    class CreateUserHandler : Notifiable, IHandle<CreateUserCommand>
    {

        private readonly IUserRepository _userRepository;

        public CreateUserHandler(IUserRepository userRepository)
        {
            userRepository = _userRepository;
        }

        public ICommandResult Handle(CreateUserCommand command)
        {
            command.Validate();
            if (command.Invalid)
            {
                return new GenericCommandResult(
                    false,
                    "Alguma coisa deu errada!!",
                    command.Notifications);
            }

            var newUser = new UserEntity(command.FirstName, command.LastName, command.Email, command.IdFacebook);

            _userRepository.Insert(newUser);

            return new GenericCommandResult(
                true,
                "Sucesso",
                newUser
                ) ;
        }
    }
}
