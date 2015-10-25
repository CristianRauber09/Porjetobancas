using BancaTCC.core;
using BancaTCC.repository;
using BancaTCC.repository.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBancaTCC_OO2.Controllers
{
    public class DisciplinaController : Controller
    {
        DisciplinaRepositorio discRep = new DisciplinaRepositorio();

        // GET: Disciplina
        public ActionResult Index()
        {
            return View(DisciplinaRepositorio.disciplinas);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Disciplina pDisciplina)
        {
            discRep.Create(pDisciplina);
            return RedirectToAction("index");
        }

        public ActionResult Delete(int pId)
        {
            discRep.Delete(pId);
            return RedirectToAction("index");
        }

        public ActionResult Update(int pId)
        {
            var disciplina = discRep.GetOne(pId);
            return View(disciplina);
        }

        [HttpPost]
        public ActionResult Update(Disciplina pDisciplina)
        {
            //discRep.Update(pDisciplina);
            return RedirectToAction("index");
        }
    }
}