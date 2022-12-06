using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.BL
{
   public enum DishCategory
    {
        starter,
        maincourse,
        desert
    }

    public class Dish
    {
        public Dish(int id,string name, DishCategory category, int price)
        {
            Id= id;
            Name = name;
            Category = category;
            Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DishCategory Category { get; set; }

        public int Price { get; set; }

    }
}
