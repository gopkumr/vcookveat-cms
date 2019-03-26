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
            var contentResults = new List<Models.ContentResult>();

            var queryResult = Umbraco.TypedSearch(keyword, true);
            var searchResults = new ContentSearchResult(UmbracoContext.PublishedContentRequest.PublishedContent);
            
            foreach(var result in queryResult)
            {
                contentResults.Add(new Models.ContentResult()
                {
                    ContentId=result.Id.ToString(),
                    ContentName=result.Name,
                    ContentType=result.DocumentTypeAlias,
                    ContentUrl=result.Url
                });
            }

            searchResults.Result = contentResults;
            return CurrentTemplate(searchResults);
        }
    }
}