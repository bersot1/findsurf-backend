using FindSurf.Domain.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace FindSurf.Domain.Commands.User
{
    class CreateUserCommand : Notifiable, ICommand
    {
        public CreateUserCommand() { }

        public CreateUserCommand(
            string firstName, 
            string lastName, 
            string email, 
            string idFacebook)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IdFacebook = idFacebook;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string IdFacebook { get; private set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                        .HasMinLen(FirstName, 3, "Primeiro Nome", "O campo primeiro nome não deve ter menos de 3 Caracteres")
                        .HasMinLen(LastName, 3, "Ultimo Nome", "O campo ultimo nome não deve ter menos de 3 caracteres")
                        .IsNullOrEmpty(IdFacebook, "IdFacebook", "O campo idFacebook não pode ser nullo" )
                        .IsEmail(Email, "Email", "O campo email não é email")
                        
                        );
        }
    }
}
