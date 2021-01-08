using System;
using System.Collections.Generic;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public interface ITimeWorkedAndVacation
    {
        IEnumerable<Staff> GetTimeWorkedAndVacations();
        Staff GetTimeWorkedAndVacationByID(int timeWorkedAndVacationId);

        void InsertTimeWorkedAndVacation(TimeWorkedAndVacation timeWorkedAndVacation);
        void DeleteTimeWorkedAndVacation(int TimeWorkedAndVacationId);
        void UpdateTimeWorkedAndVacation(TimeWorkedAndVacation timeWorkedAndVacation);
        void Save();
        
    }
}