using BettingWebbApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingWebbApp.Domain.Concrete
{
    public class BettingContext : DbContext
    {
        public BettingContext()
        {

        }
        public DbSet<Betting> betting { get; set; }
    }
}
