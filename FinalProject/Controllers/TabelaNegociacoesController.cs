using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models.Entity;
using FinalProject.Models.View;

namespace FinalProject.Controllers
{
    public class TabelaNegociacoesController : Controller
    {
        private readonly ContextoBanco _context;

        private void CarregaServico()
        {
            ViewBag.ListaServico = _context.Servicos.Select(p => new SelectListItem(){
                Text = p.nome_serv,
                Value = p.id_serv.ToString()
            }).ToList();
        }

        private void CarregaVendedores()
        {
            ViewBag.ListaVendedor = _context.Vendederores.Select(p => new SelectListItem()
            {
                Text = p.nome_vend,
                Value = p.id_vend.ToString()
            }).ToList();
        }

        public TabelaNegociacoesController(ContextoBanco context)
        {
            _context = context;
        }

        // GET: TabelaNegociacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TabelasNegociacao.ToListAsync());
        }

        // GET: TabelaNegociacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaNegociacao = await _context.TabelasNegociacao
                .FirstOrDefaultAsync(m => m.id_neg == id);
            if (tabelaNegociacao == null)
            {
                return NotFound();
            }

            return View(tabelaNegociacao);
        }

        // GET: TabelaNegociacoes/Create
        public IActionResult Create()
        {
            CarregaServico();
            CarregaVendedores();
            return View();
        }

        // POST: TabelaNegociacoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_neg, ServicoId, VendedorId, min_porcent,max_porcent")] TabelaNgociacoesViewModel tabelaNegociacao)
        {
            if (ModelState.IsValid)
            {
                var tn = new TabelaNegociacao();

                int IdServ = 0;
                int.TryParse(tabelaNegociacao.ServicoId, out IdServ);
                tn.servicos = _context.Servicos.Where(w => w.id_serv == IdServ).FirstOrDefault();

                
                int IdVendedor = 0;
                int.TryParse(tabelaNegociacao.VendedorId, out IdVendedor);
                tn.vendedores = _context.Vendederores.Where(w => w.id_vend == IdVendedor).FirstOrDefault();

                tn.min_porcent = tabelaNegociacao.min_porcent;
                tn.max_porcent = tabelaNegociacao.max_porcent;

                _context.Add(tn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            CarregaServico();
            CarregaVendedores();
            return View(tabelaNegociacao);
        }

        // GET: TabelaNegociacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaNegociacao = await _context.TabelasNegociacao.FindAsync(id);
            if (tabelaNegociacao == null)
            {
                return NotFound();
            }

            var model = new TabelaNgociacoesViewModel();
            model.id_neg = tabelaNegociacao.id_neg;
            model.ServicoId = tabelaNegociacao.servicos.id_serv.ToString();
            model.VendedorId = tabelaNegociacao.vendedores.id_vend.ToString();
            model.min_porcent = tabelaNegociacao.min_porcent;
            model.max_porcent = tabelaNegociacao.max_porcent;

            CarregaServico();
            CarregaVendedores();

            return View(model);
        }

        // POST: TabelaNegociacoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_neg, ServicoId, VendedorId, min_porcent,max_porcent")] TabelaNgociacoesViewModel tabelaNegociacao)
        {
            if (id != tabelaNegociacao.id_neg)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var tn = new TabelaNegociacao();

                    tn.id_neg = id;

                    int IdServ = 0;
                    int.TryParse(tabelaNegociacao.ServicoId, out IdServ);
                    tn.servicos = _context.Servicos.Where(w => w.id_serv == IdServ).FirstOrDefault();

                    int IdVendedor = 0;
                    int.TryParse(tabelaNegociacao.VendedorId, out IdVendedor);
                    tn.vendedores = _context.Vendederores.Where(w => w.id_vend == IdVendedor).FirstOrDefault();

                    tn.min_porcent = tabelaNegociacao.min_porcent;
                    tn.max_porcent = tabelaNegociacao.max_porcent;

                    _context.Update(tn);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TabelaNegociacaoExists(tabelaNegociacao.id_neg)){
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            CarregaServico();
            CarregaVendedores();
            return View(tabelaNegociacao);
        }

        // GET: TabelaNegociacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tabelaNegociacao = await _context.TabelasNegociacao
                .FirstOrDefaultAsync(m => m.id_neg == id);
            if (tabelaNegociacao == null)
            {
                return NotFound();
            }

            return View(tabelaNegociacao);
        }

        // POST: TabelaNegociacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tabelaNegociacao = await _context.TabelasNegociacao.FindAsync(id);
            _context.TabelasNegociacao.Remove(tabelaNegociacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TabelaNegociacaoExists(int id)
        {
            return _context.TabelasNegociacao.Any(e => e.id_neg == id);
        }
    }
}
