using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ProjetoMoto.Data.Context;
using ProjetoMoto.Data.Entities;
using ProjetoMoto.Data.Repository;
using ProjetoMoto.MVC.Models;

namespace ProjetoMoto.MVC.Controllers
{
    public class ContratadaController : Controller
    {
        ProjetoMotoContext db = new ProjetoMotoContext();

        public ContratadaController()
        {
            
        }

        // GET: Contratada
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<Contratada>, IEnumerable<ContratadaViewModel>>(db.Contratadas.ToList()));
        }

        // GET: Contratada/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contratada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contratada/Create
        [HttpPost]
        public ActionResult Create(ContratadaViewModel contratadaViewModel)
        {
            try
            {
                if (!ModelState.IsValid) return View(contratadaViewModel);
                
                db.Contratadas.Add(Mapper.Map<Contratada>(contratadaViewModel));
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contratada/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contratada/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contratada/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contratada/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
