using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroupApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace GroupApp.Controllers
{
    public class CentralLocationsController : Controller
    {

        private readonly GroupAppContext _context;
        
        public CentralLocationsController(GroupAppContext context)

      

        {
            _context = context;
        }

        // GET: CentralLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.CentralLocations.ToListAsync());
        }
        
        // GET: CentralLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centralLocations = await _context.CentralLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (centralLocations == null)
            {
                return NotFound();
            }

            return View(centralLocations);
        }

        // GET: CentralLocations/Create
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            return View();
        }

        // POST: CentralLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Establishment,Address,DateTime,Thoughts")] CentralLocations centralLocations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(centralLocations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(centralLocations);
        }

        // GET: CentralLocations/Edit/5
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centralLocations = await _context.CentralLocations.FindAsync(id);
            if (centralLocations == null)
            {
                return NotFound();
            }
            return View(centralLocations);
        }

        // POST: CentralLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Establishment,Address,DateTime,Thoughts")] CentralLocations centralLocations)
        {
            if (id != centralLocations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(centralLocations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CentralLocationsExists(centralLocations.Id))
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
            return View(centralLocations);
        }

        // GET: CentralLocations/Delete/5
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centralLocations = await _context.CentralLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (centralLocations == null)
            {
                return NotFound();
            }

            return View(centralLocations);
        }

        // POST: CentralLocations/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var centralLocations = await _context.CentralLocations.FindAsync(id);
            _context.CentralLocations.Remove(centralLocations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CentralLocationsExists(int id)
        {
            return _context.CentralLocations.Any(e => e.Id == id);
        }
    }
}
