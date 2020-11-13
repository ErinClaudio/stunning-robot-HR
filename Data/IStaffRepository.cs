using System;
using System.Collections.Generic;
using stunning_robot_HR.Models;


namespace stunning_robot_HR.Data
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> GetStaff();
        Staff GetStaffByID(int StaffId);
        void GetStaffByFullName(string searchString);
        void InsertStaff(Staff staff);
        void DeleteStaff(int StaffId);
        void UpdateStaff(Staff staff);
        void Save();
        
    }
}