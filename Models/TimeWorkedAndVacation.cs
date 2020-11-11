using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace stunning_robot_HR.Models
{
    public class TimeWorkedAndVacation
    {
        public int TimeWorkedAndVacationId { get; set; }
        public int TotalNumberOfDaysWorked { get; set; }
        public int TotalNumberOfAvailableVacationDays { get; set; }
    }
}
//dotnet aspnet-codegenerator controller -name TimeWorkedAndVacationController -m TimeWorkedAndVacation -dc stunning_robot_HRContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
