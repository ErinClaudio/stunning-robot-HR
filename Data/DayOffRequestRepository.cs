using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public class DayOffRequestRepository : IDayOffRequestRepository, IDisposable
    {
        private stunning_robot_HRContext _context;

        public DayOffRequestRepository(stunning_robot_HRContext context)
        {
            _context = context;
        }

        public IEnumerable<DayOffRequest> GetDayOffRequest()
        {
            return _context.DayOffRequests.ToList();
        }

        public DayOffRequest RequestId(int RequestId)
        {
            throw new NotImplementedException();
        }

        public DayOffRequest GetDayOffRequestById(int id)
        {
            return _context.DayOffRequests.Find(id);
        }

        public void InsertDayOffRequest(DayOffRequest dayOffRequest)
        {
            throw new NotImplementedException();
        }

        public void DeleteDayOffRequest(int RequestId)
        {
            DayOffRequest dayOffRequest = _context.DayOffRequests.Find(RequestId);
            _context.DayOffRequests.Remove(dayOffRequest);
        }

        public void UpdateSDayOffRequest(DayOffRequest dayOffRequest)
        {
            throw new NotImplementedException();
        }

        public void UpdateDayOffRequest(DayOffRequest dayOffRequest)
        {
            throw new NotImplementedException();
        }

        /*public void UpdateStudent(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
        }*/

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