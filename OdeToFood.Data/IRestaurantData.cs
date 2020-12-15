using OdeToFood.Core;
//using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;


namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id="1", Name="Scott's Pizza", Cuisine=CuisineType.Italian,Location="Maryland"},
                new Restaurant{Id="2", Name="Taj Tandoori", Cuisine=CuisineType.Indian,Location="New York"},
                new Restaurant{Id="3", Name="La Ligo", Cuisine=CuisineType.Mexican,Location="Chicago"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            //return from r in restaurants orderby r.Name select r;
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
