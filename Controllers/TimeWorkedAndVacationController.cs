using System;
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
        private readonly stunning_robot_HRContext _context;

        public TimeWorkedAndVacationController(stunning_robot_HRContext context)
        {
            _context = context;
        }

        // GET: TimeWorkedAndVacation
        public async Task<IActionResult> Index()
        {
            return View(await _context.TimeWorkedAndVacation.ToListAsync());
        }

        // GET: TimeWorkedAndVacation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeWorkedAndVacation = await _context.TimeWorkedAndVacation
                .FirstOrDefaultAsync(m => m.TimeWorkedAndVacationId == id);
            if (timeWorkedAndVacation == null)
            {
                return NotFound();
            }

            return View(timeWorkedAndVacation);
        }

        // GET: TimeWorkedAndVacation/Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimeWorkedAndVacationId,TotalNumberOfDaysWorked,TotalNumberOfAvailableVacationDays")] TimeWorkedAndVacation timeWorkedAndVacation)
        {
            if (ModelState.IsValid)
            {
                timeWorkedAndVacation.totalNumberOfAvailableVacationDays = timeWorkedAndVacation.totalNumberOfDaysWorked * 1;
                _context.Add(timeWorkedAndVacation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeWorkedAndVacation);
        }
        /*public  ActionResult Create(TotalNumberOfDaysWorked totalNumberOfDaysWorked, TotalNumberOfAvailableVacationDays totalNumberOfAvailableVacationDays)
        {
            totalNumberOfAvailableVacationDays = totalNumberOfDaysWorked * .0125;
            totalNumberOfDaysWorked = 0;
            if (ModelState.IsValid)
            {
                _context.Add(totalNumberOfDaysWorked,totalNumberOfAvailableVacationDays);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }*/



        // POST: TimeWorkedAndVacation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]   this is the original scaffolded method
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TimeWorkedAndVacationId,TotalNumberOfDaysWorked,TotalNumberOfAvailableVacationDays")] TimeWorkedAndVacation timeWorkedAndVacation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timeWorkedAndVacation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeWorkedAndVacation);
        }*/

        // GET: TimeWorkedAndVacation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeWorkedAndVacation = await _context.TimeWorkedAndVacation.FindAsync(id);
            if (timeWorkedAndVacation == null)
            {
                return NotFound();
            }
            return View(timeWorkedAndVacation);
        }

        // POST: TimeWorkedAndVacation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TimeWorkedAndVacationId,TotalNumberOfDaysWorked,TotalNumberOfAvailableVacationDays")] TimeWorkedAndVacation timeWorkedAndVacation)
        {
            if (id != timeWorkedAndVacation.TimeWorkedAndVacationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timeWorkedAndVacation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeWorkedAndVacationExists(timeWorkedAndVacation.TimeWorkedAndVacationId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(timeWorkedAndVacation);
        }

        // GET: TimeWorkedAndVacation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeWorkedAndVacation = await _context.TimeWorkedAndVacation
                .FirstOrDefaultAsync(m => m.TimeWorkedAndVacationId == id);
            if (timeWorkedAndVacation == null)
            {
                return NotFound();
            }

            return View(timeWorkedAndVacation);
        }

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
    }
    
}
