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
    public class SecondaryNavigationController : Controller
    {
        SitecoreContext _context;
        IRenderingContext _renderingcontext;

        public SecondaryNavigationController()
        {
            _context = new SitecoreContext();
            _renderingcontext = new RenderingContextMvcWrapper();
        }

        // GET: SecondaryNavigation
        public ActionResult Index()
        {
            var model = _context.GetItem<SecondaryNavModel>(new Guid(_renderingcontext.GetDataSource()));
            return View("/Views/Header/SecondaryNav.cshtml", model);
        }
    }
}