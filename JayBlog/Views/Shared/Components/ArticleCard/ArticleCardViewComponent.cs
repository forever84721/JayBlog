using JayBlog.Models.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayBlog.Views.Shared.Components.ArticleCard
{
    public class ArticleCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()//async Task
        {
            return View("ArticleCard", new ArticleCardViewModel() { Title = "Title Test", PublishTime = DateTime.Now ,Outline= ".NET Core 3.1 LTS (Long Term Support) 已在 2019/12/3 正式釋出，依我的觀點 LTS 是作為企業解決方案選項的重要條件，.NET Core 3.1 LTS 的問市意味在工作上可以放心大膽用下去囉。(補充：.NET Core 3.1 的下一版將會更名為 ...." });
        }
    }
}
