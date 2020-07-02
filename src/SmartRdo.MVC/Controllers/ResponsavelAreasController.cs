using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartRdo.Business.Models;
using SmartRdo.Data.Context;

namespace SmartRdo.MVC.Controllers
{
    public class ResponsavelAreasController : Controller
    {
        private readonly SmartRdoDbContext _context;

        public ResponsavelAreasController(SmartRdoDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ResponsavelAreas.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavelArea = await _context.ResponsavelAreas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (responsavelArea == null)
            {
                return NotFound();
            }

            return View(responsavelArea);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Id")] ResponsavelArea responsavelArea)
        {
            if (ModelState.IsValid)
            {
                responsavelArea.Id = Guid.NewGuid();
                _context.Add(responsavelArea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(responsavelArea);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavelArea = await _context.ResponsavelAreas.FindAsync(id);
            if (responsavelArea == null)
            {
                return NotFound();
            }
            return View(responsavelArea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Id")] ResponsavelArea responsavelArea)
        {
            if (id != responsavelArea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(responsavelArea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResponsavelAreaExists(responsavelArea.Id))
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
            return View(responsavelArea);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var responsavelArea = await _context.ResponsavelAreas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (responsavelArea == null)
            {
                return NotFound();
            }

            return View(responsavelArea);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var responsavelArea = await _context.ResponsavelAreas.FindAsync(id);
            _context.ResponsavelAreas.Remove(responsavelArea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResponsavelAreaExists(Guid id)
        {
            return _context.ResponsavelAreas.Any(e => e.Id == id);
        }
    }
}
