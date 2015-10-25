using BancaTCC.core;
using BancaTCC.repository.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancaTCC.repository
{
    public class AlunoController : Controller
    {
        AlunoRepositorio alunoRep = new AlunoRepositorio();

        // GET: Aluno
        public ActionResult Index()
        {
            return View(AlunoRepositorio.alunos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Aluno pAluno)
        {
            alunoRep.Create(pAluno);
            return RedirectToAction("index");
        }

        public ActionResult Delete(int pId)
        {
            alunoRep.Delete(pId);
            return RedirectToAction("index");
        }

        public ActionResult Update(int pId)
        {
            var aluno = alunoRep.GetOne(pId);
                return View(aluno);
        }

        [HttpPost]
        public ActionResult Update(Aluno paluno)
        {
            alunoRep.Update(paluno);
            return RedirectToAction("index");
        }

        
    }
}