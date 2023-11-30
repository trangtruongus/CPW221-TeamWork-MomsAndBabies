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
    public class VendorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VendorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vendors
        public async Task<IActionResult> Index()
        {
              return _context.Vendor != null ? 
                          View(await _context.Vendor.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Vendor'  is null.");
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vendor == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor
                .FirstOrDefaultAsync(m => m.VendorID == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendorID,VendorName,VendorPhoneNumber,VendorEmail,VendorContactFirstName,VendorContactLastName")] Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendor);
                await _context.SaveChangesAsync();

                // Show success message
                ViewData["Message"] = $"{vendor.VendorName} has been added successfully!";

                return View();
            }
            return View(vendor);
        }

        // GET: Vendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vendor == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendorID,VendorName,VendorPhoneNumber,VendorEmail,VendorContactFirstName,VendorContactLastName")] Vendor vendor)
        {
            if (id != vendor.VendorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(vendor);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{vendor.VendorName} was updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View(vendor);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vendor == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor
                .FirstOrDefaultAsync(m => m.VendorID == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vendor == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Vendor'  is null.");
            }
            var vendor = await _context.Vendor.FindAsync(id);
            if (vendor != null)
            {
                _context.Vendor.Remove(vendor);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{vendor.VendorName} was deleted successfully!";
            }
            else
            {
                TempData["Message"] = $"This vendor was already deleted!";
            }


            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
          return (_context.Vendor?.Any(e => e.VendorID == id)).GetValueOrDefault();
        }
    }
}
