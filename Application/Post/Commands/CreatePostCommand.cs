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
        public ICollection<string> Tags { get; set; }
    }


    public class CreateContactCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;
        public CreateContactCommandHandler(IApplicationDbContext context, IMapper mapper, ICurrentUserService currentUserService)
        {
            _context = context;
            _mapper = mapper;
            _currentUserService = currentUserService;
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            //var entity = _mapper.Map<Domain.Entities.Post>(request);
            //_context.Post.Add(entity);
            //!! must be refactore
            var tags = new List<Domain.Entities.Tags>();
            foreach (var item in request.Tags)
            {
                tags.Add(new Domain.Entities.Tags() { Tag = item });
            }
            var post = new Domain.Entities.Post() { 
            Title=request.Title,
            Description=request.Description,
            UserId=_currentUserService.UserId,
            Tags=tags
            
            
            };
            _context.Post.Add(post);
            await _context.SaveChangesAsync(cancellationToken);
            return post.Id;


        }
    }
}
