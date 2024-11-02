using ProductProfile.Components.Models;
using ProductProfile.Components.Repositories.Interfaces;
using System.Runtime.CompilerServices;

namespace ProductProfile.Components.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> productsList = new List<Product>()
        {
            new Product {Id = 1, Name = "Estuche para celular", Price = 5500, Description = "Estuche color rojo para Samsung." },
            new Product {Id = 2, Name = "Mouse Inalámbrico", Price = 9900, Description = "Mouse Inalámbrico color negro con rojo." },
            new Product {Id = 3, Name = "Cable HDMI", Price = 4200, Description = "Cable trenzado HDMI de 15 pies de largo."},
            new Product {Id = 4, Name = "Cable RJ45", Price = 3500, Description = "Cable RJ45 color azul."},
            new Product {Id = 5, Name = "Tablet", Price = 120000, Description = "Tablet marca Redmi" },
            new Product {Id = 6, Name = "Xiaomi Band 6", Price = 45500, Description = "XiaomiBand 6 cuenta con las mejores aplicaciones" }
        };

        public Product GetProductbyId(int id)
        {

            foreach (var product in productsList)
            {
                if (product.Id == id) return product;
            }
            return null;
        }
    }
}
