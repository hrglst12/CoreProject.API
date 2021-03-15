using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreProject.Core.Models.Repositories;
using CoreProject.Core.Repositories;
using CoreProject.Core.UnitOfWorks;
using CoreProject.Data.Repositories;

namespace CoreProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;//contexti belirtiyorum

        private ProductRepository _productRepository;
        private CategoryRepository _CategoryRepository;

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);//_productRepository var ise al, yoksa yeni bi tane olustur

        public ICategoryRepository categories => _CategoryRepository = _CategoryRepository ?? new CategoryRepository(_context);//_CategoryRepository var ise al, yoksa olustur

        IProductRepository IUnitOfWork.Products => throw new NotImplementedException();

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;//contexti constructor'dan gelen appDbContext ile doldurdum
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}