using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;
using ProductsApi.Models;

namespace ProductsApi.Repository
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Products?> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Products> AddAsync (Products products)
        {
            _context.Products.Add(products);
            await _context.SaveChangesAsync();
            return products;
        }

        public async Task<Products?> UpdateAsync(Products products)
        {
            var existing = await _context.Products.FindAsync(products.Id);
            if (existing == null) return null;

            existing.name = products.name;
            existing.price = products.price;
            existing.description = products.description;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _context.Products.FindAsync(id);
            if (existing == null) return false;

            _context.Products.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
