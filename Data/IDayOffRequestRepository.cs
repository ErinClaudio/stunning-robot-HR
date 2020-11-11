using System;
using System.Collections.Generic;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Data
{
    public interface IDayOffRequestRepository
    {
        IEnumerable<DayOffRequest> GetDayOffRequest();
        DayOffRequest GetDayOffRequestById (int requestId );
        void InsertDayOffRequest(DayOffRequest dayOffRequest);
        void DeleteDayOffRequest(int requestId);
        void UpdateDayOffRequest(DayOffRequest dayOffRequest);
        void Save();
        
    }
}