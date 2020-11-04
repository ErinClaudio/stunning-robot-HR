using System;
using System.Collections.Generic;
using stunning_robot_HR.Models;


namespace stunning_robot_HR.Data
{
    public class IStaffRepository : IDisposable
    {
        public IEnumerable<Staff> GetStaff();
        public GetStaffByID(int StaffId);
        public void InsertStaff(Staff staff);
        void DeleteStaff(int StaffId);
        void UpdateStaff(Staff staff);
        public void Save();
        
    }
}