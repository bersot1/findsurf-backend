using System;
using Flunt.Notifications;
using Flunt.Validations;
using FindSurf.Domain.Commands.Contracts;
namespace FindSurf.Domain.Commands
{
    public class ExampleCreateSomethingCommand : Notifiable, ICommand
    {
        public ExampleCreateSomethingCommand() { }
        public ExampleCreateSomethingCommand(string title, string user, DateTime date)
        {
            Title = title; 
            User = user; 
            Date = date;
        }
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                        .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor esta tarefa!")
                        .HasMinLen(User, 6, "User", "Usuário inválido!"));
        }
    }
}
