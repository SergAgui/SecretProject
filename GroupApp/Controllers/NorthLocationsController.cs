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
    public class NorthLocationsController : Controller
    {

        private readonly GroupAppContext _context;

        public NorthLocationsController(GroupAppContext context)

        {
            _context = context;
        }

        // GET: NorthLocations
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.NorthLocations.ToListAsync());
        }

        // GET: NorthLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var northLocations = await _context.NorthLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (northLocations == null)
            {
                return NotFound();
            }

            return View(northLocations);
        }

        // GET: NorthLocations/Create
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            return View();
        }

        // POST: NorthLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Establishment,Address,DateTime,Thoughts")] NorthLocations northLocations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(northLocations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(northLocations);
        }

        // GET: NorthLocations/Edit/5
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var northLocations = await _context.NorthLocations.FindAsync(id);
            if (northLocations == null)
            {
                return NotFound();
            }
            return View(northLocations);
        }

        // POST: NorthLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Establishment,Address,DateTime,Thoughts")] NorthLocations northLocations)
        {
            if (id != northLocations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(northLocations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NorthLocationsExists(northLocations.Id))
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
            return View(northLocations);
        }

        // GET: NorthLocations/Delete/5
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var northLocations = await _context.NorthLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (northLocations == null)
            {
                return NotFound();
            }

            return View(northLocations);
        }

        // POST: NorthLocations/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var northLocations = await _context.NorthLocations.FindAsync(id);
            _context.NorthLocations.Remove(northLocations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NorthLocationsExists(int id)
        {
            return _context.NorthLocations.Any(e => e.Id == id);
        }
    }
}
