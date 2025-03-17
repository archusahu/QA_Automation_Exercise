
namespace AutomationExerciseTests.Model
{

    public class Cat
    {
        public User UserType { get; set; }
        public string Category { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }
        public Cat Category { get; set; }
    }

    public class ProductsListResponse
    {
        public int ResponseCode { get; set; }
        public List<Product> Products { get; set; }
    }

    public class User
    {
        public string UserType { get; set; }
    }
}
