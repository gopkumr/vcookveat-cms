using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using VCookVEat.Models;

namespace VCookVEat.Controllers
{
    public class SearchResultsController : RenderMvcController
    {
        // GET: SearchResults
        public ActionResult Index(RenderModel model, string keyword)
        {
            var searchResults = new ContentSearchResult(UmbracoContext.PublishedContentRequest.PublishedContent);

           return CurrentTemplate(searchResults);
        }
    }
}