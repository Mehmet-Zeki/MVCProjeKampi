using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampı.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message

        MessageManager cm = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            var messagelistin = cm.GetListInbox();
            return View(messagelistin);
        }

        public ActionResult Sendbox()
        {
            var messagelistsend = cm.GetListSenbox();
            return View(messagelistsend);
        }
    }
}