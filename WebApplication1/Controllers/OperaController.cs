using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    public class OperaController : Controller
    {

        private readonly OperaContext _context;

        public OperaController(OperaContext context)
        {
            _context = context;
        }

        //[ActionName("index")]
        public async Task<IActionResult> Index0()
        {
            return View(await _context.Operas.ToListAsync());
        }

        //[HttpGet, ActionName("index")]
        public async Task<IActionResult> IndexQ(string q)
        {
            var query = _context.Operas.AsQueryable();
            if (!string.IsNullOrEmpty(q))
            {
                query = _context.Operas.Where(o => o.Title.Contains(q));
            }
            return View(await query.ToListAsync());
        }

        //[HttpGet, ActionName("index")]
        public async Task<IActionResult> IndexS(string sortOrder)
        {
            ViewBag.titleSort = sortOrder == "title" ? "title_desc" : "title";
            ViewBag.yearSort = sortOrder == "year" ? "year_desc" : "year";
            var query = _context.Operas.AsQueryable();
            switch (sortOrder)
            {
                case "title":
                    query = query.OrderBy(o => o.Title);
                    break;
                case "title_desc":
                    query = query.OrderByDescending(o => o.Title);
                    break;
                case "year":
                    query = query.OrderBy(o => o.Year);
                    break;
                case "year_desc":
                    query = query.OrderByDescending(o => o.Year);
                    break;
                default:
                    break;
            }
            return View(await query.ToListAsync());
        }

        //[HttpGet, ActionName("index")]
        public async Task<IActionResult> IndexP(int? page)
        {
            int pageSize = 3;
            return View(await PaginatedList<Opera>.CreateAsync(_context.Operas, page ?? 1, pageSize));
        }

        [HttpGet, ActionName("index")]
        public async Task<IActionResult> Index(string q, string sortOrder, string currentQ, int? page)
        {
            ViewBag.currentSort = sortOrder;
            if (q == null)
            {
                q = currentQ;
            }
            else
            {
                page = 1;
            }
            ViewBag.currentQ = q;

            // 篩選
            var query = _context.Operas.AsQueryable();
            if (!string.IsNullOrEmpty(q))
            {
                query = _context.Operas.Where(o => o.Title.Contains(q));
            }

            // 排序
            ViewBag.titleSort = sortOrder == "title" ? "title_desc" : "title";
            ViewBag.yearSort = sortOrder == "year" ? "year_desc" : "year";
            switch (sortOrder)
            {
                case "title":
                    query = query.OrderBy(o => o.Title);
                    break;
                case "title_desc":
                    query = query.OrderByDescending(o => o.Title);
                    break;
                case "year":
                    query = query.OrderBy(o => o.Year);
                    break;
                case "year_desc":
                    query = query.OrderByDescending(o => o.Year);
                    break;
                default:
                    break;
            }

            // 分頁
            int pageSize = 5;
            return View(await PaginatedList<Opera>.CreateAsync(query, page ?? 1, pageSize));
        }

        [ActionName("details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var opera = await _context.Operas.FirstOrDefaultAsync(m => m.OperaID == id);
            if (opera == null)
            {
                return NotFound();
            }
            return View(opera);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("create")]
        public async Task<IActionResult> Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(opera);
        }

        [ActionName("edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var opera = await _context.Operas.FindAsync(id);
            if (opera == null)
            {
                return NotFound();
            }
            return View(opera);
        }

        private bool OperaExists(int id)
        {
            return _context.Operas.Any(e => e.OperaID == id);
        }

        [HttpPost, ActionName("edit")]
        public async Task<IActionResult> Edit(int id, Opera opera)
        {
            if (id != opera.OperaID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperaExists(opera.OperaID))
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
            return View(opera);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var opera = await _context.Operas.FirstOrDefaultAsync(m => m.OperaID == id);
            if (opera == null)
            {
                return NotFound();
            }
            return View(opera);
        }

        [HttpPost, ActionName("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var opera = await _context.Operas.FindAsync(id);
            _context.Operas.Remove(opera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete2(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var opera = await _context.Operas.FirstOrDefaultAsync(m => m.OperaID == id);
            if (opera == null)
            {
                return NotFound();
            }
            _context.Operas.Remove(opera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }

}
