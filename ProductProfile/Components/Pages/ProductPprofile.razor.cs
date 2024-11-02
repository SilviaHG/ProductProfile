using Microsoft.AspNetCore.Components;
using ProductProfile.Components.Models;

namespace ProductProfile.Components.Pages
{
    public partial class ProductPprofile: ComponentBase
    {
        private Product product;
        public int idProduct = 5;
        protected override void OnInitialized()
        {
            product = productR.GetProductbyId(idProduct);
            Console.WriteLine(product != null ? "Usuario obtenido correctamente" : "No se obtuvo ningún usuario");

        }
    }
}
