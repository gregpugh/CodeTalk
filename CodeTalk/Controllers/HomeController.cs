using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTalk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            TalkService talkService = new TalkService();
            ViewBag.Talks = talkService.GetTalks().OrderByDescending(t => t.DateCreated);
            return View();
        }

        public ActionResult SubmitTalk()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        [HttpPost]
        public ActionResult SubmitTalk(Talk talk)
        {
            var talkService = new TalkService();
            talkService.AddTalk(talk);
            return RedirectToAction("Index");
           
        }

        public ActionResult AddComment(int id)
        {

            Comment comment = new Comment() { TalkId = id };
            return View(comment);
        }

        [HttpPost]
        public ActionResult AddComment(Comment newComment)
        {
            var commentService = new CommentService();
            commentService.AddComment(newComment);

            return RedirectToAction("Index");
        }
    }
}
