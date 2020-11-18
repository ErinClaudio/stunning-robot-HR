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
        

        public Staff GetStaffByFullName(string searchString)
        {
            var staffs = from s in GetStaff()
                select s;
             
            if (!String.IsNullOrEmpty(searchString))
            {
                staffs = staffs.Where(s => s.FullName.Contains(searchString));
            }
            return _context.Staff(searchString); //LOOK HERE
        }


        public void InsertStaff(Staff staff)
        {
            _context.Staff.Add(staff);
        }
        

        public void DeleteStaff(int StaffId)
        {
            Staff staff = _context.Staff.Find(StaffId);
            _context.Staff.Remove(staff);
        }

        public void UpdateStaff(Staff staff)
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

    void IStaffRepository.GetStaffByFullName(string searchString)
    {
      throw new NotImplementedException();
    }
  }
}