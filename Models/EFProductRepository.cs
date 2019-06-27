using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDBContext _context;

        public EFProductRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;
    }
}
