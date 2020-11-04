using System;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public class UnitOfWork : IDisposable
    {
        private StaffContext context = new staffContext();
        private GenericRepository<Staff> staffRepository;
        

        public GenericRepository<Staff> DepartmentRepository
        {
            get
            {

                if (this.staffRepository == null)
                {
                    this.staffRepository = new GenericRepository<Staff>(context);
                }
                return staffRepository;
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