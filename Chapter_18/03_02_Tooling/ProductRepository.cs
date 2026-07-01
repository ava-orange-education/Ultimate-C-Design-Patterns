using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18._03_02_Tooling
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContext _context;

        public ProductRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetByIdAsync(Guid id) =>
            await _context.Set<Product>().FindAsync(id);

        public async Task<IEnumerable<Product>> GetAllAsync() =>
            await _context.Set<Product>().ToListAsync();

        public Task AddAsync(Product product)
        {
            _context.Set<Product>().Add(product);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(Guid id)
        {
            var product = await GetByIdAsync(id);
            if (product != null)
                _context.Set<Product>().Remove(product);
        }
    }
}
