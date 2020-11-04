using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using stunning_robot_HR.Data;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Controllers
{
    public class StaffController : Controller
    {
        private  IStaffRepository staffRepository;
        public StaffController()
        {
            this.staffRepository = new StaffRepository(new stunning_robot_HRContext());
        }
        public StaffController(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }
        
        
        // GET: Staff
        public async Task<IActionResult> Index()
        {
             var staffs = from s in staffRepository.GetStaff()
                select s;
             return View(staffs);
        }

        // GET: Staff/Details/5
        public ViewResult Details(int id)
        {
            Staff staff = staffRepository.GetStaffById(id);
            return View(staff);
        }

        // GET: Staff/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffId,FullName,DateOfBirth,Position,StartDate")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                staffRepository.InsertStaff(staff);
                staffRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }

        // GET: Staff/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Staff staff = staffRepository.GetStaffByID(id);
            return View(staff);
        }

        // POST: Staff/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffId,FullName,DateOfBirth,Position,StartDate")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                staffRepository.UpdateStaff(staff);
                staffRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }

        // GET: Staff/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Staff staff = staffRepository.GetStaffByID(id);
            return View(staff);
        }

        /*/ POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staff = await _context.Staff.FindAsync(id);
            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.StaffId == id);
        }
        */
        protected override void Dispose(bool disposing)
        {
            staffRepository.Dispose();
            base.Dispose(disposing);
        }
    }

  
}
