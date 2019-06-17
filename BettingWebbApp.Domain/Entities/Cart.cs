using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingWebbApp.Domain.Entities
{
    
    public class Cart
    {
        private List<CardLine> lineCollection = new List<CardLine>();

        public void AddOdd (Betting betting, int quantity)
        {
            CardLine line = lineCollection.Where(b => b.Betting == betting)
                                          .FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(
                    new CardLine { Betting = betting, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveOdd (Betting betting)
        {
            lineCollection.RemoveAll(b => b.Betting == betting);
        }

        public decimal ComputeTotalAmount()
        {
            return lineCollection.Sum(b => b.Betting.Amount * b.Quantity);
        }

        public IEnumerable<CardLine> Lines
        {
            get { return lineCollection; }
        }

        public void clear()
        {
            lineCollection.Clear();
        }
    }
}
