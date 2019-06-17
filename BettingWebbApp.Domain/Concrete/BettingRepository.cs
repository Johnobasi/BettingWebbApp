using BettingWebbApp.Domain.Abstract;
using BettingWebbApp.Domain.Entities;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingWebbApp.Domain.Concrete
{
    
    public class BettingRepository : IBettingRepository
    {
        private readonly BettingContext context = new BettingContext();

        public IEnumerable<Betting> bettings => context.betting;

        public void SaveOdd(Betting betting)
        {
            if (betting.BettingId == 0)
            {
                context.betting.Add(betting);
            }
            else
            {
                Betting dbEntry = context.betting.Find(betting.BettingId);
                if (dbEntry != null)
                {
                    dbEntry.Name = betting.Name;
                    dbEntry.Odd = betting.Odd;
                    dbEntry.Description = betting.Description;
                    dbEntry.Amount = betting.Amount;
                    dbEntry.Category = betting.Category;
                }
            }
            context.SaveChanges();
        }

        public Betting DeleteOdd(int BettingId)
        {
            Betting dbEntry = context.betting.Find(BettingId);
            if (dbEntry != null)
            {
                context.betting.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }

}
