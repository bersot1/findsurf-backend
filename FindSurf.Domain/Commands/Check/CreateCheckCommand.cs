using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Enumerable;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Commands.Check
{
    class CreateCheckCommand : Notifiable, ICommand
    {
        public CreateCheckCommand() { }
        public CreateCheckCommand(
            string urlImage, 
            string pico, 
            PicoQualityEnum quality, 
            string stateAddress, 
            string cityAddress, 
            DateTime dateCheck, 
            Guid idCriador)
        {
            UrlImage = urlImage;
            Pico = pico;
            Quality = quality;
            StateAddress = stateAddress;
            CityAddress = cityAddress;
            DateCheck = dateCheck;
            IdCriador = idCriador;
        }

        public string UrlImage { get; private set; }

        public string Pico { get; private set; }

        public PicoQualityEnum Quality { get; private set; }

        public string StateAddress { get; private set; }

        public string CityAddress { get; private set; }

        public DateTime DateCheck { get; private set; }

        public Guid IdCriador { get; private set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNull(UrlImage, "Image", "O campo imagem não pode ser nulo")
                    .HasMinLen(Pico, 2, "Pico","O campo Pico não pode ter menos de 2 letras ")
                    .IsNull(Quality, "Quality", "O campo Quality não pode ser nulo")
                    .IsNull(StateAddress, "StateAddress", "O campo StateAddress não pode ser nulo")
                    .IsNull(CityAddress, "CityAddress", "O campo CityAddress não pode ser nulo")
                    .IsNull(DateCheck, "DateCheck", "O campo DateCheck não pode ser nulo")
                    .IsNull(IdCriador, "IdCriador", "O campo IdCriador não pode ser nulo")

                );
        }
    }
}
