using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public class StaffRepository : IStaffRepository, IDisposable
    {
        private staffContext context; // or is this staffContext or stunning_robot_HR?

        public StaffRepository(staffContext context)
        {
            this.context = context;
        }

        public IEnumerable<Staff> GetStaff()
        {
            return context.Staff.ToList();
        }

        public Staff GetStaffByID(int id)
        {
            return context.Staff.Find(id);
        }

        public void InsertStudent(Staff staff)
        {
            context.Staff.Add(staff);
        }

        public void DeleteStaff(int StaffId)
        {
            Staff staff = context.Staff.Find(StaffId);
            context.Staff.Remove(staff);
        }

        public void UpdateStudent(Staff staff)
        {
            context.Entry(staff).State = EntityState.Modified;
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