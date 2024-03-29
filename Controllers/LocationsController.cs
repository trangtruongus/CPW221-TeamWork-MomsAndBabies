﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CPW221_MomsAndBabies.Data;
using CPW221_MomsAndBabies.Models;
using CPW221_MomsAndBabies.Migrations;

namespace CPW221_MomsAndBabies.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Locations
        public async Task<IActionResult> Index()
        {
              return _context.Location != null ? 
                          View(await _context.Location.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Location'  is null.");
        }

        // GET: Locations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Location == null)
            {
                return NotFound();
            }

            var location = await _context.Location
                .FirstOrDefaultAsync(m => m.LocationID == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            var model = new Location();
            return View(model);
        }

        // POST: Locations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationID,LocationCode,LocationName,Address,City,State,ZipCode")] Location location)
        {
            if (ModelState.IsValid)
            {
                _context.Add(location);
                await _context.SaveChangesAsync();

                // Show success message
                ViewData["Message"] = $"{location.LocationName} has been added successfully!";

                return View();
            }
            return View(location);
        }

        // GET: Locations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Location == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationID,LocationCode,LocationName,Address,City,State,ZipCode")] Location location)
        {
            if (id != location.LocationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(location);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{location.LocationName} was updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        // GET: Locations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Location == null)
            {
                return NotFound();
            }

            var location = await _context.Location
                .FirstOrDefaultAsync(m => m.LocationID == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Location == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Location'  is null.");
            }
            Location? location = await _context.Location.FindAsync(id);
            if (location != null)
            {
                _context.Location.Remove(location);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{location.LocationName} was deleted successfully!";
            }
            else
            {
                TempData["Message"] = $"This location was already deleted!";
            }


            return RedirectToAction(nameof(Index));
        }

        private bool LocationExists(int id)
        {
          return (_context.Location?.Any(e => e.LocationID == id)).GetValueOrDefault();
        }
    }
}
