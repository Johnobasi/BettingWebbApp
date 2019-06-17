using BettingWebbApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingWebbApp.Domain.Abstract
{
    public interface IBettingRepository
    {
        IEnumerable<Betting> bettings { get; }

        void SaveOdd(Betting betting);

        Betting DeleteOdd(int BettingId);

        //Betting Edit(int bettingId);
    }
}
