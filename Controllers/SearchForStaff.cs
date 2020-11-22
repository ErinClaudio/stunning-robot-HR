using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stunning_robot_HR.Data;
using stunning_robot_HR.Models;


namespace stunning_robot_HR.Controllers
{
    public class SearchForStaff : Controller
    {
        private stunning_robot_HRContext _context;
        private IStaffRepository staffRepository;
        public async Task<IActionResult> searchresults(string searchString)
        {
            var staff = staffRepository.GetStaffByFullName(searchString);
            return View(staff);
        }

    }
}