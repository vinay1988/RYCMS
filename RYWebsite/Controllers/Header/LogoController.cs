using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Web.Mvc;
using RYWebsite.Models;

namespace RYWebsite.Controllers.Header
{
    public class LogoController : Controller
    {
        SitecoreContext _context;
        IRenderingContext _renderingContext;

        public LogoController()
        {
           _context = new SitecoreContext();
           _renderingContext = new RenderingContextMvcWrapper();
        }
        // GET: Logo
        public ActionResult Logo()
        {
            var model = _context.GetItem<Logo>(new Guid(_renderingContext.GetDataSource()));
            return View("/Views/Header/Logo.cshtml",model);
        }
    }
}