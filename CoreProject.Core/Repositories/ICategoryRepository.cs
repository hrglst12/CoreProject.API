using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreProject.Core.Models;

namespace CoreProject.Core.Repositories
{
     public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}