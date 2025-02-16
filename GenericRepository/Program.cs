using Entity;

namespace GenericRepository
{
    class Program
    {
        public static void Main(string[] Args)
        {
            GenericRepo<User> user_repo = new GenericRepo<User>();
            user_repo.Add(new User{
                UserId = 1, 
                Name = "Kiran",
                Gender = GenderDefination.MALE
            });
            user_repo.Update(new User{
                UserId = 1, 
                Name = "Kiran Sarode",
                Gender = GenderDefination.MALE
            });
            user_repo.Get(1);
            user_repo.GetAll();
            user_repo.Delete(1);

            GenericRepo<Product> prod_repo = new GenericRepo<Product>();
            prod_repo.Add(new Product{
                ProductId = 1, 
                Name = "Mac Mini M4 256GB",
                Description = "Fast and mini Apple PC",
                Price = 999
            });
            prod_repo.Update(new Product{
                ProductId = 1, 
                Name = "Mac Mini M4 256GB",
                Description = "Fast and mini Apple PC",
                Price = 999
            });
            prod_repo.Get(1);
            prod_repo.GetAll();
            prod_repo.Delete(1);

            GenericRepo<Order> order_repo = new GenericRepo<Order>();
            order_repo.Add(new Order{
                OrderId = 1,
                UserId = 1,
                ProductId = 1, 
                Quantity = 4, 
                ProductPrice = 999
            });
            order_repo.Update(new Order{
                OrderId = 1,
                UserId = 1,
                ProductId = 1, 
                Quantity = 4, 
                ProductPrice = 999
            });
            order_repo.Get(1);
            order_repo.GetAll();
            order_repo.Delete(1);
        }
    }
}

