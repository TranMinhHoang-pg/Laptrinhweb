using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tuan_1_ltweb.Controllers
{
    public class phimController : Controller
    {
        // GET: phim
        public ActionResult Index()
        {
            return View();
        }
        // GET: phim/PartialView2
        public ActionResult PartialView2()
        {
            return PartialView();
        }
        // GET: phim/content2
        public ActionResult content2()
        {
            return Content("content2");
        }
        // GET: phim/redirect2
        public ActionResult redirect2()
        {
            return Redirect("");
        }
        // GET: phim/redirectToAction2
        public ActionResult redirectToAction2()
        {
            return RedirectToAction("","");
        }
        // GET: phim/json2
        public ActionResult json2()
        {
            return Json("");
        }
        // GET: phim/file2
        public ActionResult file2()
        {
            return File("","");
        }
        // GET: phim/httpNotFound
        public ActionResult httpNotFound2()
        {
            return HttpNotFound();
        }
        // GET: phim/emptyResult2
        public ActionResult emptyResult2()
        {
            return new EmptyResult();
        }
        // GET: phim/baitap4
        public ActionResult baitap4()
        {
            ViewBag.hoten = "Trần Minh Hoàng";
            ViewBag.mssv = "151900113";
            ViewBag.nam = "2001";
            return View();
        }
        // GET: phim/baitap5
        public ActionResult baitap5(int x, int y, string pheptinh)
        {
            if(pheptinh == "cong")
            {
                ViewBag.kq = x + y;
            }
            else if(pheptinh == "tru")
            {
                ViewBag.kq = x - y;

            }
            else if(pheptinh == "nhan")
            {
                ViewBag.kq = x * y;
            }
            else if(pheptinh == "chia")
            {
                float x1 = x;
                float y1 = y;
                float ketqua = x1 / y1;
                ViewBag.kq = ketqua;
            }
            else
            {
                ViewBag.kq = "nhập phép tính không hợp lệ";
            }

            return Content(ViewBag.kq.ToString());
        }

    }
}