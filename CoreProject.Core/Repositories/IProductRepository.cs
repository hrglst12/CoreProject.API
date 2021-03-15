using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreProject.Core.Models;
using CoreProject.Core.Repositories;

namespace CoreProject.Core.Models.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}