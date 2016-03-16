using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApp1.Models;
using WebApp1.ViewModels.Grupo;
using Microsoft.AspNet.Authorization;
using System;

namespace WebApp1.Controllers
{
    public class GruposController : Controller
    {
        private ApplicationDbContext _context;

        public GruposController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NovoGrupoViewModels
        //public IActionResult Index()
        //{
        //    return View(_context.NovoGrupoViewModel.ToList());
        //}

        // GET: NovoGrupoViewModels/Details/5
        //public IActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    NovoGrupoViewModel novoGrupoViewModel = _context.NovoGrupoViewModel.Single(m => m.PK_GRUP_CD_CODIGO == id);
        //    if (novoGrupoViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(novoGrupoViewModel);
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult NovoGrupo()
        {

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }


        // POST: NovoGrupoViewModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovoGrupo(NovoGrupoViewModel novoGrupoViewModel)
        {
            if (ModelState.IsValid)
            {
                var grupo = new Grupo
                {
                    GRUP_NM_NOME = novoGrupoViewModel.Nome,
                    GRUP_DT_INCLUSAO = DateTime.Now,
                    GRUP_CD_USUARIO_ADMINISTRADOR = 1,
                    GRUP_CD_USUARIO_TESOUREIRO = 1,
                    FK_TIGR_GRUP_CODIGO = int.Parse(novoGrupoViewModel.Tipo)
                };
                _context.Grupo.Add(grupo);
                _context.SaveChanges();
                return RedirectToAction("MeusGrupos");
            }
            return View(novoGrupoViewModel);
        }

        //// GET: NovoGrupoViewModels/Edit/5
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    NovoGrupoViewModel novoGrupoViewModel = _context.NovoGrupoViewModel.Single(m => m.PK_GRUP_CD_CODIGO == id);
        //    if (novoGrupoViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(novoGrupoViewModel);
        //}

        //// POST: NovoGrupoViewModels/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(NovoGrupoViewModel novoGrupoViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(novoGrupoViewModel);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(novoGrupoViewModel);
        //}

        //// GET: NovoGrupoViewModels/Delete/5
        //[ActionName("Delete")]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    NovoGrupoViewModel novoGrupoViewModel = _context.NovoGrupoViewModel.Single(m => m.PK_GRUP_CD_CODIGO == id);
        //    if (novoGrupoViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(novoGrupoViewModel);
        //}

        //// POST: NovoGrupoViewModels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    NovoGrupoViewModel novoGrupoViewModel = _context.NovoGrupoViewModel.Single(m => m.PK_GRUP_CD_CODIGO == id);
        //    _context.NovoGrupoViewModel.Remove(novoGrupoViewModel);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
