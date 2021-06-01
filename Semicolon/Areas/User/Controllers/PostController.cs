using Application.Post.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.User.Controllers
{
    public class PostController : UserBaseController
    {
        public PostController()
        {

        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePostCommand createPostCommand)
        {
          var post=  await Mediator.Send(createPostCommand);
           return Ok(post);
        }
    }
}
