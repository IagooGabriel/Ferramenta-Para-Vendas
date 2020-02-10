using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models.Entity;
using FinalProject.Models.View;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.Http;
using System.Net;

namespace FinalProject.Controllers
{
    public class VendasController : Controller
    {
        private readonly ContextoBanco _context;


        private void CarregarListaTpPagamentos(){
            ViewBag.ListaTipoPagamentos = _context.TiposPagamento.Select(p => new SelectListItem(){
                Text = p.nome_tpPag,
                Value = p.id_tpPag.ToString()
            }).ToList();
        }

        private void CarregarListaServicos()
        {
            ViewBag.ListaServicos = _context.Servicos.Select(p => new SelectListItem(){
                Text = p.nome_serv,
                Value = p.id_serv.ToString()
            }).ToList();
        }
        private void CarregarListaVendedores(){
            ViewBag.ListaVendedores = _context.Vendederores.Select(p => new SelectListItem()
            {
                Text = p.nome_vend,
                Value = p.id_vend.ToString()
            }).ToList();
        }

        private void CarregarListaClientes(){
            ViewBag.ListaClientes = _context.Clientes.Select(p => new SelectListItem()
            {
                Text = p.nome_cli,
                Value = p.id_cli.ToString()
            }).ToList();
        }
        /*private void CarregarListaTabelaNegociacaoMin()
        {
            ViewBag.ListaTbNegociacao = _context.TabelasNegociacao.Select(p => new SelectListItem()
            {
                 Text = p.min_porcent.ToString(),
                 Value = p.id_neg.ToString()
            }).ToList();
        }
        private void CarregarListaTabelaNegociacaoMax()
        {
            ViewBag.ListaTbNegociacao = _context.TabelasNegociacao.Select(p => new SelectListItem()
            {
                Text = p.max_porcent.ToString(),
                Value = p.id_neg.ToString()
            }).ToList();
        }*/


        public VendasController(ContextoBanco context)
        {
            _context = context;
        }

        // GET: Vendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendas.ToListAsync());
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.id_venda == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // GET: Vendas/Create
        public IActionResult Create()
        {
            CarregarListaClientes();
            CarregarListaVendedores();
            CarregarListaServicos();
            CarregarListaTpPagamentos();
            return View();

        }

        // POST: Vendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_venda,valor,parcelas,tipoPagamentoId,servicosId,vendedoresId,clientesId,tabelaNegociacaoId")] TipoPagamentosModel venda)
        {
            if (ModelState.IsValid) {                
                var tpg = new Venda();
                var tn = new TabelaNegociacao();

                tpg.valor = venda.valor;
                tpg.dataVenda = DateTime.Now;
                int idPag = 0;
                int.TryParse(venda.tipoPagamentoId, out idPag);
                tpg.tipoPagamento = _context.TiposPagamento.Where(w => w.id_tpPag == idPag).FirstOrDefault();

                int IdServ = 0;
                int.TryParse(venda.servicosId, out IdServ);
                tpg.servicos = _context.Servicos.Where(w => w.id_serv == IdServ).FirstOrDefault();

                int IdVendedor = 0;
                int.TryParse(venda.vendedoresId, out IdVendedor);
                tpg.vendedores = _context.Vendederores.Where(w => w.id_vend == IdVendedor).FirstOrDefault();

                int IdCliente = 0;
                int.TryParse(venda.clientesId, out IdCliente);
                tpg.clientes = _context.Clientes.Where(w => w.id_cli == IdCliente).FirstOrDefault();

                int IdTnMin = 0;
                int.TryParse(venda.tabelaNegociacaoId, out IdTnMin);
                tpg.TabelaNegociacao = _context.TabelasNegociacao.Where(w => w.id_neg == IdTnMin).FirstOrDefault();

                //var valorMin = _context.Vendas.Select(s => new Venda { id_venda = s.id_venda }).ToList();

                // condições de verificação.
                var tbPreco = _context.TabelasNegociacao.Where(w => w.servicos.id_serv == IdServ && w.vendedores.id_vend == IdVendedor).FirstOrDefault();

                // condições de verificação.

                if (tbPreco == null || tbPreco.min_porcent > venda.valor || tbPreco.max_porcent < venda.valor)
                {
                    //TempData[]"Message" = "Valor mais Baixo ou mais Alto que o valor minimo ou maximo permitido";
                    return RedirectToAction("Index");
                }

                _context.Add(tpg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            CarregarListaClientes();
            CarregarListaVendedores();
            CarregarListaServicos();
            CarregarListaTpPagamentos();
            return View(venda);
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null){
                return NotFound();
            }
            var venda = await _context.Vendas.FindAsync(id);
            if (venda == null){
                return NotFound();
            }
            var model = new TipoPagamentosModel();
            model.dataVenda = venda.dataVenda;
            model.id_venda = venda.id_venda;
            model.parcelas = venda.parcelas;
            model.servicosId = venda.servicos.id_serv.ToString();
            model.tipoPagamentoId = venda.tipoPagamento.id_tpPag.ToString();
            model.vendedoresId = venda.vendedores.id_vend.ToString();
            model.clientesId = venda.clientes.id_cli.ToString();
            model.valor = venda.valor;

            CarregarListaClientes();
            CarregarListaVendedores();
            CarregarListaServicos();
            CarregarListaTpPagamentos();
            return View(model);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_venda,dataVenda,valor,parcelas,tipoPagamentoId,servicosId,vendedoresId,clientesId, tabelaNegociacaoId")] TipoPagamentosModel vendaModel){
            if (id != vendaModel.id_venda){
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try{
                    var tpg = new Venda();
                    var tn = new TabelaNegociacao();

                    tpg.dataVenda = vendaModel.dataVenda;
                    tpg.id_venda = id;
                    tpg.valor = vendaModel.valor;
                    tpg.parcelas = vendaModel.parcelas;

                    int idPag = 0;
                    int.TryParse(vendaModel.tipoPagamentoId, out idPag);
                    tpg.tipoPagamento = _context.TiposPagamento.Where(w => w.id_tpPag == idPag).FirstOrDefault();

                    int IdServ = 0;
                    int.TryParse(vendaModel.servicosId, out IdServ);
                    tpg.servicos = _context.Servicos.Where(w => w.id_serv == IdServ).FirstOrDefault();

                    int IdVendedor = 0;
                    int.TryParse(vendaModel.vendedoresId, out IdVendedor);
                    tpg.vendedores = _context.Vendederores.Where(w => w.id_vend == IdVendedor).FirstOrDefault();

                    int IdCliente = 0;
                    int.TryParse(vendaModel.clientesId, out IdCliente);
                    tpg.clientes = _context.Clientes.Where(w => w.id_cli == IdCliente).FirstOrDefault();

                    var tbPreco = _context.TabelasNegociacao.Where(w => w.servicos.id_serv == IdServ && w.vendedores.id_vend == IdVendedor).FirstOrDefault();

                    // condições de verificação.

                    if (tbPreco == null || tbPreco.min_porcent > vendaModel.valor || tbPreco.max_porcent < vendaModel.valor)
                    {
                        //TempData[]"Message" = "Valor mais Baixo ou mais Alto que o valor minimo ou maximo permitido";
                        return RedirectToAction("Index");
                    }

                    _context.Update(tpg);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaExists(vendaModel.id_venda))
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
            CarregarListaClientes();
            CarregarListaVendedores();
            CarregarListaServicos();
            CarregarListaTpPagamentos();
            return View(vendaModel);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venda = await _context.Vendas
                .FirstOrDefaultAsync(m => m.id_venda == id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venda = await _context.Vendas.FindAsync(id);
            _context.Vendas.Remove(venda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaExists(int id)
        {
            return _context.Vendas.Any(e => e.id_venda == id);
        }
    }
}
