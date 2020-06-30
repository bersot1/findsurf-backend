using FindSurf.Domain.Enumerable;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Entities
{
    class Post : Entity
    {
        public Post(
            string urlImage,
            string title, 
            string description, 
            string stateAddress, 
            string cityAddress, 
            string phone, 
            Guid idCategory, 
            Category category, 
            StatusEnum status, 
            StateProductEnum productState, 
            Guid idCriador, 
            User criador)
        {
            UrlImage = urlImage;
            Title = title;
            Description = description;
            StateAddress = stateAddress;
            CityAddress = cityAddress;
            Phone = phone;
            IdCategory = idCategory;
            Category = category;
            Status = status;
            ProductState = productState;
            IdCriador = idCriador;
            Criador = criador;
        }

        public string UrlImage { get; private set; }
        public string Title { get; private set; }

        public string Description { get; private set; }

        public string StateAddress { get; private set; }

        public string CityAddress { get; private set; }

        public string Phone { get; private set; }

        public Guid IdCategory { get; private set; }

        public Category Category { get; private set; }

        public StatusEnum Status { get; private set; }

        public StateProductEnum ProductState { get; private set; }

        public Guid IdCriador { get; private set; }

        public User Criador { get; private set; }

        public void changeStatus(StatusEnum newStatus)
        {
            this.Status = newStatus;
        }

        public void changeStatus(StateProductEnum newState)
        {
            this.ProductState = newState;
        }
    }


}
