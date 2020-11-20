using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using stunning_robot_HR.Data;
using stunning_robot_HR.Models;


namespace stunning_robot_HR.Controllers
{
    public class SearchForStaff : Controller
    
    {
        private stunning_robot_HRContext _context;
        private  IStaffRepository staffRepository;
        
        public ViewResult GetStaffByFullName(string searchString)
        {
            var staffs = from s in staffRepository.GetStaff()
                select s;
             
            if (!String.IsNullOrEmpty(searchString))
            {
                staffs = staffs.Where(s => s.FullName.Contains(searchString));
            }
            return View(searchString);
        }
        
    }
}