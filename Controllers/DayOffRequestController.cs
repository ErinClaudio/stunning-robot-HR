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
    public class DayOffRequestController : Controller
    {
        private readonly stunning_robot_HRContext _context;

        public DayOffRequestController(stunning_robot_HRContext context)
        {
            _context = context;
        }

        // GET: DayOffRequest
        public async Task<IActionResult> Index()
        {
            return View(await _context.DayOffRequests.ToListAsync());
        }

        // GET: DayOffRequest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayOffRequest = await _context.DayOffRequests
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (dayOffRequest == null)
            {
                return NotFound();
            }

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
        public async Task<IActionResult> Create([Bind("RequestId,StartDayOfTimeRequest,EndDayOfTimeOffRequest,TotalNumberOfAvailableDaysOff")] DayOffRequest dayOffRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dayOffRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dayOffRequest);
        }

        // GET: DayOffRequest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayOffRequest = await _context.DayOffRequests.FindAsync(id);
            if (dayOffRequest == null)
            {
                return NotFound();
            }
            return View(dayOffRequest);
        }

        // POST: DayOffRequest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestId,StartDayOfTimeRequest,EndDayOfTimeOffRequest,TotalNumberOfAvailableDaysOff")] DayOffRequest dayOffRequest)
        {
            if (id != dayOffRequest.RequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dayOffRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DayOffRequestExists(dayOffRequest.RequestId))
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
            return View(dayOffRequest);
        }

        // GET: DayOffRequest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayOffRequest = await _context.DayOffRequests
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (dayOffRequest == null)
            {
                return NotFound();
            }

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
    }
}
