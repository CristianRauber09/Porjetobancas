using ProjetoBancaTCC_OO2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBancaTCC_OO2.Controllers
{
    public class ProfessorController : Controller
    {
        ProfessorRepositorio profRep = new ProfessorRepositorio();

        // GET: Professor
        public ActionResult Index()
        {
            var professores = profRep.getAll();

            return View(professores);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Professor pProfessor)
        {
            profRep.Create(pProfessor);
            return RedirectToAction("index");
        }

        public ActionResult Delete(int pId)
        {
            profRep.Delete(pId);
            return RedirectToAction("index");
        }

        public ActionResult Update(int pId)
        {
            var professor = profRep.GetOne(pId);
            return View();
        }

        [HttpPost]
        public ActionResult Update(Professor pProfessor)
        {
            profRep.Update(pProfessor);
            return RedirectToAction("index");
        }
    }
}