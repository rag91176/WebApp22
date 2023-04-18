

using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Components
{
    public class CommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> comments = new List<string>() { "Good", "VGood", "Excellent" };
            return View("~/Views/Components/_Comment.cshtml", comments);
        }
    }
}
