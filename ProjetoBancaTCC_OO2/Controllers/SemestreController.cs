using BancaTCC.core;
using BancaTCC.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBancaTCC_OO2.Controllers
{
    public class SemestreController : Controller
    {
        SemestreRepositorio semestreRep = new SemestreRepositorio();

        // GET: Semestre
        public ActionResult Index()
        {
            return View(SemestreRepositorio.semestres);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Semestre pSemestre)
        {
            semestreRep.Create(pSemestre);
            return RedirectToAction("index");
        }

        public ActionResult Delete(int pId)
        {
            semestreRep.Delete(pId);
            return RedirectToAction("index");
        }

        public ActionResult Update(int pId)
        {
            var semestre = semestreRep.GetOne(pId);
            return View(semestre);
        }

        [HttpPost]
        public ActionResult Update(Semestre pSemestre)
        {
            semestreRep.Update(pSemestre);
            return RedirectToAction("index");
        }
    }
}