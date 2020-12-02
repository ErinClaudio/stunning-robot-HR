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
        
        public SearchForStaff(stunning_robot_HRContext context)
        {
            _context = context;
            staffRepository = new StaffRepository(_context);
        }

        public async Task<IActionResult> GetStaffByFullName(string searchString)
        {
            var staff = staffRepository.GetStaffByFullName(searchString);
            return View(staff); // is this issue here in my return
        }
        
        
        /*
        public ViewResult GetStaffByFullName(string searchString)
        {
            Staff staff = staffRepository.GetStaffByFullName(searchString);
            return View(staff); 
        }
        */
        
        /*
        public ViewResult Details(int id)
        {
            Staff staff = staffRepository.GetStaffByID(id);
            return View(staff);
        }
        */

    }
}

