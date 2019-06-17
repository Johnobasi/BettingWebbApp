using BettingWebbApp.Domain.Abstract;
using BettingWebbApp.Domain.Entities;
using BettingWebbApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BettingWebbApp.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IBettingRepository repository;
        public CartController(IBettingRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index (string returnUrl)
        {
            return View(new OddIndexViewModel { Cart = GetCart(), returnUrl = returnUrl });
        }

        public RedirectToRouteResult AddToCart(int BettingId, string returnUrl)
        {
            Betting betting = repository.bettings.FirstOrDefault(b => b.BettingId == BettingId);
            if(betting != null)
            {
                GetCart().AddOdd(betting, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
   
        }

        public RedirectToRouteResult RemoveFromCart(int BettingId, string returnUrl)
        {
            Betting betting = repository.bettings.FirstOrDefault(b => b.BettingId == BettingId);
            if (betting != null)
            {
                GetCart().RemoveOdd(betting);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if(cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        
    }

}