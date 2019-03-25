using Umbraco.Core.Models;
using VCookVEat.Models;

namespace VCookVEat.mappers
{
    public static class DynamicContentToFoodItemMapper
    {
        public static FoodItemViewModel Convert(IPublishedContent source)
        {
            var destination = new FoodItemViewModel(
                 System.Convert.ToString(source.GetProperty("photoOfTheFood").Value),
                 System.Convert.ToString(source.GetProperty("foodName").DataValue),
                 System.Convert.ToString(source.GetProperty("cuisine").DataValue),
                 System.Convert.ToString(source.GetProperty("description").DataValue),
                 source.Url,
                 source.CreateDate
                );

            return destination;
        }
    }
}