using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebApp2.TestComponents
{
    public class TestComponentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> testcomments = new List<string>() { "Hi", "Hello", "Hello All" };
            return View("~/Views/TestComponents/_TestComment.cshtml",testcomments);
        }
    }
}
