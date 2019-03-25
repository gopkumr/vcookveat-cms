using System.Web.Mvc;
using Umbraco.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;

namespace VCookVEat.Controllers
{
    public class LatestItemsSurfaceController : SurfaceController
    {
        // GET: LatestItems
        public ActionResult GetCourouselItems()
        {
            var listOfContent = new List<IPublishedContent>();
            foreach (var child in CurrentPage.Children)
            {
                if (child.Children.Count() > 0)
                {
                    var selectedItem = child.Children.OrderByDescending(q => q.CreateDate).First();
                    listOfContent.Add(selectedItem);
                }
            }

            return PartialView("HomeCarouselItem", listOfContent);
        }
    }
}