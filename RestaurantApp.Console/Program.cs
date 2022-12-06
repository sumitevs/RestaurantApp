// See https://aka.ms/new-console-template for more information
using RestaurantApp.BL;

Console.WriteLine("Hello, Customer!");


var customer = new Customer("sam","jam");
var bill = new Bill();

var menu = new Menu();

Console.WriteLine("Displaying Menu!");
foreach (var dishItem in menu.dishes)
{
    Console.WriteLine($"{dishItem.Id} {dishItem.Category}  {dishItem.Name} {dishItem.Price}");
}

int requestedItemId;
int orderItemId = 1;
while(true)
{
    Console.WriteLine("enter item id");
    requestedItemId = Convert.ToInt32(Console.ReadLine());
    if (requestedItemId == 0)
    {
        Console.WriteLine("finished ordering");
        break;
    }
    Console.WriteLine("enter quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());

    //get the dish
    var selectDish = menu.GetDish(requestedItemId);

    //create order Item
    var orderItem = new OrderItem(orderItemId, selectDish,quantity);
    orderItemId++;

    bill.AddItem(orderItem);
}

Console.WriteLine($"you total bill is {bill.TotalBill()}");

