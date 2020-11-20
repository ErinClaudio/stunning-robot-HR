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
          
        }
        
    }
}