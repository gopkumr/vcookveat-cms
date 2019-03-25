using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VCookVEat.Models
{
    public class RecipeItemViewModel
    {
        public string Name { get; set; }
        public string Intro { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public string ImageId { get; set; }

        public string ContentUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}