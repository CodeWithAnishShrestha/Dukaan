using Dukaan.DataAccess.Data;
using Dukaan.DataAccess.Repository.IRepository;
using Dukaan.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukaan.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}