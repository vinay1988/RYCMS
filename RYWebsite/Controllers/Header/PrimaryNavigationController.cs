using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using RYWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RYWebsite.Controllers.Header
{
    public class PrimaryNavigationController : Controller
    {
        SitecoreContext _context;
        IRenderingContext _renderingContext;

        public PrimaryNavigationController()
        {
            _context = new SitecoreContext();
            _renderingContext = new RenderingContextMvcWrapper();
        }
        // GET: PrimaryNavigation
        public ActionResult Index()
        {
            var model = _context.GetItem<PrimaryNav>(new Guid(_renderingContext.GetDataSource()));
            return View("/Views/Header/PrimaryNav.cshtml",model);
        }
    }
}