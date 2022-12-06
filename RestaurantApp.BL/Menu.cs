using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.BL
{
    public class Menu
    {
        public List<Dish> dishes;

        public Menu()
        {
            dishes = new List<Dish> 
            {
                new Dish(1,"starter1",DishCategory.starter,10),
                new Dish(2,"starter2",DishCategory.starter,15),
                new Dish(3,"maincourse1",DishCategory.maincourse,20),
                new Dish(4,"maincourse2",DishCategory.maincourse,25),
                new Dish(5,"desert1",DishCategory.desert,5),
                new Dish(6,"desert21",DishCategory.desert,10),
            };
        }

        public Dish GetDish(int requestedItemId)
        {
            return dishes.FirstOrDefault( item => item.Id == requestedItemId);
        }
    }
}
