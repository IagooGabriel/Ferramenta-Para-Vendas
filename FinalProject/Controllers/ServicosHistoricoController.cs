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
    public class ServicosHistoricoController : Controller
    {
        private readonly ContextoBanco _context;
        private void CarregarListaServicos()
        {
            ViewBag.ListaServicos = _context.Servicos.Select(p => new SelectListItem()
            {
                Text = p.nome_serv,
                Value = p.id_serv.ToString()
            }).ToList();
        }

        public ServicosHistoricoController(ContextoBanco context)
        {
            _context = context;
        }

        // GET: ServicosHistorico
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServicosHistoricos.ToListAsync());
        }

        // GET: ServicosHistorico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoHistorico = await _context.ServicosHistoricos
                .FirstOrDefaultAsync(m => m.id_servHist == id);
            if (servicoHistorico == null)
            {
                return NotFound();
            }

            return View(servicoHistorico);
        }

        // GET: ServicosHistorico/Create
        public IActionResult Create()
        {
            CarregarListaServicos();
            return View();
        }

        // POST: ServicosHistorico/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_servHist,servicosId,oqfoialterado,dtAlteracao")] ServicoHistoricoModelView servicoHistoricoView)
        {
            if (ModelState.IsValid){
                var shmv = new ServicoHistorico();
                shmv.oqfoialterado = servicoHistoricoView.oqfoialterado;
                shmv.dtAlteracao = DateTime.Now;
                int IdServ = 0;

                int.TryParse(servicoHistoricoView.servicosId, out IdServ);
                shmv.servicos = _context.Servicos.Where(w => w.id_serv == IdServ).FirstOrDefault();

                _context.Add(shmv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            CarregarListaServicos();
            return View(servicoHistoricoView);
            
        }

        // GET: ServicosHistorico/Edit/5
        public async Task<IActionResult> Edit(int? id){
            if (id == null){
                return NotFound();
            }

            var servicoHistorico = await _context.ServicosHistoricos.FindAsync(id);
            if (servicoHistorico == null){
                return NotFound();
            }
            var historicoView = new ServicoHistoricoModelView();
            historicoView.id_servHist = servicoHistorico.id_servHist;
            historicoView.servicosId = servicoHistorico.servicos.id_serv.ToString();
            historicoView.oqfoialterado = servicoHistorico.oqfoialterado;
            historicoView.dtAlteracao = servicoHistorico.dtAlteracao;

            CarregarListaServicos();
            return View(historicoView);
        }

        // POST: ServicosHistorico/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_servHist,servicosId,oqfoialterado,dtAlteracao")] ServicoHistoricoModelView servicoHistoricoView){
            if (id != servicoHistoricoView.id_servHist){
                return NotFound();
            }

            if (ModelState.IsValid){
                try{
                    var shmv = new ServicoHistorico();
                    shmv.oqfoialterado = servicoHistoricoView.oqfoialterado;
                    shmv.id_servHist= id;
                    shmv.dtAlteracao = DateTime.Now;
                    int IdServ = 0;
                    int.TryParse(servicoHistoricoView.servicosId, out IdServ);
                    shmv.servicos = _context.Servicos.Where(w => w.id_serv == IdServ).FirstOrDefault();
                    _context.Update(shmv);
                    await _context.SaveChangesAsync();
                }catch (DbUpdateConcurrencyException){
                    if (!ServicoHistoricoExists(servicoHistoricoView.id_servHist)){
                        return NotFound();
                    }else{
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            CarregarListaServicos();
            return View(servicoHistoricoView);
        }

        // GET: ServicosHistorico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicoHistorico = await _context.ServicosHistoricos
                .FirstOrDefaultAsync(m => m.id_servHist == id);
            if (servicoHistorico == null)
            {
                return NotFound();
            }

            return View(servicoHistorico);
        }

        // POST: ServicosHistorico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicoHistorico = await _context.ServicosHistoricos.FindAsync(id);
            _context.ServicosHistoricos.Remove(servicoHistorico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicoHistoricoExists(int id)
        {
            return _context.ServicosHistoricos.Any(e => e.id_servHist == id);
        }
    }
}
