using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using RYWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RYWebsite.Controllers.MediaCard
{
    public class MediaCardDetailController : Controller
    {
        SitecoreContext _context;
        IRenderingContext _renderingContext;

        public MediaCardDetailController()
        {
            _context = new SitecoreContext();
            _renderingContext = new RenderingContextMvcWrapper();
        }
        // GET: MediaCardDetail
        public ActionResult Index()
        {
            var model = _context.GetCurrentItem<MediaCardItem>();
            return View(model);
        }
    }
}