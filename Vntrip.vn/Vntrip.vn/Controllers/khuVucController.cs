using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vntrip.vn.Models;

namespace Vntrip.vn.Controllers
{
    public class khuVucController : Controller
    {
        vntripDataContext db = new vntripDataContext();
        // GET: khuVuc
        public ActionResult Index(int? page)
        {
            var khuVuc = from kv in db.KhuVucs select kv;
            return View(khuVuc.ToPagedList(page ?? 1,10));
        }
    }
}