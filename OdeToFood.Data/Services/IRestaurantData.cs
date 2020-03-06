using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public interface IRestaurantData
    {
        void Add(Restaurant restaurant);
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);

    }

   
}
