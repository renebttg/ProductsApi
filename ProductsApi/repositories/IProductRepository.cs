using ProductsApi.Models;

namespace ProductsApi.Repository
{
    public interface IProductRepository
    {

        Task<IEnumerable<Products>> GetAllAsync();
        Task<Products?> GetByIdAsync(int id);
        Task<Products> AddAsync(Products products);
        Task<Products> UpdateAsync(Products products);
        Task<bool> DeleteAsync(int id);

    }
}
