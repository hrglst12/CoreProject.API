using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreProject.Core.Models;

namespace CoreProject.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);//Projede Category ait methodlarınız oldugunda buraya tanimlayabiliriz        
    }
}