using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public class TimeWorkedAndVacationRepository : ITimeWorkedAndVacation, IDisposable
    {
        private stunning_robot_HRContext _context;

        public TimeWorkedAndVacationRepository(stunning_robot_HRContext context)
        {
            _context = context;
        }

        public IEnumerable<TimeWorkedAndVacation> GetTimeWorkedAndVacations()
        {
            return _context.TimeWorkedAndVacation.ToList();
        }
        public TimeWorkedAndVacation GetTimeWorkedAndVacationByID(int id)
        {
            return _context.TimeWorkedAndVacation.Find(id);
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

    IEnumerable<Staff> ITimeWorkedAndVacation.GetTimeWorkedAndVacations()
    {
      throw new NotImplementedException();
    }

    Staff ITimeWorkedAndVacation.GetTimeWorkedAndVacationByID(int timeWorkedAndVacationId)
    {
      throw new NotImplementedException();
    }

    public void InsertTimeWorkedAndVacation(TimeWorkedAndVacation timeWorkedAndVacation)
    {
      throw new NotImplementedException();
    }

    public void DeleteTimeWorkedAndVacation(int TimeWorkedAndVacationId)
    {
      throw new NotImplementedException();
    }

    public void UpdateTimeWorkedAndVacation(TimeWorkedAndVacation timeWorkedAndVacation)
    {
      throw new NotImplementedException();
    }
  }
}

//     IEnumerable<Staff> ITimeWorkedAndVacation.GetTimeWorkedAndVacations()
//     {
//       throw new NotImplementedException();
//     }

//     public Staff GetTimeWorkedAndVacationByID(int TimeWorkedAndVacationId)
//     {
//       throw new NotImplementedException();
//     }

//     public void InsertTimeWorkedAndVacation(TimeWorkedAndVacation timeWorkedAndVacation)
//     {
//       throw new NotImplementedException();
//     }

//     public void DeleteTimeWorkedAndVacation(int TimeWorkedAndVacationId)
//     {
//       throw new NotImplementedException();
//     }

//     public void UpdateTimeWorkedAndVacation(TimeWorkedAndVacation timeWorkedAndVacation)
//     {
//       throw new NotImplementedException();
//     }
//   }
//   }
//     }
// }