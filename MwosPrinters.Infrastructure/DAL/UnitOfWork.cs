using System;
using MwosPrinters.Core;
using MwosPrinters.Core.Interfaces;

namespace MwosPrinters.Infrastructure.DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {

        //public DbSet<Branch> Branches { get; set; }
        //public DbSet<Printer> Printers { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<NashuaBranch> NashuaBranches { get; set; }
        //public DbSet<NashuaContact> NashuaContacts { get; set; }
        //public DbSet<Request> Requests { get; set; }

        private MwosPrintersContext context = new MwosPrintersContext();
        private GenericRepository<Branch> branchRepository;
        private GenericRepository<Printer> printerRepository;
        private GenericRepository<User> userRepository;
        private GenericRepository<NashuaBranch> nashuaBranchRepository;
        private GenericRepository<NashuaContact> nashuaContactRepository;
        private GenericRepository<Request> requestRepository;

        public IGenericRepository<Branch> BranchRepository
        {
            get
            {

                if (this.branchRepository == null)
                {
                    this.branchRepository = new GenericRepository<Branch>(context);
                }
                return branchRepository;
            }
        }

        public IGenericRepository<Printer> PrinterRepository
        {
            get
            {

                if (this.printerRepository == null)
                {
                    this.printerRepository = new GenericRepository<Printer>(context);
                }
                return printerRepository;
            }
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }

        public IGenericRepository<NashuaBranch> NashuaBranchRepository
        {
            get
            {

                if (this.nashuaBranchRepository == null)
                {
                    this.nashuaBranchRepository = new GenericRepository<NashuaBranch>(context);
                }
                return nashuaBranchRepository;
            }
        }

        public IGenericRepository<NashuaContact> NashuaContactRepository
        {
            get
            {

                if (this.nashuaContactRepository == null)
                {
                    this.nashuaContactRepository = new GenericRepository<NashuaContact>(context);
                }
                return nashuaContactRepository;
            }
        }

        public IGenericRepository<Request> RequestRepository
        {
            get
            {

                if (this.requestRepository == null)
                {
                    this.requestRepository = new GenericRepository<Request>(context);
                }
                return requestRepository;
            }
        }



        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
