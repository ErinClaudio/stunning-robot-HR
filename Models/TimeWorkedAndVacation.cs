using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.DependencyInjection;

namespace stunning_robot_HR.Models
{
    public class TimeWorkedAndVacation
    {
        public int TimeWorkedAndVacationId { get; set; }
        public int TotalNumberOfDaysWorked { get; set; }
        // this might have to be changed to a float
        public int TotalNumberOfAvailableVacationDays { get; set; }
        // this might have to be changed to a float
    }
}
//dotnet aspnet-codegenerator controller -name TimeWorkedAndVacationController -m TimeWorkedAndVacation -dc stunning_robot_HRContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
