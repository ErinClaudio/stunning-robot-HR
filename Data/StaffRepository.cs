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
        private stunning_robot_HRContext _context; 

        public StaffRepository(stunning_robot_HRContext context)
        {
            _context = context;
        }

        public IEnumerable<Staff> GetStaff()
        {
            return _context.Staff.ToList();
        }

        public Staff GetStaffByID(int id)
        {
            return _context.Staff.Find(id);
        }

        public void InsertStaff(Staff staff)
        {
            throw new NotImplementedException();
        }

        /*public void InsertStudent(Staff staff)
        {
            _context.Staff.Add(staff);
        }*/

        public void DeleteStaff(int StaffId)
        {
            Staff staff = _context.Staff.Find(StaffId);
            _context.Staff.Remove(staff);
        }

        public void UpdateStaff(Staff staff)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Staff staff)
        {
            _context.Entry(staff).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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