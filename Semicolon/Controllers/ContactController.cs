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


        public async Task<IActionResult> Profile()
        {
            _logger.Log(LogLevel.Information, "Test the logger", new Array[1]);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateContactCommand command)
        {
          await Mediator.Send(command);
            return Ok();
        }
    }
}
