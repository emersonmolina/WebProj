using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApp1.Models;
using WebApp1.Dal.Contexto;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp1.Controllers
{
    public class PessoasController : Controller
    {
        BancoContexto db = new BancoContexto();

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("PESS_TX_SENHA", "PESS_NM_NOME", "PESS_NM_EMAIL", "PESS_DT_DATA_NASCIMENTO","RepetirSenha")] Pessoa pessoa)
        {

            //PessoasController objPessoaControler = new PessoasController();

            if (ModelState.IsValid)
            {
                pessoa.PESS_DT_INCLUSAO = DateTime.Now;

                //inclusão do status
                pessoa.PESS_ST_ATIVO = true;

                //salvo os dados
                db.Pessoas.Add(pessoa);
                //db.Pessoas.Add(pessoa);
                db.SaveChanges();

                //objPessoaControler.Create(pessoa);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

    }
}
































//using System.Linq;
//using WebApp1.Dal.Contexto;
//using Microsoft.AspNet.Mvc;
//using WebApp1.Models;
//using System;

//namespace WebApp1.Controllers
//{
//    public class PessoasController : Controller
//    {
//        private BancoContexto db = new BancoContexto();

//        //GET: /<controller>/
//        public IActionResult Index()
//        {
//            return View();
//        }

//        // POST: Pessoas/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind("PESS_TX_SENHA", "PESS_NM_NOME", "PESS_NM_EMAIL", "PESS_DT_DATA_NASCIMENTO")] Models.Pessoa pessoa)
//        {

//            if (ModelState.IsValid)
//            {
//                pessoa.PESS_DT_INCLUSAO = DateTime.Now;

//                //inclusão do status
//                pessoa.PESS_ST_ATIVO = true;

//                //salvo os dados
//                db.Pessoas.Add(pessoa);
//                db.SaveChanges();

//                //objPessoaControler.Create(pessoa);

//                return RedirectToAction("Index");
//            }

//            return RedirectToAction("Index");
//        }

//        //// GET: Pessoas/Details/5
//        //public ActionResult Details(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    Usuario usuario = db.Usuarios.Find(id);
//        //    if (usuario == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(usuario);
//        //}

//        // GET: Pessoas/Create
//        ////public ActionResult Create()
//        ////{
//        ////    return View();
//        ////}

//        //// GET: Pessoas/Edit/5
//        //public ActionResult Edit(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    Usuario usuario = db.Usuarios.Find(id);
//        //    if (usuario == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(usuario);
//        //}

//        //// GET: Pessoas/Delete/5
//        //public ActionResult Delete(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    Usuario usuario = db.Usuarios.Find(id);
//        //    if (usuario == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(usuario);
//        //}

//        //protected override void Dispose(bool disposing)
//        //{
//        //    if (disposing)
//        //    {
//        //        db.Dispose();
//        //    }
//        //    base.Dispose(disposing);
//        //}
//    }
//}
