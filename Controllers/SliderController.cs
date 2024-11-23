using SliderApplication.DAL;
using SliderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SliderApplication.Controllers
{
    public class SliderController : Controller
    {
        private readonly SliderContext _context;
        public SliderController() : base()
        {
            _context = new SliderContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveSlider(Slider s)
        {
            s.Files = Request.Files;
            HttpPostedFileBase file = s.Files[0];
            string fp = "~/Images/" + file.FileName;
            s.FilePath = fp;
            //if (ModelState.IsValid)
            //{
                _context.sliders.Add(s);
                _context.SaveChanges();
                file.SaveAs(Server.MapPath(fp));
                List<Slider> slist = _context.sliders.ToList();
                return View("DisplaySlider", slist);
            //}
            //else
            //{
            //    return View("Index",s);
            //}
        }
        public ActionResult DisplaySlider()
        {
            List<Slider>slist=_context.sliders.ToList();
            return View(slist);
        }
    }
}