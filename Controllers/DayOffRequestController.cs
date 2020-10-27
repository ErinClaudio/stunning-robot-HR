using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using stunning_robot_HR.Models;

namespace stunning_robot_HR.Controllers
{
    public class DayOffRequestController : Controller
    {
        private readonly DayOffRequestContext _context;

        public DayOffRequestController(DayOffRequestContext context)
        {
            _context = context;
        }

        // GET: DayOffRequest
        public async Task<IActionResult> Index()
        {
            var dayOffRequestContext = _context.DayOffRequest.Include(d => d.Staff);
            return View(await dayOffRequestContext.ToListAsync());
        }

        // GET: DayOffRequest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayOffRequest = await _context.DayOffRequest
                .Include(d => d.Staff)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dayOffRequest == null)
            {
                return NotFound();
            }

            return View(dayOffRequest);
        }

        // GET: DayOffRequest/Create
        public IActionResult Create()
        {
            ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId");
            return View();
        }

        // POST: DayOffRequest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,Id,TimeOffRequest,StaffId")] DayOffRequest dayOffRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dayOffRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", dayOffRequest.StaffId);
            return View(dayOffRequest);
        }

        // GET: DayOffRequest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayOffRequest = await _context.DayOffRequest.FindAsync(id);
            if (dayOffRequest == null)
            {
                return NotFound();
            }
            ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", dayOffRequest.StaffId);
            return View(dayOffRequest);
        }

        // POST: DayOffRequest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestId,Id,TimeOffRequest,StaffId")] DayOffRequest dayOffRequest)
        {
            if (id != dayOffRequest.Id)
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
                    if (!DayOffRequestExists(dayOffRequest.Id))
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
            ViewData["StaffId"] = new SelectList(_context.Set<Staff>(), "StaffId", "StaffId", dayOffRequest.StaffId);
            return View(dayOffRequest);
        }

        // GET: DayOffRequest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dayOffRequest = await _context.DayOffRequest
                .Include(d => d.Staff)
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var dayOffRequest = await _context.DayOffRequest.FindAsync(id);
            _context.DayOffRequest.Remove(dayOffRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DayOffRequestExists(int id)
        {
            return _context.DayOffRequest.Any(e => e.Id == id);
        }
    }
}
