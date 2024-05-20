﻿using Dukaan.Models.Models;

namespace Dukaan.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category obj);
    }
}