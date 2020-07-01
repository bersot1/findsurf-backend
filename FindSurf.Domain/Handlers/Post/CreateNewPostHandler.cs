using FindSurf.Domain.Commands;
using FindSurf.Domain.Commands.Check;
using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Commands.Post;
using FindSurf.Domain.Entities;
using FindSurf.Domain.Handlers.Contracts;
using FindSurf.Domain.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Handlers.Post
{
    class CreateNewPostHandler : Notifiable, IHandle<CreatePostCommand>
    {
        private readonly IPostRepository _postRepository;

        private readonly ICategoryRepository _categoryRepository;

        private readonly IUserRepository _userRepository;

        public CreateNewPostHandler(IPostRepository postRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            postRepository = _postRepository;
            categoryRepository = _categoryRepository;
            userRepository = _userRepository;
        }

        public ICommandResult Handle(CreatePostCommand command)
        {
            command.Validate();
            if (command.Invalid)
            {
                return new GenericCommandResult(
                    false,
                    "Alguma coisa deu errada!!!",
                    command.Notifications);
            }

            var category = _categoryRepository.GetById(command.IdCategory);

            var criador = _userRepository.GetById(command.IdCriador);

            var newPost = new PostEntity(
                command.UrlImage, 
                command.Title, 
                command.Description, 
                command.StateAddress, 
                command.CityAddress, 
                command.Phone, 
                command.IdCategory, 
                category,
                Enumerable.StatusEnum.Avenda,
                command.ProductState,command.IdCriador,criador);

            _postRepository.Insert(newPost);

            return new GenericCommandResult(true, "Sucesso", newPost);
        }
    }
}
