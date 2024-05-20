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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}