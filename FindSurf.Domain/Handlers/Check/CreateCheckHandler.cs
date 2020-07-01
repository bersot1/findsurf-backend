using FindSurf.Domain.Commands;
using FindSurf.Domain.Commands.Check;
using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Entities;
using FindSurf.Domain.Handlers.Contracts;
using FindSurf.Domain.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Handlers.Check
{
    class CreateCheckHandler : Notifiable, IHandle<CreateCheckCommand>
    {

        private readonly ICheckRepository _checkRepository;
        private readonly IUserRepository _userRepository;

        public CreateCheckHandler(IUserRepository userRepository, ICheckRepository checkRepository)
        {
            userRepository = _userRepository;
            checkRepository = _checkRepository;
        }


        public ICommandResult Handle(CreateCheckCommand command)
        {
            command.Validate();
            if (command.Invalid)
            {
                return new GenericCommandResult(false, "Alguma coisa de errado", command.Notifications);
            }

            var criador = _userRepository.GetById(command.IdCriador);

            var newCheck = new CheckEntity(
                command.UrlImage, 
                command.Pico, 
                command.Quality, 
                command.StateAddress, 
                command.CityAddress, 
                command.DateCheck, 
                command.IdCriador, 
                criador);

            _checkRepository.Insert(newCheck);

            return new GenericCommandResult(true, "sucesso", newCheck);


        }
    }
}
