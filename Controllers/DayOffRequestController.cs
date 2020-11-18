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
    public class DayOffRequestController : Controller
    {
        private stunning_robot_HRContext _context;
        private  IDayOffRequestRepository dayOffRequestRepository;
        
        public DayOffRequestController(stunning_robot_HRContext context)
        {
            _context = context;
            this.dayOffRequestRepository= new DayOffRequestRepository(_context);
        }

        // GET: DayOffRequest
        public async Task<IActionResult> Index()
        {
            var dayOffRequests = dayOffRequestRepository.GetDayOffRequest();
            return View(dayOffRequests);
        }

        // GET: DayOffRequest/Details/5
        public ViewResult Details(int id)
        {
            DayOffRequest dayOffRequest = dayOffRequestRepository.GetDayOffRequestById(id);
            return View(dayOffRequest);
        }

        // GET: DayOffRequest/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: DayOffRequest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,StartDayOfTimeRequest,EndDayOfTimeOffRequest,TotalNumberOfAvailableDaysOff,TotalNumberOfHoursWorked")] DayOffRequest dayOffRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dayOffRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dayOffRequest);
        }
        
        //New method/s only for employees
        /*this method shows that if you are logged in as an
         employee you can see your total number of days off you have available.
         and 
         
         
         */ 
        

        // GET: DayOffRequest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            DayOffRequest dayOffRequest = dayOffRequestRepository.GetDayOffRequestById(id ?? 0);

            return View(dayOffRequest);
        }

        // POST: DayOffRequest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestId,StartDayOfTimeRequest,EndDayOfTimeOffRequest,TotalNumberOfAvailableDaysOff,TotalNumberOfHoursWorked")] DayOffRequest dayOffRequest)
        {
            if (ModelState.IsValid)
            {
                dayOffRequestRepository.UpdateDayOffRequest(dayOffRequest);
                dayOffRequestRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(dayOffRequest);
        }

        // GET: DayOffRequest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            DayOffRequest dayOffRequest = dayOffRequestRepository.GetDayOffRequestById(id ?? 0);
            return View(dayOffRequest);
        }

        // POST: DayOffRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dayOffRequest = await _context.DayOffRequests.FindAsync(id);
            _context.DayOffRequests.Remove(dayOffRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DayOffRequestExists(int id)
        {
            return _context.DayOffRequests.Any(e => e.RequestId == id);
        }
    
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}
