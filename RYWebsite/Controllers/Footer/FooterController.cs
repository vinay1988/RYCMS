using System.Web.Mvc;
using Glass.Mapper.Sc;
using RYWebsite.Models;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using System;

namespace RYWebsite.Controllers.Footer
{
    public class FooterController : Controller
    {
        SitecoreContext _context;
        //RenderingContext _renderingContext;
        IRenderingContext _renderingContext;
        public FooterController()
        {
            _context = new SitecoreContext();
            //_renderingContext = new RenderingContext();
           _renderingContext = new RenderingContextMvcWrapper();
        }

        // GET: Footer

        public ActionResult Footer()
        {
            var ds = _renderingContext.GetDataSource();
            var model = _context.GetItem<FooterModel>(new Guid(_renderingContext.GetDataSource()));
            return View(model);
        }
    }
}