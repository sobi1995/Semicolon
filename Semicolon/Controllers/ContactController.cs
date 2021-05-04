using Application.Contact.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class ContactController : BaseController
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }



        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateContactCommand command)
        {
         return await Mediator.Send(command);
     
        }
    }
}
