using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

using VCookVEat.Models;

namespace VCookVEat.mappers
{
    public static class DynamicContentToRecipeItemMapper
    {
        public static RecipeItemViewModel Convert(IPublishedContent source)
        {
            var destination = new RecipeItemViewModel();

            destination.Name = System.Convert.ToString(source.GetProperty("recipeName").DataValue);
            destination.Intro = System.Convert.ToString(source.GetProperty("recipeIntro").DataValue);
            destination.Ingredients = System.Convert.ToString(source.GetProperty("ingredients").DataValue);
            destination.Steps = System.Convert.ToString(source.GetProperty("recipeSteps").DataValue);
            destination.ImageId = System.Convert.ToString(source.GetProperty("recipeImage").Value);

            

            destination.ContentUrl = source.Url;
            destination.CreatedDate = source.CreateDate;

            return destination;

        }
    }
}