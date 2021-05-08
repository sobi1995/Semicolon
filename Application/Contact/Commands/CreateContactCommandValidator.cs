using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contact.Commands
{
   public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
    {
        public CreateContactCommandValidator()
        {
            RuleFor(v => v.Email)
                .NotEmpty();
            RuleFor(v => v.Message)
               .NotEmpty();
            RuleFor(v => v.Name)
               .NotEmpty();
            RuleFor(v => v.Subject)
               .NotEmpty();
         
        }
    }
}
