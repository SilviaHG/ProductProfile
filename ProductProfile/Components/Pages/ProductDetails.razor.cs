using Microsoft.AspNetCore.Components;
using ProductProfile.Components.Models;

namespace ProductProfile.Components.Pages
{
    public partial class ProductDetails: ComponentBase
    {
        [Parameter]
        public Product product { get; set; }
    }
}
