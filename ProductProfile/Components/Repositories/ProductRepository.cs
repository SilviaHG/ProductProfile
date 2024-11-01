using ProductProfile.Components.Models;
using ProductProfile.Components.Repositories.Interfaces;

namespace ProductProfile.Components.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductbyId(int id)
        {

            return new Product
            {
                Name = "T-Shirt",
                Price = 4500,
                Description= "Color black with cards design"

            };

        }
    }
}
