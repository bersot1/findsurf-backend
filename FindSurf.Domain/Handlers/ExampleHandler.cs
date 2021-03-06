using Flunt.Notifications;
using FindSurf.Domain.Commands;
using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Entities;
using FindSurf.Domain.Handlers.Contracts;
using FindSurf.Domain.Repositories;
namespace FindSurf.Domain.Handlers
{
    public class ExampleHandler : Notifiable, IHandle<ExampleCreateSomethingCommand>
    {
        private readonly IExampleRepository _repository;
        public ExampleHandler(IExampleRepository repository)
        {
            repository = _repository;
        }
        public ICommandResult Handle(ExampleCreateSomethingCommand command)
        {
            command.Validate();
            if (command.Invalid)
            {
                return new GenericCommandResult(
                    false,
                    "Ops, parece que sua tarefa está errada",
                    command.Notifications);
            }
            var todo = new ExampleEntity(command.Title, command.User, command.Date);
            _repository.Create(todo);
            return new GenericCommandResult(
                true,
                "Sucesso",
                todo);
        }
    }
}
