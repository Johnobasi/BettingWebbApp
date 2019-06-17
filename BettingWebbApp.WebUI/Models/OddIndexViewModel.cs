using BettingWebbApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BettingWebbApp.WebUI.Models
{
    public class OddIndexViewModel
    {
        public Cart Cart { get; set; }
        public string returnUrl { get; set; }
    }
}