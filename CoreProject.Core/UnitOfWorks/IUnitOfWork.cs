using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreProject.Core.Models.Repositories;
using CoreProject.Core.Repositories;

namespace CoreProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }//burda olmak zorunda degil disaridan da erisilebilir ama bestpratice icin buraya yazdim

        ICategoryRepository categories { get; }//burda olmak zorunda degil disaridan da erisilebilir ama bestpratice icin buraya yazdim

        Task CommitAsync();//asenkron oldugu anlasilmasi icin Async keywordu ile yazdim

        void Commit();
    }
}