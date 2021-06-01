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

namespace Application.Post.Commands
{
   public class CreatePostCommand : IRequest<int>
    {
        public string Title { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public ICollection<TagsDto> Tags { get; set; }
    }


    public class CreateContactCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateContactCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Domain.Entities.Post>(request);
            _context.Post.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;


        }
    }
}
