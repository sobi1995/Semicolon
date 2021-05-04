using Application.Common.Dtos;
using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Contact.Commands
{
  public  class CreateContactCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        //public ContactDto Contact { get; set; }
    }

    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateContactCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {

            //var entity = _mapper.Map<Domain.Entities.Contact>(request);
            //entity.DomainEvents.Add(new TodoItemCreatedEvent(entity));
            var entity = new Domain.Entities.Contact() {
                Message=request.Message,
                Email = request.Email,
                Name = request.Name,
                Subject = request.Subject

            };
            _context.Contact.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;


        }
    }
}
