using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;

namespace CodeTalk.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Talk/

        public ActionResult Index()
        {
            var commentService = new CommentService();
            var comments = commentService.GetComments();
            return View(comments);
        }


        public ActionResult Insert(int id)
        {

            Comment comment = new Comment() { TalkId = id };
            return View(comment);
        }

        [HttpPost]
        public ActionResult Insert(Comment newComment)
        {
            var commentService = new CommentService();
            commentService.AddComment(newComment);
            
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var commentService = new CommentService();
            Comment comment = commentService.GetCommentById(id);
            return View(comment);
        }
        [HttpPost]
        public ActionResult Edit(Comment comment)
        {
            var commentService = new CommentService();
            commentService.EditComment(comment);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var commentService = new CommentService();
            Comment comment = commentService.GetCommentById(id);
            return View(comment);
        }
    }
}
