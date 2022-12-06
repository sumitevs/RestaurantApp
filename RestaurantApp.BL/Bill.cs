using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.BL
{
    public class Bill
    {
        List<OrderItem> items;

        public Bill()
        {
            items = new List<OrderItem>();
        }

        public void AddItem(OrderItem oItem)
        {
            items.Add(oItem);
        }

        public int TotalBill()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.TotalPrice;
            }
            return total;
        }
    }
}
