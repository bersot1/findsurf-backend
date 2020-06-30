using FindSurf.Domain.Enumerable;
using System;

namespace FindSurf.Domain.Entities
{
    class Check : Entity
    {
        public Check(
            string urlImage, 
            string pico, 
            PicoQualityEnum quality, 
            string stateAddress, 
            string cityAddress, 
            DateTime dateCheck)
        {
            UrlImage = urlImage;
            Pico = pico;
            Quality = quality;
            StateAddress = stateAddress;
            CityAddress = cityAddress;
            DateCheck = dateCheck;
        }

        public string UrlImage { get; private set; }

        public string Pico { get; private set; }

        public PicoQualityEnum Quality { get; private set; }

        public string StateAddress { get; private set; }

        public string CityAddress { get; private set; }

        public DateTime DateCheck { get; private set; }
    }
}
