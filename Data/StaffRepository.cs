using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public class StaffRepository : IStaffRepository, IDisposable
    {
        private StaffContext context;

        public StudentRepository(StaffContext context)
        {
            this.context = context;
        }

        public IEnumerable<Staff> GetStaff()
        {
            return context.Students.ToList();
        }

        public Staff GetStaffByID(int id)
        {
            return context.Students.Find(id);
        }

        public void InsertStudent(Staff staff)
        {
            context.Students.Add(staff);
        }

        public void DeleteStudent(int studentID)
        {
            Staff staff = context.Students.Find(studentID);
            context.Students.Remove(staff);
        }

        public void UpdateStudent(Staff student)
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