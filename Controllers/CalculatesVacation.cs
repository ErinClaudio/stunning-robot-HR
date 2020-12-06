using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using stunning_robot_HR.Data;

namespace stunning_robot_HR.Controllers
{
    public class CalculatesVacation : Controller
    {
        private readonly stunning_robot_HRContext _context;
        
        /*public ViewResult AvailableTimeOff()
        {
            if (ModelState.IsValid)
            {
                timeWorkedAndVacation.totalNumberOfAvailableVacationDays = timeWorkedAndVacation.totalNumberOfDaysWorked * 1;
                _context.Add(timeWorkedAndVacation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeWorkedAndVacation);
        }*/
    }
}