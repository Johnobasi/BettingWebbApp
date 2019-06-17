using BettingWebbApp.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BettingWebbApp.WebUI.Controllers
{
    public class BettingController : Controller
    {
        private readonly IBettingRepository repository;
        public BettingController(IBettingRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.bettings);
        }
    }
}