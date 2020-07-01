using FindSurf.Domain.Commands;
using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Commands.User;
using FindSurf.Domain.Handlers.Contracts;
using FindSurf.Domain.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Handlers.User
{
    class SearchUserHandler : Notifiable, IHandle<SearchUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public SearchUserHandler(IUserRepository userRepository)
        {
            userRepository = _userRepository;
        }
        public ICommandResult Handle(SearchUserCommand command)
        {
            command.Validate();

            if (command.Invalid)
            {
                return new GenericCommandResult(
                    false,
                    "Alguma coisa deu errado!!",
                    command.Notifications);
            }

            var user = _userRepository.GetByIdFacebook(command.IdFacebook);

            return new GenericCommandResult(
                true,
                "Sucesso",
                user);

        }
    }
}
