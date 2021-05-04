using Application.Common.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.Home.Components.About
{
    public class ContactViewComponent : ViewComponent
    {
        public ContactDto InputModel { get; set; }
        public ContactViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return await Task.FromResult((IViewComponentResult)View("ContactViewComponent"));
        }
    }
}
