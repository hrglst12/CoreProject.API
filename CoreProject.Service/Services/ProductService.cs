using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CoreProject.Core.Models;
using CoreProject.Core.Repositories;
using CoreProject.Core.Services;
using CoreProject.Core.UnitOfWorks;

namespace CoreProject.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}