using CommentSystem.Models;
using CommentSystem.Models.DTO;
using System;
using System.Web.Mvc;

namespace CommentSystem.Controllers
{
    public class HomeController : Controller
    {
        CommentRepository repo = new CommentRepository();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommentPartial()
        {
            var comments = repo.GetAll();
            return PartialView("_CommentPartial", comments);
        }

        public JsonResult addNewComment(commentDTO comment)
        {
            try
            {
                var model = repo.AddComment(comment);

                return Json(new { error = false,result=model }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception)
            {
                //Handle Error here..
            }

            return Json(new { error = true }, JsonRequestBehavior.AllowGet);
        }
    }
}