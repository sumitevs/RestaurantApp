using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.BL
{
    public class OrderItem
    {
        public int id;
        public string DishName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int TotalPrice 
        { get { return Quantity* Price; }  
        }

        public OrderItem(int id, Dish dish, int quantity)
        {
            this.id = id;
            DishName = dish.Name;
            Quantity = quantity;
            Price = dish.Price;
        }
    }
}
