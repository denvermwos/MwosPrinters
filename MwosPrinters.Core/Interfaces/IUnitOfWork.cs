using System;
namespace MwosPrinters.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Branch> BranchRepository { get; }
        IGenericRepository<NashuaBranch> NashuaBranchRepository { get; }
        IGenericRepository<NashuaContact> NashuaContactRepository { get; }
        IGenericRepository<Printer> PrinterRepository { get; }
        IGenericRepository<Request> RequestRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        
        void Save();
        void Dispose();
    }
}
