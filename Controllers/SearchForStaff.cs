using System;
using System.Collections.Generic;
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
            List<stunning_robot_HR.Models.Staff> Staffcollection = new List<Staff>();
            Staffcollection.Add(staff);
            return View(Staffcollection); 
        }
        
        
        /*
        public ViewResult GetStaffByFullName(string searchString)
        {
<<<<<<< HEAD
            var staff = staffRepository.GetStaffByFullName(searchString);
            return View(staff);
        }
        
        
// I made the change to this method name per this comment
//https://github.com/ErinClaudio/stunning-robot-HR/pull/38/files/9a7a57255602e898f1b90a8ecaceea78b6e3d330..d4341b419ea872b1e65f0d1340ac79e37838d19f#r528364940
=======
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

>>>>>>> FrontEnd
    }
}

