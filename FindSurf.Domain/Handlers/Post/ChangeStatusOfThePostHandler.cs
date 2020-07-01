using FindSurf.Domain.Commands;
using FindSurf.Domain.Commands.Contracts;
using FindSurf.Domain.Commands.Post;
using FindSurf.Domain.Handlers.Contracts;
using FindSurf.Domain.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindSurf.Domain.Handlers.Post
{
    class ChangeStatusOfThePostHandler : Notifiable, IHandle<ChangeStatusOfThePostCommand>
    {
        private readonly IPostRepository _postRepository;

        public ChangeStatusOfThePostHandler(IPostRepository postRepository)
        {
            postRepository = _postRepository;
        }

        public ICommandResult Handle(ChangeStatusOfThePostCommand command)
        {
            command.Validate();
            if (command.Invalid)
            {
                return new GenericCommandResult(false, "Alguma coisa deu errado!!!", command.Notifications);
            }

            var post = _postRepository.GetById(command.Id);

            post.changeStatus(Enumerable.StatusEnum.Vendido);

            return new GenericCommandResult(
                true, "sucesoo!", post);


        }
    }
}
