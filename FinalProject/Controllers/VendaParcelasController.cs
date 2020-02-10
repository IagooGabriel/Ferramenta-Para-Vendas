using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models.Entity;

namespace FinalProject.Controllers
{
    public class VendaParcelasController : Controller
    {
        private readonly ContextoBanco _context;

        public VendaParcelasController(ContextoBanco context)
        {
            _context = context;
        }

        // GET: VendaParcelas
        public async Task<IActionResult> Index()
        {
            return View(await _context.VendasParcelas.ToListAsync());
        }

        // GET: VendaParcelas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaParcela = await _context.VendasParcelas
                .FirstOrDefaultAsync(m => m.id_parc == id);
            if (vendaParcela == null)
            {
                return NotFound();
            }

            return View(vendaParcela);
        }

        // GET: VendaParcelas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendaParcelas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_parc,parcelas,dt_vencimento,dt_pagamento,valor")] VendaParcela vendaParcela)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendaParcela);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendaParcela);
        }

        // GET: VendaParcelas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaParcela = await _context.VendasParcelas.FindAsync(id);
            if (vendaParcela == null)
            {
                return NotFound();
            }
            return View(vendaParcela);
        }

        // POST: VendaParcelas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_parc,parcelas,dt_vencimento,dt_pagamento,valor")] VendaParcela vendaParcela)
        {
            if (id != vendaParcela.id_parc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaParcela);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaParcelaExists(vendaParcela.id_parc))
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
            return View(vendaParcela);
        }

        // GET: VendaParcelas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaParcela = await _context.VendasParcelas
                .FirstOrDefaultAsync(m => m.id_parc == id);
            if (vendaParcela == null)
            {
                return NotFound();
            }

            return View(vendaParcela);
        }

        // POST: VendaParcelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendaParcela = await _context.VendasParcelas.FindAsync(id);
            _context.VendasParcelas.Remove(vendaParcela);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaParcelaExists(int id)
        {
            return _context.VendasParcelas.Any(e => e.id_parc == id);
        }
    }
}
