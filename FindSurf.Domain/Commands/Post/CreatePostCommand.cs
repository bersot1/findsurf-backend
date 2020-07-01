using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Enumerable;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Commands.Post
{
    class CreatePostCommand : Notifiable, ICommand
    {
        public CreatePostCommand() { }
        public CreatePostCommand(
            string urlImage, 
            string title, 
            string description, 
            string stateAddress, 
            string cityAddress, 
            string phone, 
            Guid idCategory, 
            StateProductEnum productState, 
            Guid idCriador)
        {
            UrlImage = urlImage;
            Title = title;
            Description = description;
            StateAddress = stateAddress;
            CityAddress = cityAddress;
            Phone = phone;
            IdCategory = idCategory;
            ProductState = productState;
            IdCriador = idCriador;
        }

        public string UrlImage { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string StateAddress { get; private set; }
        public string CityAddress { get; private set; }
        public string Phone { get; private set; }
        public Guid IdCategory { get; private set; }
        public StateProductEnum ProductState { get; private set; }
        public Guid IdCriador { get; private set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNull(UrlImage, "UrlImage", "O campo Imagem não pode ser nulo")
                    .IsNull(Title, "Title", "O campo Title não pode ser nulo")
                    .IsNull(Description, "Description", "O campo Description não pode ser nulo")
                    .HasMinLen(Description, 20, "Description", "Por favor descreva melhor sua descrição do produto")
                    .IsNull(StateAddress, "StateAddress", "O campo StateAddress não pode ser nulo")
                    .IsNull(CityAddress, "CityAddress", "O campo CityAddress não pode ser nulo")
                    .IsNull(Phone, "Phone", "O campo Phone não pode ser nulo")
                    .IsNull(IdCategory, "IdCategory", "O campo IdCategory não pode ser nulo")
                    .IsNull(ProductState, "ProductState", "O campo ProductState não pode ser nulo")
                    .IsNull(IdCriador, "IdCriador", "O campo IdCriador não pode ser nulo")
                );
        }
    }
}
