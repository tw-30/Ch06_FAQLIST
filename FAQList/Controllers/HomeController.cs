using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FAQList.Models;

namespace FAQList.Controllers
{
    public class HomeController : Controller
    {
        private QuestionContext context { get; set; }
        public HomeController(QuestionContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var question = context.Questions.OrderBy(m => m.QuestionID).ToList();
            return View(question);
        }
    }
}
