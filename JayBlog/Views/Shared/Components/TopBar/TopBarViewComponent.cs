using JayBlog.Models.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayBlog.Views.Shared.Components.TopBar
{
    [ViewComponent]
    public class TopBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()//async Task
        {
            return View("TopBar", new TopBarViewModel() { A = 123, B = "88" });
        }
    }
}
