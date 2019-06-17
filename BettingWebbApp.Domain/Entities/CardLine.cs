using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingWebbApp.Domain.Entities
{
    public class CardLine
    {
        public Betting Betting { get; set; }
        public int Quantity { get; set; }
    }
}
