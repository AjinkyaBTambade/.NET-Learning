using MVCWebApp.Models;
using MVCWebApp.Models;
namespace MVCWebApp.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Remove(int id);
        void Insert(Product product);
        void Update(Product product);
    }
}
