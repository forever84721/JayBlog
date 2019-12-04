using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayBlog.Views.Components
{
    [Microsoft.AspNetCore.Mvc.ViewComponent]
    public class TopBarViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public string Invoke()
        {
            return $"Test";
        }
    }
}
