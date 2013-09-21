using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CodeTalk.Domain.Models;
using CodeTalk.ServiceLayer;

namespace CodeTalk.Controllers
{
    public class TalkController : Controller
    {
        //
        // GET: /Talk/

        public ActionResult Index()
        {
            var talkService = new TalkService();
            var talks = talkService.GetTalks();
            return View(talks);
        }


        public ActionResult Insert()
        {

            //var talk = new Talk();
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Talk newTalk)
        {
            var talkService = new TalkService();
            talkService.AddTalk(newTalk);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var talkService = new TalkService();
            Talk talk = talkService.GetTalkById(id);
            return View(talk);
        }
        [HttpPost]
        public ActionResult Edit(Talk talk)
        {
            var talkService = new TalkService();
            talkService.EditTalk(talk);
            //return View(talk);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var talkService = new TalkService();
            Talk talk = talkService.GetTalkById(id);
            return View(talk);
        }
    }
}
