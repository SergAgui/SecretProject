using System.Linq;
using System.Threading.Tasks;
using GroupApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GroupApp.Controllers
{
    public class SouthLocationsController : Controller
    {
        private readonly GroupAppContext _context;

        public SouthLocationsController(GroupAppContext context)

        {
            _context = context;
        }

        // GET: SouthLocations
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.SouthLocations.ToListAsync());
        }

        // GET: SouthLocations/Details/5
       
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var southLocations = await _context.SouthLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (southLocations == null)
            {
                return NotFound();
            }

            return View(southLocations);
        }

        // GET: SouthLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SouthLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Establishment,Address,DateTime,Thoughts")] SouthLocations southLocations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(southLocations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(southLocations);
        }

        // GET: SouthLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var southLocations = await _context.SouthLocations.FindAsync(id);
            if (southLocations == null)
            {
                return NotFound();
            }
            return View(southLocations);
        }

        // POST: SouthLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Establishment,Address,DateTime,Thoughts")] SouthLocations southLocations)
        {
            if (id != southLocations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(southLocations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SouthLocationsExists(southLocations.Id))
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
            return View(southLocations);
        }

        // GET: SouthLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var southLocations = await _context.SouthLocations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (southLocations == null)
            {
                return NotFound();
            }

            return View(southLocations);
        }

        // POST: SouthLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var southLocations = await _context.SouthLocations.FindAsync(id);
            _context.SouthLocations.Remove(southLocations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SouthLocationsExists(int id)
        {
            return _context.SouthLocations.Any(e => e.Id == id);
        }
    }
}