using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VCookVEat.Models
{
    public class FoodItemViewModel
    {
        public string ImageId { get; }
        public string Name { get; }
        public string Cuisine { get; }
        public string PageUrl { get; }
        public string Description { get; }
        public DateTime CreatedDate { get; }

        public FoodItemViewModel(string imageId, string name, string cuisine, string description, string pageUrl, DateTime createDate)
        {
            ImageId = imageId;
            Name = name;
            PageUrl = pageUrl;
            CreatedDate = createDate;
            Cuisine = cuisine;
            Description = description;
        }
    }
}