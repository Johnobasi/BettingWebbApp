using BettingWebbApp.Domain.Abstract;
using BettingWebbApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BettingWebbApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IBettingRepository repository;
        public AdminController(IBettingRepository repo)
        {
            repository = repo;
        }
        public ActionResult Index()
        {
            return View(repository.bettings);
        }


        public ViewResult Create()
        {
            return View(new Betting());
        }

        [HttpPost]
        public ActionResult Create(Betting betting)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOdd(betting);
                TempData["message"] = string.Format("{0} has been saved", betting.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(betting);
            }
        }

        public ViewResult Edit(int BettingId)
        {
            Betting betting = repository.bettings.FirstOrDefault(p => p.BettingId == BettingId);

            return View(betting);
        }

        [HttpPost]
        public ActionResult Edit(Betting betting)
        {
            if (ModelState.IsValid)
            {
                repository.SaveOdd(betting);
                TempData["message"] = string.Format("{0} has been saved", betting.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(betting);
            }
        }

        [HttpPost]
        public ActionResult Delete(int BettingId)
        {
            Betting deleteOdd = repository.DeleteOdd(BettingId);
            if (deleteOdd != null)
            {
                TempData["message"] = string.Format("{0} was deleted", deleteOdd.Name);
            }
            return RedirectToAction("Index");

        }
    }
}