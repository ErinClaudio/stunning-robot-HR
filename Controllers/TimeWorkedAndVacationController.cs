using System;
using System.Data
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
    public class TimeWorkedAndVacationController : Controller
    {
        private stunning_robot_HRContext _context;
        private ITimeWorkedAndVacation _timeWorkedAndVacation;

        public TimeWorkedAndVacationController(stunning_robot_HRContext context, ITimeWorkedAndVacation  timeAndWork) //maybe here
        {
            _context = context;
            _timeWorkedAndVacation = timeAndWork;
            
        }// the issue might be here in the constructor 

        // GET: TimeWorkedAndVacation
        public async Task<IActionResult> Index()
        {
            var timeWorkedAndVacation = _timeWorkedAndVacation.GetTimeWorkedAndVacations();
             return View(timeWorkedAndVacation);
        }

        

        GET: TimeWorkedAndVacation/Details/5
        public ViewResult Details(int id)
        {
            TimeWorkedAndVacation timeWorkedAndVacation = _context.GetTimeWorkedAndVacationByID(id);
            return View(timeWorkedAndVacation);
        }

        // GET: TimeWorkedAndVacation/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TimeWorkedAndVacation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimeWorkedAndVacationId,TotalNumberOfDaysWorked,TotalNumberOfAvailableVacationDays")] TimeWorkedAndVacation timeWorkedAndVacation)
        {
            if (ModelState.IsValid)
            {
                _timeWorkedAndVacation.InsertTimeWorkedAndVacation(timeWorkedAndVacation);
                _timeWorkedAndVacation.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(timeWorkedAndVacation);
        }

        // GET: TimeWorkedAndVacation/Edit/5
        // public async Task<IActionResult> Edit(int? id)
        // {
    
        //    TimeWorkedAndVacation timeWorkedAndVacation = _timeWorkedAndVacation.GetTimeWorkedAndVacationByID(id);
        //     return View(timeWorkedAndVacation);
        // }

        // POST: TimeWorkedAndVacation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimeWorkedAndVacationId,TotalNumberOfDaysWorked,TotalNumberOfAvailableVacationDays")] TimeWorkedAndVacation timeWorkedAndVacation)
        {
            if (ModelState.IsValid)
            {
                _timeWorkedAndVacation.UpdateTimeWorkedAndVacation(timeWorkedAndVacation);
                _timeWorkedAndVacation.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(timeWorkedAndVacation);
        }


        // GET: TimeWorkedAndVacation/Delete/5
        // public async Task<IActionResult> Delete(int? id)
        // {
        //     TimeWorkedAndVacation timeWorkedAndVacation = _timeWorkedAndVacation.GetTimeWorkedAndVacationByID(id);
        //     return View(timeWorkedAndVacation);
        // }

        // POST: TimeWorkedAndVacation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeWorkedAndVacation = await _context.TimeWorkedAndVacation.FindAsync(id);
            _context.TimeWorkedAndVacation.Remove(timeWorkedAndVacation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeWorkedAndVacationExists(int id)
        {
            return _context.TimeWorkedAndVacation.Any(e => e.TimeWorkedAndVacationId == id);
        }

        public override bool Equals(object obj)
        {
        return obj is TimeWorkedAndVacationController controller &&
             EqualityComparer<ITimeWorkedAndVacation>.Default.Equals(_timeWorkedAndVacation, controller._timeWorkedAndVacation);
        }
  }
    
}
