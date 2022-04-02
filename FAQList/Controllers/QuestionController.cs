using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FAQList.Models;
using System.Collections.Generic;

namespace FAQList.Controllers
{
    public class QuestionController : Controller
    {
        private QuestionContext context { get; set; }
        public QuestionController(QuestionContext ctx)
        {
            context = ctx;
        }
        public IActionResult TopicSort()
        {
            var topic = context.Questions.OrderBy(m => m.TopicType).ToList();
            return View(topic);
        }
        public IActionResult CategorySort()
        {
            var category = context.Questions.OrderBy(m => m.CategoryType).ToList();
            return View(category);
        }
    }
}
