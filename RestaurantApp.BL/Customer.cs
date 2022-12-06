namespace RestaurantApp.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }           
        }


    }
}