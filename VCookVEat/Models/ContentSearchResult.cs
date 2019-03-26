using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace VCookVEat.Models
{
    public class ContentSearchResult:RenderModel
    {
        public ContentSearchResult(IPublishedContent content) : base(content)
        {
            Result = new List<ContentResult>();
        }

        public IEnumerable<ContentResult> Result { get; set; }
       
        public int Count { get { return Result.Count(); } }
    }

    public class ContentResult
    {
        public string ContentId { get; set; }
        public string ContentUrl { get; set; }
        public string ContentType { get; set; }
        public string ContentName { get; set; }
    }
}