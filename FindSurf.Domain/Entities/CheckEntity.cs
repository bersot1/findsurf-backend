using FindSurf.Domain.Enumerable;
using System;

namespace FindSurf.Domain.Entities
{
    public class CheckEntity : Entity
    {
        public CheckEntity(
            string urlImage, 
            string pico, 
            PicoQualityEnum quality, 
            string stateAddress, 
            string cityAddress, 
            DateTime dateCheck, 
            Guid idCriador, 
            UserEntity criador)
        {
            UrlImage = urlImage;
            Pico = pico;
            Quality = quality;
            StateAddress = stateAddress;
            CityAddress = cityAddress;
            DateCheck = dateCheck;
            IdCriador = idCriador;
            Criador = criador;
        }

        public string UrlImage { get; private set; }

        public string Pico { get; private set; }

        public PicoQualityEnum Quality { get; private set; }

        public string StateAddress { get; private set; }

        public string CityAddress { get; private set; }

        public DateTime DateCheck { get; private set; }

        public Guid IdCriador { get; private set; }

        public UserEntity Criador { get; private set; }

    }
}
