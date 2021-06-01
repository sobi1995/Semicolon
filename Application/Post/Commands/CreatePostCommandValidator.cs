using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Post.Commands
{
   public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator()
        {
            RuleFor(v => v.Description)
                .NotEmpty();
            RuleFor(v => v.Tags)
               .NotEmpty();
            RuleFor(v => v.Title)
               .NotEmpty();
          

        }
    }
}
