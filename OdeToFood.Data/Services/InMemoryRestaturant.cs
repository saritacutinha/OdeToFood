using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { ID = 1, Name = "Dominos Pizza", CuisineType = CusineType.Italian },
                new Restaurant { ID = 2, Name = "Mango Grove", CuisineType = CusineType.Indian },
                new Restaurant { ID = 3, Name = "Cafe noir", CuisineType = CusineType.French }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);

        }

        Restaurant IRestaurantData.Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.ID == id);
        }

        public void Add(Restaurant restaurant)
        {
            restaurant.ID = restaurants.Max(r => r.ID) + 1;
            restaurants.Add(restaurant);
            
        }
    }
}

