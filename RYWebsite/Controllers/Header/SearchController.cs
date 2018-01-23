using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using RYWebsite.Models;
using System;
using System.Web.Mvc;

namespace RYWebsite.Controllers.Header
{
    public class SearchController : Controller
    {
        SitecoreContext _context;
        IRenderingContext _renderingcontext;

        public SearchController()
        {
            _context = new SitecoreContext();
            _renderingcontext = new RenderingContextMvcWrapper();
        }

        // GET: Search
        public ActionResult Search()
        {
            var model = _context.GetItem<SearchModel>(new Guid(_renderingcontext.GetDataSource()));
            return View("/Views/Header/Search.cshtml", model);
        }
    }
}