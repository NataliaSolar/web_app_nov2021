using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class PurchaseEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PurchaseEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.PurchaseEvent.ToListAsync());
        }

        // GET: PurchaseEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseEvent = await _context.PurchaseEvent
                .FirstOrDefaultAsync(m => m.PurchaseEventId == id);
            if (purchaseEvent == null)
            {
                return NotFound();
            }

            return View(purchaseEvent);
        }

        // GET: PurchaseEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PurchaseEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PurchaseEventId,PurchaseDate")] PurchaseEvent purchaseEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purchaseEvent);
        }

        // GET: PurchaseEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseEvent = await _context.PurchaseEvent.FindAsync(id);
            if (purchaseEvent == null)
            {
                return NotFound();
            }
            return View(purchaseEvent);
        }

        // POST: PurchaseEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PurchaseEventId,PurchaseDate")] PurchaseEvent purchaseEvent)
        {
            if (id != purchaseEvent.PurchaseEventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseEventExists(purchaseEvent.PurchaseEventId))
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
            return View(purchaseEvent);
        }

        // GET: PurchaseEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseEvent = await _context.PurchaseEvent
                .FirstOrDefaultAsync(m => m.PurchaseEventId == id);
            if (purchaseEvent == null)
            {
                return NotFound();
            }

            return View(purchaseEvent);
        }

        // POST: PurchaseEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseEvent = await _context.PurchaseEvent.FindAsync(id);
            _context.PurchaseEvent.Remove(purchaseEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseEventExists(int id)
        {
            return _context.PurchaseEvent.Any(e => e.PurchaseEventId == id);
        }
    }
}
