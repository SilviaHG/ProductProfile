using ProductProfile.Components.Models;

namespace ProductProfile.Components.Repositories.Interfaces
{
    public interface IProductRepository
    {
       Product GetProductbyId(int id);
    }
}
