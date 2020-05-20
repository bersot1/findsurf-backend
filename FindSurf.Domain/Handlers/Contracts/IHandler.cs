using FindSurf.Domain.Commands.Contracts;namespace FindSurf.Domain.Handlers.Contracts{public interface IHandle--T-- where T : ICommand{ICommandResult Handle(T command);}} 
