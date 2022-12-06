using RestaurantApp.BL;

namespace TestProjectRestaurant
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            //arrange
            var testCustomer = new Customer("sam", "jam");
            
            var expectedFullName = "sam jam";

            //act
            var observerdFull = testCustomer.FullName;

            //assert
            Assert.AreEqual(expectedFullName, observerdFull);
        }
    }
}